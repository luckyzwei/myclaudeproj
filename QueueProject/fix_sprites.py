"""
Fix sprite rendering by rebuilding texture meta spriteSheet data
and updating prefab references from standalone .asset files to texture sub-sprites.

Problem: AssetRipper exports sprites as standalone .asset files, but Unity 6 may not
properly render them. The fix is to define sprites in the texture's .meta spriteSheet
and update all prefab references accordingly.
"""

import os
import re
import hashlib
from collections import defaultdict

PROJECT = 'I:/client/myclaudeproj/QueueProject'
SPRITE_DIR = os.path.join(PROJECT, 'Assets/Sprite')
PREFAB_DIRS = [
    os.path.join(PROJECT, 'Assets/Resources/prefabs'),
]
ASSET_ROOT = os.path.join(PROJECT, 'Assets')

def parse_sprite_asset(path):
    """Extract sprite data from a .asset file."""
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    info = {}

    # Name
    m = re.search(r'm_Name:\s*(.+)', content)
    info['name'] = m.group(1).strip() if m else os.path.basename(path).replace('.asset','')

    # Texture GUID from m_RD section
    m = re.search(r'm_RD:.*?texture:\s*\{fileID:\s*(\d+),\s*guid:\s*(\w+),\s*type:\s*(\d+)\}', content, re.DOTALL)
    if m:
        info['tex_fileid'] = int(m.group(1))
        info['tex_guid'] = m.group(2)
        info['tex_type'] = int(m.group(3))
    else:
        return None

    # m_Rect
    m = re.search(r'm_Rect:\s*\n\s*serializedVersion:\s*\d+\s*\n\s*x:\s*([\d.e+-]+)\s*\n\s*y:\s*([\d.e+-]+)\s*\n\s*width:\s*([\d.e+-]+)\s*\n\s*height:\s*([\d.e+-]+)', content)
    if m:
        info['rect'] = {'x': m.group(1), 'y': m.group(2), 'w': m.group(3), 'h': m.group(4)}
    else:
        return None

    # m_Border
    m = re.search(r'm_Border:\s*\{x:\s*([\d.e+-]+),\s*y:\s*([\d.e+-]+),\s*z:\s*([\d.e+-]+),\s*w:\s*([\d.e+-]+)\}', content)
    if m:
        info['border'] = {'x': m.group(1), 'y': m.group(2), 'z': m.group(3), 'w': m.group(4)}
    else:
        info['border'] = {'x': '0', 'y': '0', 'z': '0', 'w': '0'}

    # m_Pivot
    m = re.search(r'm_Pivot:\s*\{x:\s*([\d.e+-]+),\s*y:\s*([\d.e+-]+)\}', content)
    if m:
        info['pivot'] = {'x': m.group(1), 'y': m.group(2)}
    else:
        info['pivot'] = {'x': '0.5', 'y': '0.5'}

    # Sprite asset GUID from .meta
    meta_path = path + '.meta'
    if os.path.exists(meta_path):
        with open(meta_path, 'r') as f:
            meta = f.read()
        m = re.search(r'guid:\s*(\w+)', meta)
        info['asset_guid'] = m.group(1) if m else None
    else:
        info['asset_guid'] = None

    return info


def generate_sprite_id():
    """Generate a random hex sprite ID."""
    return hashlib.md5(os.urandom(16)).hexdigest()[:32]


def build_sprite_entry(sprite, internal_id):
    """Build a YAML sprite entry for the spriteSheet."""
    # Determine alignment: 0=Center, 9=Custom
    px, py = float(sprite['pivot']['x']), float(sprite['pivot']['y'])
    alignment = 0 if (abs(px - 0.5) < 0.001 and abs(py - 0.5) < 0.001) else 9

    return f"""    - serializedVersion: 2
      name: {sprite['name']}
      rect:
        serializedVersion: 2
        x: {sprite['rect']['x']}
        y: {sprite['rect']['y']}
        width: {sprite['rect']['w']}
        height: {sprite['rect']['h']}
      alignment: {alignment}
      pivot: {{x: {sprite['pivot']['x']}, y: {sprite['pivot']['y']}}}
      border: {{x: {sprite['border']['x']}, y: {sprite['border']['y']}, z: {sprite['border']['z']}, w: {sprite['border']['w']}}}
      outline: []
      physicsShape: []
      tessellationDetail: -1
      bones: []
      spriteID: {generate_sprite_id()}
      internalID: {internal_id}
      vertices: []
      indices:
      edges: []
      weights: []"""


def update_texture_meta(meta_path, sprites):
    """Update a texture .meta file with spriteSheet data."""
    with open(meta_path, 'r', encoding='utf-8') as f:
        content = f.read()

    # Only process TextureImporter files
    if 'TextureImporter:' not in content:
        return None

    # Assign internal IDs (start from 21300000, increment by 2)
    id_map = {}  # sprite_name -> internal_id
    for i, sprite in enumerate(sprites):
        internal_id = 21300000 + i * 2
        id_map[sprite['name']] = internal_id

    # Build internalIDToNameTable
    id_table_entries = []
    for sprite in sprites:
        iid = id_map[sprite['name']]
        id_table_entries.append(f"  - first:\n      213: {iid}\n    second: {sprite['name']}")
    id_table_yaml = "\n".join(id_table_entries)

    # Build sprites YAML
    sprite_entries = []
    for sprite in sprites:
        iid = id_map[sprite['name']]
        sprite_entries.append(build_sprite_entry(sprite, iid))
    sprites_yaml = "\n".join(sprite_entries)

    # Build nameFileIdTable
    nfid_entries = []
    for sprite in sprites:
        iid = id_map[sprite['name']]
        nfid_entries.append(f"      {sprite['name']}: {{fileID: {iid}}}")
    nfid_yaml = "\n".join(nfid_entries)

    # Replace internalIDToNameTable
    content = re.sub(
        r'  internalIDToNameTable: \[\]',
        f'  internalIDToNameTable:\n{id_table_yaml}',
        content
    )

    # Replace sprites: []
    content = re.sub(
        r'    sprites: \[\]',
        f'    sprites:\n{sprites_yaml}',
        content
    )

    # Replace nameFileIdTable: {}
    content = re.sub(
        r'    nameFileIdTable: \{\}',
        f'    nameFileIdTable:\n{nfid_yaml}',
        content
    )

    with open(meta_path, 'w', encoding='utf-8') as f:
        f.write(content)

    return id_map


def find_all_files_with_ext(root, ext):
    """Find all files with given extension recursively."""
    result = []
    for dirpath, dirnames, filenames in os.walk(root):
        for f in filenames:
            if f.endswith(ext):
                result.append(os.path.join(dirpath, f))
    return result


def main():
    # Step 1: Parse all sprite assets
    print("Step 1: Parsing sprite assets...")
    sprites = []
    for f in os.listdir(SPRITE_DIR):
        if f.endswith('.asset') and not f.endswith('.meta'):
            info = parse_sprite_asset(os.path.join(SPRITE_DIR, f))
            if info and info.get('asset_guid'):
                sprites.append(info)
    print(f"  Parsed {len(sprites)} sprites")

    # Step 2: Group by texture GUID
    by_tex = defaultdict(list)
    for s in sprites:
        by_tex[s['tex_guid']].append(s)
    print(f"  Grouped into {len(by_tex)} textures")

    # Step 3: Build GUID map (texture GUID -> meta file path)
    print("Step 2: Building GUID map...")
    guid_to_meta = {}
    for dirpath, dirnames, filenames in os.walk(ASSET_ROOT):
        for f in filenames:
            if f.endswith('.png.meta') or f.endswith('.jpg.meta') or f.endswith('.tga.meta'):
                path = os.path.join(dirpath, f)
                with open(path, 'r', encoding='utf-8') as fh:
                    content = fh.read(300)
                m = re.search(r'guid:\s*(\w+)', content)
                if m:
                    guid_to_meta[m.group(1)] = path
    print(f"  Found {len(guid_to_meta)} texture meta files")

    # Step 4: Update texture metas and build reference mapping
    print("Step 3: Updating texture metas...")
    # old_ref (sprite asset GUID) -> new_ref (texture GUID, fileID)
    ref_map = {}  # sprite_asset_guid -> (tex_guid, internal_id)

    updated_textures = 0
    for tex_guid, tex_sprites in by_tex.items():
        meta_path = guid_to_meta.get(tex_guid)
        if not meta_path:
            print(f"  WARNING: No meta file for texture GUID {tex_guid} ({len(tex_sprites)} sprites)")
            continue

        id_map = update_texture_meta(meta_path, tex_sprites)
        if id_map is None:
            print(f"  SKIP: {meta_path} (not a TextureImporter)")
            continue

        updated_textures += 1

        # Build reference mapping
        for sprite in tex_sprites:
            if sprite['asset_guid']:
                iid = id_map[sprite['name']]
                ref_map[sprite['asset_guid']] = (tex_guid, iid)

    print(f"  Updated {updated_textures} texture metas")
    print(f"  Built {len(ref_map)} reference mappings")

    # Step 5: Update prefab references
    print("Step 4: Updating prefab/scene references...")

    # Find all prefabs, scenes, and other assets that might reference sprites
    target_files = []
    for ext in ['.prefab', '.unity', '.asset']:
        target_files.extend(find_all_files_with_ext(os.path.join(PROJECT, 'Assets/Resources'), ext))
        target_files.extend(find_all_files_with_ext(os.path.join(PROJECT, 'Assets/Scenes'), ext))

    # Also check MonoBehaviour assets that might reference sprites
    target_files.extend(find_all_files_with_ext(os.path.join(PROJECT, 'Assets/MonoBehaviour'), '.asset'))

    updated_files = 0
    total_replacements = 0

    for fpath in target_files:
        try:
            with open(fpath, 'r', encoding='utf-8') as f:
                content = f.read()
        except:
            continue

        new_content = content
        replacements = 0

        for old_guid, (new_guid, new_fileid) in ref_map.items():
            # Pattern: {fileID: 21300000, guid: <old_guid>, type: 2}
            old_pattern = f'{{fileID: 21300000, guid: {old_guid}, type: 2}}'
            new_ref = f'{{fileID: {new_fileid}, guid: {new_guid}, type: 3}}'

            if old_pattern in new_content:
                count = new_content.count(old_pattern)
                new_content = new_content.replace(old_pattern, new_ref)
                replacements += count

        if replacements > 0:
            with open(fpath, 'w', encoding='utf-8') as f:
                f.write(new_content)
            updated_files += 1
            total_replacements += replacements

    print(f"  Updated {updated_files} files with {total_replacements} reference replacements")
    print("\nDone!")


if __name__ == '__main__':
    main()
