"""Fix invalid queensGrid solutions by solving the puzzle from color regions."""
import os
import re
import struct

BASE = os.path.dirname(__file__)
ASSET_DIR = os.path.join(BASE, "Assets", "MonoBehaviour")

def parse_hex_int_array(hex_str):
    values = []
    for i in range(0, len(hex_str), 8):
        chunk = hex_str[i:i+8]
        if len(chunk) < 8: break
        val = struct.unpack('<i', bytes.fromhex(chunk))[0]
        values.append(val)
    return values

def int_array_to_hex(arr):
    return ''.join(struct.pack('<i', v).hex() for v in arr)

def solve_queens(sizeX, sizeY, colours, pre_placed=None):
    """
    Solve the Queens puzzle: place one queen per color region,
    one per row, one per column, no adjacency.
    """
    unique_colors = sorted(set(colours))

    # Map color -> list of (x,y) cells
    color_cells = {}
    for idx, c in enumerate(colours):
        x, y = idx % sizeX, idx // sizeX
        color_cells.setdefault(c, []).append((x, y))

    pre = pre_placed or {}
    colors_to_place = []
    fixed = {}
    for c in unique_colors:
        if c in pre:
            fixed[c] = pre[c]
        else:
            colors_to_place.append(c)

    colors_to_place.sort(key=lambda c: len(color_cells[c]))

    used_rows = set()
    used_cols = set()
    placed = []

    for c, (x, y) in fixed.items():
        used_rows.add(y)
        used_cols.add(x)
        placed.append((x, y))

    def adjacency_ok(x, y):
        for px, py in placed:
            if abs(x-px) <= 1 and abs(y-py) <= 1:
                return False
        return True

    def backtrack(ci):
        if ci == len(colors_to_place):
            return True
        c = colors_to_place[ci]
        for x, y in color_cells[c]:
            if y in used_rows or x in used_cols:
                continue
            if not adjacency_ok(x, y):
                continue
            used_rows.add(y)
            used_cols.add(x)
            placed.append((x, y))
            if backtrack(ci + 1):
                return True
            placed.pop()
            used_rows.discard(y)
            used_cols.discard(x)
        return False

    if backtrack(0):
        return list(placed), fixed
    return None, None

def fix_level(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    name_m = re.search(r'm_Name:\s*(\S+)', content)
    sx_m = re.search(r'sizeX:\s*(\d+)', content)
    sy_m = re.search(r'sizeY:\s*(\d+)', content)
    qg_m = re.search(r'queensGrid:\s*([0-9a-fA-F]+)', content)
    gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)

    if not all([sx_m, sy_m, qg_m, gc_m]):
        return None, False, ["Can't parse"]

    name = name_m.group(1) if name_m else os.path.basename(filepath)
    sizeX = int(sx_m.group(1))
    sizeY = int(sy_m.group(1))
    old_queens = parse_hex_int_array(qg_m.group(1))
    colours = parse_hex_int_array(gc_m.group(1))
    old_hex = qg_m.group(1)

    # Find pre-placed queens (value 2)
    pre_placed = {}
    for idx, v in enumerate(old_queens):
        if v == 2:
            x, y = idx % sizeX, idx // sizeX
            c = colours[idx]
            pre_placed[c] = (x, y)

    # Try with pre-placed first
    solution, fixed_pre = solve_queens(sizeX, sizeY, colours, pre_placed)
    dropped_pre = False

    # If no solution with pre-placed, try without
    if solution is None and pre_placed:
        solution, fixed_pre = solve_queens(sizeX, sizeY, colours, {})
        if solution is not None:
            dropped_pre = True
            fixed_pre = {}

    if solution is None:
        return name, False, ["No solution found even without pre-placed!"]

    # Build new queensGrid - all queens as value 1 (no pre-placed since we can't trust them)
    new_queens = [0] * (sizeX * sizeY)
    for x, y in solution:
        idx = y * sizeX + x
        if not dropped_pre:
            is_pre = any(px == x and py == y for px, py in fixed_pre.values()) if fixed_pre else False
            new_queens[idx] = 2 if is_pre else 1
        else:
            new_queens[idx] = 1

    new_hex = int_array_to_hex(new_queens)

    if new_hex == old_hex:
        return name, False, ["Already correct"]

    new_content = content.replace(old_hex, new_hex)
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(new_content)

    old_positions = [(idx % sizeX, idx // sizeX, old_queens[idx]) for idx in range(len(old_queens)) if old_queens[idx] >= 1]
    new_positions = [(x, y, new_queens[y*sizeX+x]) for x, y in solution]
    info = [f"Old: {old_positions}", f"New: {new_positions}"]
    if dropped_pre:
        info.append("NOTE: Dropped pre-placed queen constraints (corrupted)")

    return name, True, info

INVALID_FILES = [
    "VE_4x5_3.asset",
    "lvl_04_AB.asset",
    "VE_4x5_8.asset",
    "VE_5x6_10.asset",
    "E_6x7_12.asset",
    "E_7x8_14.asset",
    "lvl_82_AB.asset",
    "H_8x9_16.asset",
    "VE_4x5_19.asset",
    "lvl_81_AB.asset",
    "lvl_61_AB.asset",
    "VE_6x7_23.asset",
    "E_7x8_25.asset",
    "H_8x9_27.asset",
    "lvl_62_AB.asset",
    "M_8x9_30.asset",
    "E_7x8_32.asset",
    "lvl_28_AB.asset",
    "lvl_68_AB.asset",
    "lvl_71_AB.asset",
    "lvl_74_AB.asset",
    "lvl_46_AB.asset",
    "lvl_88_AB.asset",
]

def main():
    fixed_count = 0
    failed_count = 0

    for filename in INVALID_FILES:
        filepath = os.path.join(ASSET_DIR, filename)
        if not os.path.exists(filepath):
            print(f"MISSING: {filename}")
            continue

        name, was_fixed, info = fix_level(filepath)
        if was_fixed:
            fixed_count += 1
            print(f"FIXED: {filename} ({name})")
            for line in info:
                print(f"  {line}")
        else:
            failed_count += 1
            print(f"FAILED: {filename} ({name})")
            for line in info:
                print(f"  {line}")

    print(f"\n=== Summary ===")
    print(f"Fixed: {fixed_count}")
    print(f"Failed: {failed_count}")

if __name__ == '__main__':
    main()
