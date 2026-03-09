"""
Fix Unity 6 script references: remap DLL-style (fileID+assemblyGUID) to
source-style (11500000+csFileGUID) for ugui and TMP components.
"""
import os
import glob
import re

ASSETS_DIR = os.path.join(os.path.dirname(os.path.abspath(__file__)), "Assets")

# Current (wrong) assembly GUIDs in our prefabs after the first remap
UI_ASM_GUID = "2bafac87e7f4b9b418d9448d219b01ab"
TMP_ASM_GUID = "6055be8ebefd69e48b49212b09b47b2f"

# Mapping: old fileID -> (class name, new .cs file GUID)
REMAP = {
    # UI classes (currently using UI_ASM_GUID)
    "-765806418":  ("Image",                "fe87c0e1cc204ed48ad3b37840f39efc"),
    "1392445389":  ("Button",               "4e29b1a8efbd4b44bb3f3716e73f07ff"),
    "-405508275":  ("HorizontalLayoutGroup", "30649d3a9faa99c48a7b1166b86bf2a0"),
    "1297475563":  ("VerticalLayoutGroup",   "59f8146938fff824cb5fd77236b75775"),
    "1741964061":  ("ContentSizeFitter",     "3245ec927659c4140ac4f8d17403cc18"),
    "1679637790":  ("LayoutElement",         "306cc8c2b49d7114eaa3623786fc2126"),
    "1301386320":  ("GraphicRaycaster",      "dc42784cf147c0c48a680349fa168899"),
    "-1200242548": ("Mask",                  "31a19414c41e5ae4aae2af33fee712f6"),
    "-146154839":  ("RectMask2D",            "3312d7739989d2b4e91e6319e9a96d76"),
    "-1184210157": ("ToggleGroup",           "2fafe2cfe61f6974895a912c3755e8f1"),
    "1367256648":  ("ScrollRect",            "1aa08ab6e0800fa44ae55d278d1423e3"),
    "-98529514":   ("RawImage",              "1344c3c82d62a2a41a3576d8abb8e3ea"),
    "-900027084":  ("Shadow",                "cfabb0440166ab443bba8876756fdfa9"),
    "-2095666955": ("GridLayoutGroup",       "8a8695521f0d02e499659fee002a26c2"),
    "-619905303":  ("Outline",               "e19747de3f5aca642ab2be37e372fb86"),
    "708705254":   ("Slider",                "67db9e8f0e2ae9c40bc1e2b64352a6b4"),
    "2109663825":  ("Toggle",                "9085046f02f69544eb97fd06b6048fe2"),
    "1077351063":  ("Scrollbar",             "2a4db7a114972834c8e4117be1d82ba3"),
    "-1690312454": ("InputField",            "d199490a83bb2b844b9695cbf13b01ef"),
    "-2061169968": ("Dropdown",              "0d0b652f32a2cc243917e4028fa0f046"),
    "1573420865":  ("Selectable",            "7a98125502f715b4b83cfb77b434e436"),
    "-1862395651": ("AspectRatioFitter",     "86710e43de46f6f4bac7c8e50813a599"),
    "1980459831":  ("CanvasScaler",          "0cd44c1031e13a943bb63640046fad76"),
    # TMP classes (currently using TMP_ASM_GUID)
    "1453722849":  ("TextMeshProUGUI",       "f4688fdb7df04437aeb418b961361dc5"),
    "-1620774994": ("TMP_SubMeshUI",         "058cba836c1846c3aa1c5fd2e28aea77"),
    "-1936749209": ("TMP_InputField",        "2da0c512f12947e489f739169773d7ca"),
    "2019389346":  ("TMP_Dropdown",          "7b743370ac3e4ec2a1668f5455a8ef8a"),
    "-667331979":  ("TMP_FontAsset",         "71c1514a6bd24e1e882cebbe1904ce04"),
    "-395462249":  ("TMP_Settings",          "2705215ac5b84b70bacc50632be6e391"),
    "2108210716":  ("TMP_SpriteAsset",       "84a92b25f83d49b9bc132d206b370281"),
}

# Also need to handle fileIDs we might have missed - scan all prefabs for any
# fileIDs used with these two assembly GUIDs
EXTENSIONS = ('.prefab', '.asset', '.unity', '.mat')


def build_regex_pattern():
    """Build a single regex that matches all old-style references."""
    patterns = []
    for fid, (cls, new_guid) in REMAP.items():
        # Match: {fileID: <fid>, guid: <asm_guid>, type: 3}
        # The assembly GUID could be either UI or TMP
        for asm_guid in [UI_ASM_GUID, TMP_ASM_GUID]:
            old = f"{{fileID: {fid}, guid: {asm_guid}, type: 3}}"
            new = f"{{fileID: 11500000, guid: {new_guid}, type: 3}}"
            patterns.append((old, new))
    return patterns


def process_file(filepath, replacements):
    with open(filepath, 'r', encoding='utf-8', errors='replace') as f:
        content = f.read()

    original = content
    for old, new in replacements:
        content = content.replace(old, new)

    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False


def scan_unknown_fileids(filepath):
    """Find any fileIDs still using the assembly GUIDs that we haven't mapped."""
    unknown = set()
    with open(filepath, 'r', encoding='utf-8', errors='replace') as f:
        for line in f:
            for asm_guid in [UI_ASM_GUID, TMP_ASM_GUID]:
                if asm_guid in line and 'm_Script:' in line:
                    m = re.search(r'fileID: (-?\d+)', line)
                    if m:
                        fid = m.group(1)
                        if fid not in REMAP:
                            unknown.add((fid, asm_guid))
    return unknown


def main():
    replacements = build_regex_pattern()
    print(f"Built {len(replacements)} replacement patterns for {len(REMAP)} classes")

    # First pass: scan for unmapped fileIDs
    all_unknown = set()
    for ext in EXTENSIONS:
        for filepath in glob.glob(os.path.join(ASSETS_DIR, '**', f'*{ext}'), recursive=True):
            unknown = scan_unknown_fileids(filepath)
            all_unknown.update(unknown)

    if all_unknown:
        print(f"\nWARNING: Found {len(all_unknown)} unmapped fileIDs:")
        for fid, guid in sorted(all_unknown):
            asm = "UI" if guid == UI_ASM_GUID else "TMP"
            print(f"  fileID={fid} [{asm}]")
        print()

    # Second pass: apply replacements
    fixed_count = 0
    total_files = 0
    for ext in EXTENSIONS:
        for filepath in glob.glob(os.path.join(ASSETS_DIR, '**', f'*{ext}'), recursive=True):
            total_files += 1
            if process_file(filepath, replacements):
                fixed_count += 1
                rel = os.path.relpath(filepath, ASSETS_DIR)
                print(f"  Fixed: {rel}")

    print(f"\nDone! Fixed {fixed_count} / {total_files} files.")


if __name__ == "__main__":
    main()
