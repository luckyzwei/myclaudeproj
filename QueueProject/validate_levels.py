"""Batch validate all Queens puzzle level data for solution correctness."""
import os
import re
import struct
import sys

ASSET_DIR = os.path.join(os.path.dirname(__file__), "Assets", "MonoBehaviour")

def parse_hex_int_array(hex_str):
    """Parse a hex string of little-endian int32 values."""
    values = []
    for i in range(0, len(hex_str), 8):
        chunk = hex_str[i:i+8]
        if len(chunk) < 8:
            break
        # Little-endian int32 from hex
        b = bytes.fromhex(chunk)
        val = struct.unpack('<i', b)[0]
        values.append(val)
    return values

def parse_asset(filepath):
    """Parse a level .asset file and return level data dict or None."""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    # Extract fields
    name_m = re.search(r'm_Name:\s*(\S+)', content)
    sx_m = re.search(r'sizeX:\s*(\d+)', content)
    sy_m = re.search(r'sizeY:\s*(\d+)', content)
    qg_m = re.search(r'queensGrid:\s*([0-9a-fA-F]+)', content)
    gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)

    if not all([sx_m, sy_m, qg_m, gc_m]):
        return None

    sizeX = int(sx_m.group(1))
    sizeY = int(sy_m.group(1))
    queensGrid = parse_hex_int_array(qg_m.group(1))
    gridColours = parse_hex_int_array(gc_m.group(1))
    name = name_m.group(1) if name_m else os.path.basename(filepath)

    expected = sizeX * sizeY
    if len(queensGrid) != expected or len(gridColours) != expected:
        return {'name': name, 'error': f'Array length mismatch: expected {expected}, got queens={len(queensGrid)} colours={len(gridColours)}',
                'sizeX': sizeX, 'sizeY': sizeY}

    return {
        'name': name,
        'sizeX': sizeX,
        'sizeY': sizeY,
        'queensGrid': queensGrid,
        'gridColours': gridColours,
        'filepath': filepath,
    }

def validate_level(data):
    """Validate a level's queen placement. Returns list of error strings."""
    if 'error' in data:
        return [data['error']]

    errors = []
    sizeX = data['sizeX']
    sizeY = data['sizeY']
    queens = data['queensGrid']
    colours = data['gridColours']

    # Find queen positions
    queen_positions = []  # list of (x, y)
    for idx, val in enumerate(queens):
        if val >= 1:  # 1=queen, 2=pre-placed queen
            x = idx % sizeX
            y = idx // sizeX
            queen_positions.append((x, y))

    # Get unique colors
    unique_colors = set(colours)
    num_colors = len(unique_colors)

    # Check: number of queens should equal number of colors
    if len(queen_positions) != num_colors:
        errors.append(f"Queen count ({len(queen_positions)}) != color count ({num_colors})")

    # Check: one queen per row
    row_counts = {}
    for x, y in queen_positions:
        row_counts[y] = row_counts.get(y, 0) + 1
    for row, count in row_counts.items():
        if count > 1:
            queens_in_row = [(x, y) for x, y in queen_positions if y == row]
            errors.append(f"Row {row} has {count} queens: {queens_in_row}")

    # Check: one queen per column
    col_counts = {}
    for x, y in queen_positions:
        col_counts[x] = col_counts.get(x, 0) + 1
    for col, count in col_counts.items():
        if count > 1:
            queens_in_col = [(x, y) for x, y in queen_positions if x == col]
            errors.append(f"Column {col} has {count} queens: {queens_in_col}")

    # Check: one queen per color region
    color_queens = {}
    for x, y in queen_positions:
        idx = y * sizeX + x
        color = colours[idx]
        if color not in color_queens:
            color_queens[color] = []
        color_queens[color].append((x, y))
    for color, qlist in color_queens.items():
        if len(qlist) > 1:
            errors.append(f"Color {color} has {len(qlist)} queens: {qlist}")

    # Check: colors without queens
    for color in unique_colors:
        if color not in color_queens:
            errors.append(f"Color {color} has no queen")

    # Check: no adjacent queens (including diagonal)
    for i in range(len(queen_positions)):
        for j in range(i + 1, len(queen_positions)):
            x1, y1 = queen_positions[i]
            x2, y2 = queen_positions[j]
            if abs(x1 - x2) <= 1 and abs(y1 - y2) <= 1:
                errors.append(f"Queens at ({x1},{y1}) and ({x2},{y2}) are adjacent")

    return errors

def main():
    # Find all .asset files with queensGrid
    results = {'valid': 0, 'invalid': 0, 'skipped': 0, 'errors': []}

    for filename in sorted(os.listdir(ASSET_DIR)):
        if not filename.endswith('.asset'):
            continue

        filepath = os.path.join(ASSET_DIR, filename)
        data = parse_asset(filepath)

        if data is None:
            results['skipped'] += 1
            continue

        errors = validate_level(data)

        if errors:
            results['invalid'] += 1
            results['errors'].append((data['name'], filename, errors, data.get('sizeX'), data.get('sizeY')))
        else:
            results['valid'] += 1

    # Print results
    print(f"\n=== Level Validation Results ===")
    print(f"Valid:   {results['valid']}")
    print(f"Invalid: {results['invalid']}")
    print(f"Skipped: {results['skipped']} (no queensGrid)")

    if results['errors']:
        print(f"\n=== Invalid Levels ({results['invalid']}) ===")
        for name, filename, errors, sx, sy in results['errors']:
            print(f"\n{filename} ({name}) [{sx}x{sy}]:")
            for err in errors:
                print(f"  - {err}")
    else:
        print("\nAll levels are valid!")

if __name__ == '__main__':
    main()
