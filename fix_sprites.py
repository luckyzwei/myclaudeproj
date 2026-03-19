#!/usr/bin/env python
"""
fix_sprites.py - Fix AssetRipper sprite .asset references for Unity 6

Problem: AssetRipper exports sprites as standalone .asset files. Unity 6 doesn't
load these at runtime, causing Image.sprite and SpriteRenderer.sprite to be null.

Solution: Redirect all sprite references in prefabs/scenes/anims from the .asset
files to the actual .png texture files (which Unity imports as sprites).

For single-sprite textures: spriteMode=1, fileID=21300000
For multi-sprite textures (atlas): spriteMode=2, spritesheet entries added,
  fileIDs generated via name hash and registered in internalIDToNameTable.

Handles:
- .prefab, .unity, .anim, .asset, .mat, .controller files
- Sprites with m_Name differing from texture filename
- AssetRipper duplicate sprites (_0, _1, ... suffixes with same name/rect)
- Atlas textures with multiple unique sub-sprites
- Two texture references per sprite .asset (m_RD vs m_AtlasRD); uses non-null one

Usage: python fix_sprites.py
"""

import os
import re
import sys
import hashlib
from collections import defaultdict

# --- Configuration -----------------------------------------------------------

PROJECT_ROOT = os.path.dirname(os.path.abspath(__file__))
CATPROJECT   = os.path.join(PROJECT_ROOT, "CatProject")
SPRITE_DIR   = os.path.join(CATPROJECT, "Assets", "Sprite")
ASSETS_DIR   = os.path.join(CATPROJECT, "Assets")

# File types to scan for sprite references (YAML-based Unity files)
SCAN_EXTENSIONS = (".prefab", ".unity", ".anim", ".asset", ".mat", ".controller")

# --- Utility -----------------------------------------------------------------

def read_text(path):
    """Read a text file, handling BOM and encoding issues."""
    for enc in ("utf-8-sig", "utf-8", "latin-1"):
        try:
            with open(path, "r", encoding=enc) as f:
                return f.read()
        except (UnicodeDecodeError, UnicodeError):
            continue
    return None


def guid_from_meta(meta_path):
    """Extract the guid field from a .meta file."""
    text = read_text(meta_path)
    if text is None:
        return None
    m = re.search(r"^guid:\s*([a-f0-9]+)", text, re.MULTILINE)
    return m.group(1) if m else None


def sprite_name_to_file_id(name):
    """
    Generate a deterministic fileID for a sprite name in Multiple sprite mode.
    Uses FNV-1a 32-bit hash, then combines with classID 213 (Sprite) to produce
    a stable positive int64 fileID, matching Unity's internal ID generation.
    """
    FNV_OFFSET = 0x811c9dc5
    FNV_PRIME  = 0x01000193
    h = FNV_OFFSET
    for ch in name.encode("utf-8"):
        h ^= ch
        h = (h * FNV_PRIME) & 0xFFFFFFFF
    # Combine: classID (213) in high bits, hash in low bits, ensure unique
    file_id = (213 * 100000) + (h % 100000)
    # Avoid collision with the default single-sprite fileID
    if file_id == 21300000:
        file_id = 21300001
    return file_id


def format_number(n):
    """Format a float as int if it has no fractional part, else as float."""
    if isinstance(n, float) and n == int(n):
        return str(int(n))
    return str(n)


# --- Phase 1: Parse sprite .asset files --------------------------------------

def parse_sprite_assets():
    """
    Parse all .asset files in Assets/Sprite/.
    Returns:
        sprite_guid_to_info: dict mapping sprite_asset_guid -> info dict
        texture_guid_to_sprites: dict mapping texture_guid -> list of info dicts
    """
    print("=" * 70)
    print("Phase 1: Parsing sprite .asset files...")
    print("=" * 70)

    sprite_guid_to_info = {}
    texture_guid_to_sprites = defaultdict(list)
    skipped = 0
    parsed = 0

    entries = os.listdir(SPRITE_DIR)
    for fname in entries:
        if not fname.endswith(".asset") or fname.endswith(".asset.meta"):
            continue

        asset_path = os.path.join(SPRITE_DIR, fname)
        meta_path  = asset_path + ".meta"

        if not os.path.exists(meta_path):
            skipped += 1
            continue

        sprite_guid = guid_from_meta(meta_path)
        if not sprite_guid:
            skipped += 1
            continue

        content = read_text(asset_path)
        if content is None:
            skipped += 1
            continue

        # Extract m_Name
        m_name = re.search(r"m_Name:\s*(.+)", content)
        name = m_name.group(1).strip() if m_name else os.path.splitext(fname)[0]

        # Extract texture GUID from m_RD block (non-null one)
        # Pattern: texture: {fileID: 2800000, guid: xxx, type: 3}
        tex_refs = re.findall(
            r"texture:\s*\{fileID:\s*2800000,\s*guid:\s*([a-f0-9]+)",
            content
        )
        if not tex_refs:
            skipped += 1
            continue
        texture_guid = tex_refs[0]  # First non-null texture ref (in m_RD block)

        # Extract rect
        rect_match = re.search(
            r"m_Rect:\s*\n\s*serializedVersion:\s*\d+\s*\n"
            r"\s*x:\s*([\d.eE+-]+)\s*\n"
            r"\s*y:\s*([\d.eE+-]+)\s*\n"
            r"\s*width:\s*([\d.eE+-]+)\s*\n"
            r"\s*height:\s*([\d.eE+-]+)",
            content
        )
        rect = {"x": 0, "y": 0, "width": 0, "height": 0}
        if rect_match:
            rect = {
                "x": float(rect_match.group(1)),
                "y": float(rect_match.group(2)),
                "width": float(rect_match.group(3)),
                "height": float(rect_match.group(4)),
            }

        # Extract pivot
        pivot_match = re.search(
            r"m_Pivot:\s*\{x:\s*([\d.eE+-]+),\s*y:\s*([\d.eE+-]+)\}", content
        )
        pivot = {"x": 0.5, "y": 0.5}
        if pivot_match:
            pivot = {
                "x": float(pivot_match.group(1)),
                "y": float(pivot_match.group(2)),
            }

        # Extract border
        border_match = re.search(
            r"m_Border:\s*\{x:\s*([\d.eE+-]+),\s*y:\s*([\d.eE+-]+),"
            r"\s*z:\s*([\d.eE+-]+),\s*w:\s*([\d.eE+-]+)\}",
            content
        )
        border = {"x": 0, "y": 0, "z": 0, "w": 0}
        if border_match:
            border = {
                "x": float(border_match.group(1)),
                "y": float(border_match.group(2)),
                "z": float(border_match.group(3)),
                "w": float(border_match.group(4)),
            }

        # Extract pixelsToUnits
        ptu_match = re.search(r"m_PixelsToUnits:\s*([\d.eE+-]+)", content)
        pixels_to_units = float(ptu_match.group(1)) if ptu_match else 100.0

        info = {
            "name": name,
            "texture_guid": texture_guid,
            "sprite_guid": sprite_guid,
            "rect": rect,
            "pivot": pivot,
            "border": border,
            "pixels_to_units": pixels_to_units,
            "file": fname,
        }

        sprite_guid_to_info[sprite_guid] = info
        texture_guid_to_sprites[texture_guid].append(info)
        parsed += 1

    print(f"  Parsed {parsed} sprite .asset files ({skipped} skipped)")
    print(f"  Unique texture GUIDs referenced: {len(texture_guid_to_sprites)}")
    return sprite_guid_to_info, texture_guid_to_sprites


# --- Phase 2: Build GUID->path map for texture .meta files -------------------

def build_texture_guid_map(texture_guids_needed):
    """
    Search all .meta files under Assets/ to find textures by GUID.
    Returns: dict mapping texture_guid -> png_file_path
    """
    print()
    print("=" * 70)
    print("Phase 2: Building texture GUID -> path map...")
    print("=" * 70)

    guid_to_path = {}
    remaining = set(texture_guids_needed)

    for dirpath, dirnames, filenames in os.walk(ASSETS_DIR):
        # Skip the Sprite .asset directory itself
        norm_dir = os.path.normpath(dirpath)
        norm_sprite = os.path.normpath(SPRITE_DIR)
        if norm_dir == norm_sprite:
            continue

        for fname in filenames:
            if not fname.endswith(".png.meta"):
                continue
            meta_path = os.path.join(dirpath, fname)
            g = guid_from_meta(meta_path)
            if g and g in remaining:
                png_path = meta_path[:-5]  # remove .meta
                guid_to_path[g] = png_path
                remaining.discard(g)
                if not remaining:
                    break
        if not remaining:
            break

    found = len(guid_to_path)
    missing = len(texture_guids_needed) - found
    print(f"  Found {found} texture files, {missing} not found")
    if 0 < missing <= 20:
        for g in sorted(texture_guids_needed):
            if g not in guid_to_path:
                print(f"    MISSING: texture guid {g}")
    elif missing > 20:
        print(f"    (showing first 20 missing)")
        count = 0
        for g in sorted(texture_guids_needed):
            if g not in guid_to_path:
                print(f"    MISSING: texture guid {g}")
                count += 1
                if count >= 20:
                    break

    return guid_to_path


# --- Phase 3: Classify textures and determine sprite mode --------------------

def classify_textures(texture_guid_to_sprites):
    """
    Classify each texture as single-sprite or multi-sprite (atlas).
    Deduplicates AssetRipper's _0, _1, ... clones by sprite name.
    Returns:
        single_textures: set of texture_guids with exactly one unique sprite
        atlas_textures: dict of texture_guid -> list of unique sprite infos
    """
    print()
    print("=" * 70)
    print("Phase 3: Classifying textures (single vs atlas)...")
    print("=" * 70)

    single_textures = set()
    atlas_textures = {}

    for tex_guid, sprites in texture_guid_to_sprites.items():
        # Deduplicate by sprite name (AssetRipper creates _0, _1, ... duplicates)
        unique_by_name = {}
        for s in sprites:
            if s["name"] not in unique_by_name:
                unique_by_name[s["name"]] = s

        if len(unique_by_name) == 1:
            single_textures.add(tex_guid)
        else:
            atlas_textures[tex_guid] = list(unique_by_name.values())

    print(f"  Single-sprite textures: {len(single_textures)}")
    print(f"  Atlas textures (multiple unique sprites): {len(atlas_textures)}")
    for tex_guid, sprites in atlas_textures.items():
        print(f"    Atlas {tex_guid}: {len(sprites)} sprites")
        for s in sprites[:5]:
            print(f"      - {s['name']}")
        if len(sprites) > 5:
            print(f"      ... and {len(sprites) - 5} more")

    return single_textures, atlas_textures


# --- Phase 4: Update texture .meta import settings ---------------------------

def update_texture_meta(texture_guid_to_path, single_textures, atlas_textures):
    """
    Ensure texture .meta files have correct spriteMode and textureType.
    For atlas textures, add spritesheet entries and internalIDToNameTable.

    Returns:
        atlas_file_id_map: dict of (texture_guid, sprite_name) -> fileID
    """
    print()
    print("=" * 70)
    print("Phase 4: Updating texture .meta import settings...")
    print("=" * 70)

    updated = 0
    already_ok = 0
    atlas_file_id_map = {}

    for tex_guid, tex_path in texture_guid_to_path.items():
        meta_path = tex_path + ".meta"
        if not os.path.exists(meta_path):
            continue

        content = read_text(meta_path)
        if content is None:
            continue

        original = content
        is_atlas = tex_guid in atlas_textures

        # Ensure textureType: 8 (Sprite)
        content = re.sub(r"(textureType:\s*)\d+", r"\g<1>8", content)

        if is_atlas:
            # Set spriteMode: 2 (Multiple)
            content = re.sub(r"(spriteMode:\s*)\d+", r"\g<1>2", content)

            sprites = atlas_textures[tex_guid]

            # Generate fileIDs for each unique sprite name
            id_table_entries = []
            used_ids = set()

            for sprite_info in sprites:
                sname = sprite_info["name"]
                fid = sprite_name_to_file_id(sname)
                # Handle collisions
                while fid in used_ids:
                    fid += 1
                used_ids.add(fid)
                atlas_file_id_map[(tex_guid, sname)] = fid
                id_table_entries.append((fid, sname))

            # Build spritesheet entries
            spritesheet_entries = []
            for sprite_info in sprites:
                sname = sprite_info["name"]
                r = sprite_info["rect"]
                p = sprite_info["pivot"]
                b = sprite_info["border"]
                sprite_id = hashlib.md5(sname.encode("utf-8")).hexdigest()
                fid = atlas_file_id_map[(tex_guid, sname)]
                spritesheet_entries.append({
                    "name": sname,
                    "rect": r,
                    "pivot": p,
                    "border": b,
                    "sprite_id": sprite_id,
                    "internal_id": fid,
                })

            # Build internalIDToNameTable YAML
            id_table_yaml = "  internalIDToNameTable:\n"
            for fid, sname in id_table_entries:
                id_table_yaml += "  - first:\n"
                id_table_yaml += f"      213: {fid}\n"
                id_table_yaml += f"    second: {sname}\n"

            # Replace existing internalIDToNameTable
            content = re.sub(
                r"  internalIDToNameTable:.*?\n  externalObjects:",
                id_table_yaml + "  externalObjects:",
                content,
                flags=re.DOTALL,
            )

            # Build spriteSheet section YAML
            sprites_yaml = "  spriteSheet:\n"
            sprites_yaml += "    serializedVersion: 2\n"
            sprites_yaml += "    sprites:\n"
            for entry in spritesheet_entries:
                r = entry["rect"]
                p = entry["pivot"]
                b = entry["border"]
                sprites_yaml += "    - serializedVersion: 2\n"
                sprites_yaml += f"      name: {entry['name']}\n"
                sprites_yaml += "      rect:\n"
                sprites_yaml += "        serializedVersion: 2\n"
                sprites_yaml += f"        x: {format_number(r['x'])}\n"
                sprites_yaml += f"        y: {format_number(r['y'])}\n"
                sprites_yaml += f"        width: {format_number(r['width'])}\n"
                sprites_yaml += f"        height: {format_number(r['height'])}\n"
                sprites_yaml += "      alignment: 0\n"
                sprites_yaml += f"      pivot: {{x: {format_number(p['x'])}, y: {format_number(p['y'])}}}\n"
                sprites_yaml += f"      border: {{x: {format_number(b['x'])}, y: {format_number(b['y'])}, z: {format_number(b['z'])}, w: {format_number(b['w'])}}}\n"
                sprites_yaml += "      outline: []\n"
                sprites_yaml += "      customData: \n"
                sprites_yaml += "      physicsShape: []\n"
                sprites_yaml += "      tessellationDetail: 0\n"
                sprites_yaml += "      bones: []\n"
                sprites_yaml += f"      spriteID: {entry['sprite_id']}\n"
                sprites_yaml += f"      internalID: {entry['internal_id']}\n"
                sprites_yaml += "      vertices: []\n"
                sprites_yaml += "      indices: \n"
                sprites_yaml += "      edges: []\n"
                sprites_yaml += "      weights: []\n"
            sprites_yaml += "    outline: []\n"
            sprites_yaml += "    customData: \n"
            sprites_yaml += "    physicsShape: []\n"
            sprites_yaml += "    bones: []\n"

            # Replace existing spriteSheet section up to and including "bones: []"
            content = re.sub(
                r"  spriteSheet:\n    serializedVersion: \d+\n    sprites:.*?\n    bones: \[\]",
                sprites_yaml.rstrip("\n"),
                content,
                flags=re.DOTALL,
            )

        else:
            # Single sprite: ensure spriteMode: 1
            content = re.sub(r"(spriteMode:\s*)\d+", r"\g<1>1", content)

        if content != original:
            with open(meta_path, "w", encoding="utf-8", newline="\n") as f:
                f.write(content)
            updated += 1
        else:
            already_ok += 1

    print(f"  Updated {updated} texture .meta files")
    print(f"  Already correct: {already_ok}")
    return atlas_file_id_map


# --- Phase 5: Build sprite GUID replacement map ------------------------------

def build_replacement_map(sprite_guid_to_info, texture_guid_to_path,
                          single_textures, atlas_textures, atlas_file_id_map):
    """
    Build the mapping: sprite_asset_guid -> (texture_png_guid, new_fileID)
    """
    print()
    print("=" * 70)
    print("Phase 5: Building sprite GUID replacement map...")
    print("=" * 70)

    replacement_map = {}  # sprite_guid -> (new_guid, new_fileID)
    unmapped = 0

    for sprite_guid, info in sprite_guid_to_info.items():
        tex_guid = info["texture_guid"]
        if tex_guid not in texture_guid_to_path:
            unmapped += 1
            continue

        if tex_guid in single_textures:
            # Single sprite: fileID stays 21300000
            replacement_map[sprite_guid] = (tex_guid, 21300000)
        elif tex_guid in atlas_textures:
            # Atlas sprite: look up the generated fileID by name
            key = (tex_guid, info["name"])
            if key in atlas_file_id_map:
                replacement_map[sprite_guid] = (tex_guid, atlas_file_id_map[key])
            else:
                # This sprite's name wasn't in the unique set (it's a duplicate)
                # Find the canonical entry for this name
                for s in atlas_textures[tex_guid]:
                    if s["name"] == info["name"]:
                        canonical_key = (tex_guid, s["name"])
                        if canonical_key in atlas_file_id_map:
                            replacement_map[sprite_guid] = (
                                tex_guid,
                                atlas_file_id_map[canonical_key],
                            )
                            break
                else:
                    unmapped += 1
        else:
            unmapped += 1

    print(f"  Mapped {len(replacement_map)} sprite GUIDs -> texture references")
    print(f"  Unmapped (texture not found): {unmapped}")
    return replacement_map


# --- Phase 6: Replace references in prefab/scene/anim files ------------------

def replace_references(replacement_map):
    """
    Scan all .prefab, .unity, .anim, .mat, .controller, .asset files and replace
    sprite .asset references with texture .png references.

    Old: {fileID: 21300000, guid: <sprite_asset_guid>, type: 2}
    New: {fileID: <new_fileID>, guid: <texture_png_guid>, type: 3}

    Note: Only GUIDs present in replacement_map are touched; other type:2 refs
    (scripts, native assets, etc.) are left untouched.
    """
    print()
    print("=" * 70)
    print("Phase 6: Replacing sprite references in project files...")
    print("=" * 70)

    sprite_guid_set = set(replacement_map.keys())

    files_modified = 0
    refs_replaced = 0
    files_scanned = 0

    for dirpath, dirnames, filenames in os.walk(ASSETS_DIR):
        # Skip Sprite .asset directory (don't modify the source .asset files)
        norm_dir = os.path.normpath(dirpath)
        norm_sprite = os.path.normpath(SPRITE_DIR)
        if norm_dir == norm_sprite:
            continue

        for fname in filenames:
            ext = os.path.splitext(fname)[1].lower()
            if ext not in SCAN_EXTENSIONS:
                continue

            fpath = os.path.join(dirpath, fname)
            content = read_text(fpath)
            if content is None:
                continue

            files_scanned += 1

            # Quick check: does this file contain "type: 2}" at all?
            if "type: 2}" not in content:
                continue

            file_refs = 0

            def replace_sprite_ref(m):
                nonlocal file_refs
                guid = m.group(2)
                if guid in sprite_guid_set:
                    new_guid, new_file_id = replacement_map[guid]
                    file_refs += 1
                    return "{{fileID: {fid}, guid: {guid}, type: 3}}".format(
                        fid=new_file_id, guid=new_guid
                    )
                return m.group(0)

            # Match pattern: {fileID: <number>, guid: <32hex>, type: 2}
            new_content = re.sub(
                r"\{fileID:\s*(\d+),\s*guid:\s*([a-f0-9]{32}),\s*type:\s*2\}",
                replace_sprite_ref,
                content,
            )

            if file_refs > 0:
                with open(fpath, "w", encoding="utf-8", newline="\n") as f:
                    f.write(new_content)
                files_modified += 1
                refs_replaced += file_refs
                if files_modified <= 50 or files_modified % 100 == 0:
                    relpath = os.path.relpath(fpath, CATPROJECT)
                    print(f"  [{files_modified:>4}] {relpath}: {file_refs} refs replaced")

    print()
    print(f"  Files scanned:    {files_scanned}")
    print(f"  Files modified:   {files_modified}")
    print(f"  Refs replaced:    {refs_replaced}")
    return files_modified, refs_replaced


# --- Main --------------------------------------------------------------------

def main():
    print("fix_sprites.py - Fix AssetRipper sprite .asset references for Unity 6")
    print(f"Project root: {CATPROJECT}")
    print()

    if not os.path.isdir(SPRITE_DIR):
        print(f"ERROR: Sprite directory not found: {SPRITE_DIR}")
        sys.exit(1)
    if not os.path.isdir(ASSETS_DIR):
        print(f"ERROR: Assets directory not found: {ASSETS_DIR}")
        sys.exit(1)

    # Phase 1: Parse sprite .asset files
    sprite_guid_to_info, texture_guid_to_sprites = parse_sprite_assets()

    if not sprite_guid_to_info:
        print("\nNo sprite .asset files found. Nothing to do.")
        return

    # Phase 2: Find texture files by GUID
    texture_guid_to_path = build_texture_guid_map(set(texture_guid_to_sprites.keys()))

    # Phase 3: Classify textures (single vs atlas)
    single_textures, atlas_textures = classify_textures(texture_guid_to_sprites)

    # Phase 4: Update texture .meta files (spriteMode, textureType, spritesheet)
    atlas_file_id_map = update_texture_meta(
        texture_guid_to_path, single_textures, atlas_textures
    )

    # Phase 5: Build replacement map (sprite_asset_guid -> texture_guid + fileID)
    replacement_map = build_replacement_map(
        sprite_guid_to_info, texture_guid_to_path,
        single_textures, atlas_textures, atlas_file_id_map
    )

    if not replacement_map:
        print("\nNo replacements to make. Check for missing texture files.")
        return

    # Phase 6: Replace references in project files
    files_modified, refs_replaced = replace_references(replacement_map)

    # Summary
    print()
    print("=" * 70)
    print("SUMMARY")
    print("=" * 70)
    print(f"  Sprite .asset files parsed:     {len(sprite_guid_to_info)}")
    print(f"  Unique textures referenced:     {len(texture_guid_to_sprites)}")
    print(f"    Single-sprite textures:       {len(single_textures)}")
    print(f"    Atlas textures:               {len(atlas_textures)}")
    print(f"  Texture files found:            {len(texture_guid_to_path)}")
    print(f"  Sprite GUIDs mapped:            {len(replacement_map)}")
    print(f"  Project files modified:         {files_modified}")
    print(f"  Sprite references replaced:     {refs_replaced}")
    print()
    print("Next steps:")
    print("  1. Open the project in Unity")
    print("  2. Unity will reimport the modified texture .meta files")
    print("  3. Verify sprites appear correctly in prefabs and at runtime")
    print("  4. Optionally delete Assets/Sprite/ folder if no longer needed")
    print()
    print("Done!")


if __name__ == "__main__":
    main()
