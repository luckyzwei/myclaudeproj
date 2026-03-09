"""
Remap old DLL GUIDs to new Unity 6 package GUIDs.
AssetRipper exported prefabs reference old DLL GUIDs for TMP and UI components.
In Unity 6, these have moved from standalone DLLs to com.unity.ugui package.
"""
import os
import glob

ASSETS_DIR = os.path.join(os.path.dirname(os.path.abspath(__file__)), "Assets")

# Old GUID -> New GUID mapping
GUID_REMAP = {
    # TextMeshPro: old standalone package -> ugui/TMP
    "67dfb1fdfb2b407222eda8e23ac8b724": "6055be8ebefd69e48b49212b09b47b2f",
    # UnityEngine.UI: old DLL -> ugui/UGUI
    "d3e719b59ab71ba3f6b398058c866280": "2bafac87e7f4b9b418d9448d219b01ab",
}

EXTENSIONS = ('.prefab', '.asset', '.unity', '.mat')

def process_file(filepath):
    with open(filepath, 'r', encoding='utf-8', errors='replace') as f:
        content = f.read()

    original = content
    for old_guid, new_guid in GUID_REMAP.items():
        content = content.replace(old_guid, new_guid)

    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def main():
    fixed_count = 0
    total_files = 0

    for ext in EXTENSIONS:
        pattern = os.path.join(ASSETS_DIR, '**', f'*{ext}')
        for filepath in glob.glob(pattern, recursive=True):
            total_files += 1
            if process_file(filepath):
                fixed_count += 1
                rel = os.path.relpath(filepath, ASSETS_DIR)
                print(f"  Fixed: {rel}")

    print(f"\nDone! Fixed {fixed_count} / {total_files} files.")

if __name__ == "__main__":
    main()
