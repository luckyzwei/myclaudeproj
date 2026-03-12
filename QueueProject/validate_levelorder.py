"""Validate levels in LevelOrder, mapping guids to asset files."""
import os
import re
import struct
import glob

BASE = os.path.dirname(__file__)
ASSET_DIR = os.path.join(BASE, "Assets", "MonoBehaviour")

def parse_hex_int_array(hex_str):
    values = []
    for i in range(0, len(hex_str), 8):
        chunk = hex_str[i:i+8]
        if len(chunk) < 8:
            break
        val = struct.unpack('<i', bytes.fromhex(chunk))[0]
        values.append(val)
    return values

def build_guid_to_file():
    """Build mapping from guid to .asset file path using .meta files."""
    mapping = {}
    for meta_path in glob.glob(os.path.join(ASSET_DIR, "*.asset.meta")):
        with open(meta_path, 'r', encoding='utf-8') as f:
            content = f.read()
        m = re.search(r'guid:\s*([a-f0-9]+)', content)
        if m:
            asset_path = meta_path[:-5]  # remove .meta
            mapping[m.group(1)] = asset_path
    return mapping

def get_levelorder_guids():
    """Read LevelOrder.asset and extract ordered list of guids."""
    lo_path = os.path.join(ASSET_DIR, "LevelOrder.asset")
    with open(lo_path, 'r', encoding='utf-8') as f:
        content = f.read()
    guids = re.findall(r'guid:\s*([a-f0-9]+),\s*type:\s*2', content)
    return guids

def parse_asset(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()
    name_m = re.search(r'm_Name:\s*(\S+)', content)
    sx_m = re.search(r'sizeX:\s*(\d+)', content)
    sy_m = re.search(r'sizeY:\s*(\d+)', content)
    qg_m = re.search(r'queensGrid:\s*([0-9a-fA-F]+)', content)
    gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)
    if not all([sx_m, sy_m, qg_m, gc_m]):
        return None
    sizeX = int(sx_m.group(1))
    sizeY = int(sy_m.group(1))
    return {
        'name': name_m.group(1) if name_m else os.path.basename(filepath),
        'sizeX': sizeX, 'sizeY': sizeY,
        'queensGrid': parse_hex_int_array(qg_m.group(1)),
        'gridColours': parse_hex_int_array(gc_m.group(1)),
        'filepath': filepath,
    }

def validate_level(data):
    errors = []
    sizeX, sizeY = data['sizeX'], data['sizeY']
    queens = data['queensGrid']
    colours = data['gridColours']
    expected = sizeX * sizeY
    if len(queens) != expected:
        return [f'queensGrid length {len(queens)} != {expected}']

    queen_positions = [(idx % sizeX, idx // sizeX) for idx, v in enumerate(queens) if v >= 1]
    unique_colors = set(colours)
    num_colors = len(unique_colors)

    if len(queen_positions) != num_colors:
        errors.append(f"Queen count ({len(queen_positions)}) != color count ({num_colors})")

    # Row check
    rows = {}
    for x, y in queen_positions:
        rows.setdefault(y, []).append((x, y))
    for row, qs in rows.items():
        if len(qs) > 1:
            errors.append(f"Row {row}: {len(qs)} queens {qs}")

    # Column check
    cols = {}
    for x, y in queen_positions:
        cols.setdefault(x, []).append((x, y))
    for col, qs in cols.items():
        if len(qs) > 1:
            errors.append(f"Col {col}: {len(qs)} queens {qs}")

    # Color region check
    color_qs = {}
    for x, y in queen_positions:
        c = colours[y * sizeX + x]
        color_qs.setdefault(c, []).append((x, y))
    for c, qs in color_qs.items():
        if len(qs) > 1:
            errors.append(f"Color {c}: {len(qs)} queens {qs}")
    for c in unique_colors:
        if c not in color_qs:
            errors.append(f"Color {c}: no queen")

    # Adjacency check
    for i in range(len(queen_positions)):
        for j in range(i+1, len(queen_positions)):
            x1, y1 = queen_positions[i]
            x2, y2 = queen_positions[j]
            if abs(x1-x2) <= 1 and abs(y1-y2) <= 1:
                errors.append(f"Adjacent: ({x1},{y1}) and ({x2},{y2})")

    return errors

def main():
    guid_to_file = build_guid_to_file()
    guids = get_levelorder_guids()
    print(f"LevelOrder has {len(guids)} levels")
    print(f"GUID-to-file mapping has {len(guid_to_file)} entries\n")

    invalid = []
    missing = []
    for idx, guid in enumerate(guids):
        filepath = guid_to_file.get(guid)
        if not filepath or not os.path.exists(filepath):
            missing.append((idx, guid))
            continue
        data = parse_asset(filepath)
        if data is None:
            missing.append((idx, guid))
            continue
        errors = validate_level(data)
        if errors:
            invalid.append((idx, data['name'], data['sizeX'], data['sizeY'], errors))

    if missing:
        print(f"=== Missing levels ({len(missing)}) ===")
        for idx, guid in missing[:10]:
            print(f"  Level {idx}: guid={guid}")
        if len(missing) > 10:
            print(f"  ... and {len(missing)-10} more")

    if invalid:
        print(f"\n=== Invalid levels in LevelOrder ({len(invalid)}) ===")
        for idx, name, sx, sy, errors in invalid:
            print(f"\nLevel {idx} — {name} [{sx}x{sy}]:")
            for err in errors:
                print(f"  - {err}")
    else:
        print("\nAll LevelOrder levels are valid!")

if __name__ == '__main__':
    main()
