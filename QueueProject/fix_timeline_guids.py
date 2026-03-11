"""
Fix Timeline asset GUID references in .playable files for Unity 6.
Unity 6 changed Timeline from a DLL to a source-code package,
so script references need remapping from DLL class hashes to source file GUIDs.

Old format:  m_Script: {fileID: <class_hash>, guid: 1f79187d04fa6fdd168e19d4bafe7dfa, type: 3}
New format:  m_Script: {fileID: 11500000, guid: <source_file_guid>, type: 3}
"""
import os
import re
import glob

OLD_DLL_GUID = "1f79187d04fa6fdd168e19d4bafe7dfa"

# Mapping: old fileID (class hash) -> new source file GUID
FILEID_TO_GUID = {
    "337831424":    "bfda56da833e2384a9677cd3c976a436",  # TimelineAsset
    "-1095772578":  "15e0374501f39d54eb30235764636e0e",  # ControlTrack
    "46519060":     "21bf7f712d84d26478ebe6a299f21738",  # ActivationTrack
    "442072544":    "fde0d25a170598d46a0b9dc16b4527a5",  # ActivationPlayableAsset
    "1467732076":   "d21dcc2386d650c4597f3633c75a1f98",  # AnimationTrack
    "-1670381969":  "48853ae485fa386428341ac1ea122570",  # ControlPlayableAsset
    "2024714994":   "030f85c3f73729f4f976f66ffb23b875",  # AnimationPlayableAsset
    "-2113462093":  "8b22792c3b570444eb18cb78c2af3a74",  # AudioTrack
    "-1977359656":  "4f10dd60657c6004587f237a7e90f8e4",  # AudioPlayableAsset
    "-1544527758":  "d0fc6f5187a81dc47999eefade6f0935",  # GroupTrack
}

# Regex: match m_Script lines with the old DLL GUID
PATTERN = re.compile(
    r'(m_Script:\s*\{fileID:\s*)(-?\d+)(,\s*guid:\s*)' + OLD_DLL_GUID + r'(,\s*type:\s*3\s*\})'
)

def fix_file(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    if OLD_DLL_GUID not in content:
        return 0

    count = 0
    def replacer(m):
        nonlocal count
        old_fileid = m.group(2)
        if old_fileid in FILEID_TO_GUID:
            new_guid = FILEID_TO_GUID[old_fileid]
            count += 1
            return f"{m.group(1)}11500000{m.group(3)}{new_guid}{m.group(4)}"
        else:
            print(f"  WARNING: Unknown fileID {old_fileid} in {filepath}")
            return m.group(0)

    new_content = PATTERN.sub(replacer, content)

    if count > 0:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(new_content)

    return count

def main():
    base = os.path.dirname(os.path.abspath(__file__))
    playable_dir = os.path.join(base, "Assets", "MonoBehaviour")

    files = glob.glob(os.path.join(playable_dir, "*.playable"))

    total_files = 0
    total_replacements = 0

    for f in sorted(files):
        n = fix_file(f)
        if n > 0:
            total_files += 1
            total_replacements += n
            print(f"  Fixed {n} references in {os.path.basename(f)}")

    print(f"\nDone: {total_replacements} references fixed in {total_files} files (out of {len(files)} .playable files)")

if __name__ == "__main__":
    main()
