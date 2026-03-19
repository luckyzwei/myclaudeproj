#!/usr/bin/env python3
"""
Unity 6 GUID Remap for CatProject.

Unity 6 changed ugui/TMP from DLL to built-in source package (com.unity.ugui).
Prefabs still reference the old DLL GUIDs from UnityEngine.UI.dll and
Unity.TextMeshPro.dll. This script replaces those references with the new
.cs file GUIDs from the Unity 6 ugui package.

Old format:  m_Script: {fileID: <dll_class_hash>, guid: <dll_guid>, type: 3}
New format:  m_Script: {fileID: 11500000, guid: <cs_file_guid>, type: 3}

Usage:
    python fix_guid_remap_catproject.py [--dry-run]
"""

import os
import re
import sys
import time

PROJECT_ROOT = os.path.join(os.path.dirname(os.path.abspath(__file__)), "CatProject")
ASSETS_DIR = os.path.join(PROJECT_ROOT, "Assets")

# File extensions to scan
EXTENSIONS = {".prefab", ".unity", ".asset", ".anim", ".controller"}

# =============================================================================
# Old DLL GUID: UnityEngine.UI.dll
# =============================================================================
UI_DLL_GUID = "d3e719b59ab71ba3f6b398058c866280"

# Mapping: old fileID -> (class_name, new .cs GUID from Unity 6 ugui package)
# Verified by inspecting serialized fields in CatProject prefabs.
# GUIDs from Unity 6 com.unity.ugui package .cs.meta files.
#
# NOTE: CatProject's AssetRipper export uses DIFFERENT fileID hashes than
# the standard Unity DLL hashes. Each mapping below was verified by reading
# the serialized fields of the component in actual prefab files.
UI_FILEID_MAP = {
    # --- Verified from CatProject prefab serialized fields ---
    # fileID: -765806418  (52628 occurrences) → m_Sprite, m_Type, m_PreserveAspect
    -765806418:   ("Image",                "fe87c0e1cc204ed48ad3b37840f39efc"),
    # fileID: 708705254   (9998 occurrences) → m_FontData, m_Font, m_Text
    708705254:    ("Text",                 "5f7201a12d95ffc409449d95f23cf332"),
    # fileID: 1679637790  (6208 occurrences) → m_IgnoreLayout, m_MinWidth, m_MinHeight
    1679637790:   ("LayoutElement",        "306cc8c2b49d7114eaa3623786fc2126"),
    # fileID: 1392445389  (5156 occurrences) → m_Navigation, m_Transition, m_OnClick
    1392445389:   ("Button",               "4e29b1a8efbd4b44bb3f3716e73f07ff"),
    # fileID: -405508275  (2222 occurrences) → m_Padding, m_ChildAlignment, m_Spacing (horizontal)
    -405508275:   ("HorizontalLayoutGroup","30649d3a9faa99c48a7b1166b86bf2a0"),
    # fileID: 1741964061  (429 occurrences) → m_HorizontalFit, m_VerticalFit
    1741964061:   ("ContentSizeFitter",    "3245ec927659c4140ac4f8d17403cc18"),
    # fileID: 1301386320  (298 occurrences) → m_IgnoreReversedGraphics, m_BlockingObjects
    1301386320:   ("GraphicRaycaster",     "dc42784cf147c0c48a680349fa168899"),
    # fileID: -1569823932 (86 occurrences) → m_CellSize, m_StartCorner, m_StartAxis
    -1569823932:  ("GridLayoutGroup",      "8a8695521f0d02e499659fee002a26c2"),
    # fileID: 575553740   (28 occurrences) → m_TextComponent, m_Placeholder, m_ContentType
    575553740:    ("InputField",           "d199490a83bb2b844b9695cbf13b01ef"),
}

# =============================================================================
# Custom script references that also use the old DLL GUID
# These map to project .cs files instead of Unity packages
# =============================================================================
CUSTOM_FILEID_MAP = {
    # fileID: 210166680 (1 occurrence in HUDTotal.prefab) → HUDTotal component
    # Verified: serialized fields include TotalRoot, ShopBtn, MissionBtn, etc.
    210166680:    ("HUDTotal",             "04dc263d8da3a839b17853abe0e291e1"),
}

# =============================================================================
# Old DLL GUID: Unity.TextMeshPro.dll (only ScriptableObject assets)
# =============================================================================
TMP_DLL_GUID = "67dfb1fdfb2b407222eda8e23ac8b724"

# Mapping: old fileID -> (class_name, new .cs GUID from Unity 6 ugui TMP package)
# GUIDs read from com.unity.ugui/Runtime/TMP/**/*.cs.meta
TMP_FILEID_MAP = {
    -667331979:   ("TMP_FontAsset",   "71c1514a6bd24e1e882cebbe1904ce04"),
    2019389346:   ("TMP_SpriteAsset", "84a92b25f83d49b9bc132d206b370281"),
    -395462249:   ("TMP_Settings",    "2705215ac5b84b70bacc50632be6e391"),
    -1936749209:  ("TMP_StyleSheet",  "ab2114bdc8544297b417dfefe9f1e410"),
}


def build_regex_and_replacement_map():
    """Build compiled regex patterns for fast matching."""
    replacements = {}

    # UI DLL replacements
    for file_id, (class_name, new_guid) in UI_FILEID_MAP.items():
        old_pattern = f"fileID: {file_id}, guid: {UI_DLL_GUID}, type: 3"
        new_text = f"fileID: 11500000, guid: {new_guid}, type: 3"
        replacements[old_pattern] = (new_text, class_name)

    # Custom script replacements (same DLL GUID, but map to project .cs files)
    for file_id, (class_name, new_guid) in CUSTOM_FILEID_MAP.items():
        old_pattern = f"fileID: {file_id}, guid: {UI_DLL_GUID}, type: 3"
        new_text = f"fileID: 11500000, guid: {new_guid}, type: 3"
        replacements[old_pattern] = (new_text, class_name)

    # TMP DLL replacements
    for file_id, (class_name, new_guid) in TMP_FILEID_MAP.items():
        old_pattern = f"fileID: {file_id}, guid: {TMP_DLL_GUID}, type: 3"
        new_text = f"fileID: 11500000, guid: {new_guid}, type: 3"
        replacements[old_pattern] = (new_text, class_name)

    return replacements


def find_target_files(assets_dir):
    """Find all files with target extensions under Assets/."""
    target_files = []
    for root, dirs, files in os.walk(assets_dir):
        for fname in files:
            ext = os.path.splitext(fname)[1].lower()
            if ext in EXTENSIONS:
                target_files.append(os.path.join(root, fname))
    return target_files


def process_file(filepath, replacements, dry_run=False):
    """Process a single file, replacing old DLL references with new .cs references.

    Returns: dict of class_name -> count of replacements made, or empty dict if no changes.
    """
    try:
        with open(filepath, "r", encoding="utf-8", errors="replace") as f:
            content = f.read()
    except Exception as e:
        print(f"  ERROR reading {filepath}: {e}")
        return {}

    changes = {}
    new_content = content

    for old_pattern, (new_text, class_name) in replacements.items():
        count = new_content.count(old_pattern)
        if count > 0:
            new_content = new_content.replace(old_pattern, new_text)
            changes[class_name] = changes.get(class_name, 0) + count

    if changes and not dry_run:
        try:
            with open(filepath, "w", encoding="utf-8", newline="\n") as f:
                f.write(new_content)
        except Exception as e:
            print(f"  ERROR writing {filepath}: {e}")
            return {}

    return changes


def check_remaining_references(assets_dir):
    """After processing, check if any old DLL GUID references remain unmapped."""
    remaining_ui = {}
    remaining_tmp = {}

    pattern_ui = re.compile(r"fileID:\s*(-?\d+),\s*guid:\s*" + UI_DLL_GUID)
    pattern_tmp = re.compile(r"fileID:\s*(-?\d+),\s*guid:\s*" + TMP_DLL_GUID)

    for root, dirs, files in os.walk(assets_dir):
        for fname in files:
            ext = os.path.splitext(fname)[1].lower()
            if ext not in EXTENSIONS:
                continue
            filepath = os.path.join(root, fname)
            try:
                with open(filepath, "r", encoding="utf-8", errors="replace") as f:
                    for line in f:
                        m = pattern_ui.search(line)
                        if m:
                            fid = int(m.group(1))
                            if fid not in UI_FILEID_MAP and fid not in CUSTOM_FILEID_MAP:
                                remaining_ui[fid] = remaining_ui.get(fid, 0) + 1
                        m = pattern_tmp.search(line)
                        if m:
                            fid = int(m.group(1))
                            if fid not in TMP_FILEID_MAP:
                                remaining_tmp[fid] = remaining_tmp.get(fid, 0) + 1
            except Exception:
                pass

    return remaining_ui, remaining_tmp


def main():
    dry_run = "--dry-run" in sys.argv

    if dry_run:
        print("=== DRY RUN MODE (no files will be modified) ===\n")

    print(f"Project root: {PROJECT_ROOT}")
    print(f"Assets dir:   {ASSETS_DIR}")
    print(f"Extensions:   {', '.join(sorted(EXTENSIONS))}")
    print()

    # Build replacement map
    replacements = build_regex_and_replacement_map()
    print(f"Replacement rules: {len(replacements)} (UI DLL: {len(UI_FILEID_MAP)}, TMP DLL: {len(TMP_FILEID_MAP)})")
    print()

    # Find target files
    print("Scanning for target files...")
    target_files = find_target_files(ASSETS_DIR)
    print(f"Found {len(target_files)} files to scan")
    print()

    # Process files
    total_changes = {}
    files_changed = 0
    files_scanned = 0
    start_time = time.time()

    for filepath in target_files:
        files_scanned += 1
        changes = process_file(filepath, replacements, dry_run)
        if changes:
            files_changed += 1
            rel_path = os.path.relpath(filepath, PROJECT_ROOT)
            detail = ", ".join(f"{name}x{cnt}" for name, cnt in sorted(changes.items()))
            print(f"  {'[DRY] ' if dry_run else ''}Fixed: {rel_path}  ({detail})")
            for name, cnt in changes.items():
                total_changes[name] = total_changes.get(name, 0) + cnt

        if files_scanned % 500 == 0:
            print(f"  ... scanned {files_scanned}/{len(target_files)} files ...")

    elapsed = time.time() - start_time
    print()
    print("=" * 60)
    print(f"{'DRY RUN ' if dry_run else ''}SUMMARY")
    print("=" * 60)
    print(f"Files scanned:  {files_scanned}")
    print(f"Files changed:  {files_changed}")
    print(f"Total replacements: {sum(total_changes.values())}")
    print(f"Time: {elapsed:.1f}s")
    print()

    if total_changes:
        print("Replacements by class:")
        for name, cnt in sorted(total_changes.items(), key=lambda x: -x[1]):
            print(f"  {name:30s} {cnt:6d}")
        print()

    # Check for remaining unmapped references
    print("Checking for remaining unmapped DLL references...")
    remaining_ui, remaining_tmp = check_remaining_references(ASSETS_DIR)

    if remaining_ui:
        print(f"\nWARNING: {len(remaining_ui)} unmapped UI DLL fileIDs remain:")
        for fid, cnt in sorted(remaining_ui.items(), key=lambda x: -x[1]):
            print(f"  fileID: {fid:15d}  ({cnt} occurrences)")
        print("  These need to be identified and added to UI_FILEID_MAP.")

    if remaining_tmp:
        print(f"\nWARNING: {len(remaining_tmp)} unmapped TMP DLL fileIDs remain:")
        for fid, cnt in sorted(remaining_tmp.items(), key=lambda x: -x[1]):
            print(f"  fileID: {fid:15d}  ({cnt} occurrences)")
        print("  These need to be identified and added to TMP_FILEID_MAP.")

    if not remaining_ui and not remaining_tmp:
        print("  All DLL references have been remapped successfully!")

    print()
    print("NOTE: After running this script, you should also ensure that:")
    print("  1. The old DLL files (UnityEngine.UI.dll, Unity.TextMeshPro.dll) are")
    print("     removed from Assets/Plugins/ (or excluded from compilation).")
    print("  2. The com.unity.ugui package is listed in Packages/manifest.json")
    print("     (Unity 6 includes it as a built-in, but verify it resolves).")


if __name__ == "__main__":
    main()
