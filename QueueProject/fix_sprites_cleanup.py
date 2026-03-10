"""
Cleanup: Remove spriteSheet entries from spriteMode:1 textures.
Only spriteMode:2 (multi-sprite) textures should have spriteSheet data.
For spriteMode:1, Unity auto-creates one sprite at fileID 21300000.
"""

import os
import re

TEXTURE_DIR = 'I:/client/myclaudeproj/QueueProject/Assets/Texture2D'

cleaned = 0
kept = 0

for f in os.listdir(TEXTURE_DIR):
    if not f.endswith('.png.meta'):
        continue
    path = os.path.join(TEXTURE_DIR, f)
    with open(path, 'r', encoding='utf-8') as fh:
        content = fh.read()

    m = re.search(r'spriteMode:\s*(\d+)', content)
    if not m:
        continue
    mode = int(m.group(1))

    if mode == 2:
        kept += 1
        continue  # Keep spriteSheet for multi-sprite textures

    # For spriteMode 1 (or 0), remove the added spriteSheet data
    if 'internalIDToNameTable:\n' not in content:
        continue  # Nothing to clean

    # Restore internalIDToNameTable to empty
    content = re.sub(
        r'  internalIDToNameTable:\n(?:  - first:\n      213: \d+\n    second: .+\n)+',
        '  internalIDToNameTable: []\n',
        content
    )

    # Restore sprites to empty
    content = re.sub(
        r'    sprites:\n(?:    - serializedVersion: 2\n(?:      .+\n)*)+',
        '    sprites: []\n',
        content
    )

    # Restore nameFileIdTable to empty
    content = re.sub(
        r'    nameFileIdTable:\n(?:      .+\n)+',
        '    nameFileIdTable: {}\n',
        content
    )

    with open(path, 'w', encoding='utf-8') as fh:
        fh.write(content)
    cleaned += 1

print(f"Cleaned {cleaned} spriteMode:1 textures, kept {kept} spriteMode:2 textures")
