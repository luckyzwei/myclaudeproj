"""
Swap HorizontalLayoutGroup and VerticalLayoutGroup GUIDs in all prefab files.
The original fix_guid_remap_v2.py had the mapping backwards:
  -405508275 was mapped to VerticalLayoutGroup but is actually HorizontalLayoutGroup
  1297475563 was mapped to HorizontalLayoutGroup but is actually VerticalLayoutGroup
"""
import os
import glob

# Current (wrong) GUIDs in the prefabs
VLG_GUID = "59f8146938fff824cb5fd77236b75775"  # Currently VerticalLayoutGroup (should be HorizontalLayoutGroup)
HLG_GUID = "30649d3a9faa99c48a7b1166b86bf2a0"  # Currently HorizontalLayoutGroup (should be VerticalLayoutGroup)

# Temporary placeholder to avoid collision during swap
TEMP_GUID = "TEMP_SWAP_PLACEHOLDER_GUID_12345"

assets_dir = os.path.join(os.path.dirname(__file__), "Assets")

prefab_files = glob.glob(os.path.join(assets_dir, "**", "*.prefab"), recursive=True)

changed_count = 0
for fpath in prefab_files:
    with open(fpath, "r", encoding="utf-8") as f:
        content = f.read()

    if VLG_GUID not in content and HLG_GUID not in content:
        continue

    original = content
    # Step 1: VLG -> TEMP
    content = content.replace(VLG_GUID, TEMP_GUID)
    # Step 2: HLG -> VLG (now correct: was HLG, becomes VLG)
    content = content.replace(HLG_GUID, VLG_GUID)
    # Step 3: TEMP -> HLG (now correct: was VLG, becomes HLG)
    content = content.replace(TEMP_GUID, HLG_GUID)

    if content != original:
        with open(fpath, "w", encoding="utf-8", newline="\n") as f:
            f.write(content)
        changed_count += 1
        rel = os.path.relpath(fpath, assets_dir)
        print(f"  Swapped: {rel}")

print(f"\nDone. {changed_count} files updated.")
