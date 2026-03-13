"""Fix disconnected color regions in level assets.

Strategy: For each color, keep the component containing the queen.
Disconnected cells get reassigned to an adjacent cell's color,
then repeat until all colors are contiguous.
"""
import glob
import re
import struct
from collections import defaultdict, deque
from copy import deepcopy

ASSET_DIR = 'I:/client/myclaudeproj/QueueProject/Assets/MonoBehaviour'

def parse_hex_int_array(hex_str):
    data = bytes.fromhex(hex_str)
    count = len(data) // 4
    return list(struct.unpack(f'<{count}i', data))

def to_hex(int_array):
    return struct.pack(f'<{len(int_array)}i', *int_array).hex()

def get_components(grid, sizeX, sizeY, color):
    """Get all connected components for a color (4-connected)."""
    cells = set()
    for y in range(sizeY):
        for x in range(sizeX):
            if grid[y * sizeX + x] == color:
                cells.add((x, y))
    if not cells:
        return []

    components = []
    remaining = set(cells)
    while remaining:
        start = next(iter(remaining))
        comp = set()
        queue = deque([start])
        comp.add(start)
        while queue:
            x, y = queue.popleft()
            for dx, dy in [(0,1),(0,-1),(1,0),(-1,0)]:
                nx, ny = x+dx, y+dy
                if (nx, ny) in remaining and (nx, ny) not in comp:
                    comp.add((nx, ny))
                    queue.append((nx, ny))
        components.append(comp)
        remaining -= comp
    return components

def find_queen_component(components, queens, sizeX):
    """Find which component contains a queen."""
    queen_set = set()
    for i, q in enumerate(queens):
        if q >= 1:
            x = i % sizeX
            y = i // sizeX
            queen_set.add((x, y))

    for i, comp in enumerate(components):
        if comp & queen_set:
            return i
    return 0  # default to largest if no queen found

def get_adjacent_colors(x, y, grid, sizeX, sizeY, exclude_color):
    """Get colors of 4-connected neighbors, excluding a specific color."""
    colors = []
    for dx, dy in [(0,1),(0,-1),(1,0),(-1,0)]:
        nx, ny = x+dx, y+dy
        if 0 <= nx < sizeX and 0 <= ny < sizeY:
            c = grid[ny * sizeX + nx]
            if c != exclude_color and c >= 0:
                colors.append(c)
    return colors

def check_all_contiguous(grid, sizeX, sizeY):
    """Check if all colors are contiguous."""
    color_set = set(c for c in grid if c >= 0)
    for color in color_set:
        comps = get_components(grid, sizeX, sizeY, color)
        if len(comps) > 1:
            return False
    return True

def fix_level(grid, queens, sizeX, sizeY):
    """Fix disconnected color regions. Returns (fixed_grid, changes_made)."""
    grid = list(grid)
    changes = []
    max_iterations = 100

    for iteration in range(max_iterations):
        color_set = set(c for c in grid if c >= 0)
        any_fixed = False

        for color in sorted(color_set):
            comps = get_components(grid, sizeX, sizeY, color)
            if len(comps) <= 1:
                continue

            # Find the component with the queen
            queen_idx = find_queen_component(comps, queens, sizeX)

            # Process disconnected components
            for i, comp in enumerate(comps):
                if i == queen_idx:
                    continue

                # Try to reassign each cell in this component to an adjacent color
                for (x, y) in sorted(comp):
                    adj_colors = get_adjacent_colors(x, y, grid, sizeX, sizeY, color)
                    if adj_colors:
                        # Pick the most common adjacent color
                        best_color = max(set(adj_colors), key=adj_colors.count)
                        old = grid[y * sizeX + x]
                        grid[y * sizeX + x] = best_color
                        changes.append((x, y, old, best_color))
                        any_fixed = True

        if not any_fixed:
            break

    return grid, changes

def print_grid(grid, sizeX, sizeY, queens=None):
    for y in range(sizeY):
        row = ''
        for x in range(sizeX):
            idx = y * sizeX + x
            c = grid[idx]
            q = queens[idx] if queens else 0
            if q >= 1:
                row += f'Q{c} '
            else:
                row += f'{c}  '
        print(f'  {row}')

def main():
    pattern = ASSET_DIR + '/*.asset'
    files = glob.glob(pattern)

    fixed_count = 0
    failed_count = 0

    for fpath in sorted(files):
        with open(fpath, 'r', encoding='utf-8') as f:
            content = f.read()

        sx_m = re.search(r'sizeX:\s*(\d+)', content)
        sy_m = re.search(r'sizeY:\s*(\d+)', content)
        gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)
        qg_m = re.search(r'queensGrid:\s*([0-9a-fA-F]+)', content)
        if not sx_m or not sy_m or not gc_m or not qg_m:
            continue

        sizeX = int(sx_m.group(1))
        sizeY = int(sy_m.group(1))
        grid = parse_hex_int_array(gc_m.group(1))
        queens = parse_hex_int_array(qg_m.group(1))
        expected = sizeX * sizeY
        if len(grid) != expected or len(queens) != expected:
            continue

        # Check if needs fixing
        color_set = set(c for c in grid if c >= 0)
        needs_fix = False
        for color in color_set:
            comps = get_components(grid, sizeX, sizeY, color)
            if len(comps) > 1:
                needs_fix = True
                break

        if not needs_fix:
            continue

        name = fpath.rsplit('\\', 1)[-1].rsplit('/', 1)[-1].replace('.asset', '')
        print(f'\n=== {name} ({sizeX}x{sizeY}) ===')
        print('Before:')
        print_grid(grid, sizeX, sizeY, queens)

        fixed_grid, changes = fix_level(grid, queens, sizeX, sizeY)

        # Verify fix
        if check_all_contiguous(fixed_grid, sizeX, sizeY):
            # Verify each color still has exactly one queen
            color_queens = defaultdict(int)
            for i, q in enumerate(queens):
                if q >= 1:
                    color_queens[fixed_grid[i]] += 1

            queen_ok = all(v == 1 for v in color_queens.values())
            if not queen_ok:
                print(f'  WARNING: Queen constraint broken! {dict(color_queens)}')
                failed_count += 1
                continue

            print(f'After ({len(changes)} cells changed):')
            print_grid(fixed_grid, sizeX, sizeY, queens)

            # Write back to file
            new_hex = to_hex(fixed_grid)
            old_hex = gc_m.group(1)
            content = content.replace(
                f'gridColours: {old_hex}',
                f'gridColours: {new_hex}'
            )

            # Also update usedColors
            new_colors = sorted(set(c for c in fixed_grid if c >= 0))
            new_used_hex = to_hex(new_colors)
            uc_m = re.search(r'usedColors:\s*([0-9a-fA-F]+)', content)
            if uc_m:
                content = content.replace(
                    f'usedColors: {uc_m.group(1)}',
                    f'usedColors: {new_used_hex}'
                )

            with open(fpath, 'w', encoding='utf-8') as f:
                f.write(content)

            fixed_count += 1
            print(f'  SAVED')
        else:
            print('  FAILED to fix completely')
            print_grid(fixed_grid, sizeX, sizeY, queens)
            failed_count += 1

    print(f'\n=== Fixed: {fixed_count}, Failed: {failed_count} ===')

if __name__ == '__main__':
    main()
