"""Check connectivity with 8-adjacency (including diagonals)."""
import glob
import re
import struct
from collections import defaultdict, deque

ASSET_DIR = 'I:/client/myclaudeproj/QueueProject/Assets/MonoBehaviour'

def parse_hex_int_array(hex_str):
    data = bytes.fromhex(hex_str)
    count = len(data) // 4
    return list(struct.unpack(f'<{count}i', data))

def check_contiguity(grid, sizeX, sizeY, use_8conn=False):
    color_cells = defaultdict(set)
    for y in range(sizeY):
        for x in range(sizeX):
            c = grid[y * sizeX + x]
            if c >= 0:
                color_cells[c].add((x, y))

    dirs_4 = [(0,1),(0,-1),(1,0),(-1,0)]
    dirs_8 = [(0,1),(0,-1),(1,0),(-1,0),(1,1),(1,-1),(-1,1),(-1,-1)]
    dirs = dirs_8 if use_8conn else dirs_4

    issues = []
    for color, cells in sorted(color_cells.items()):
        if len(cells) <= 1:
            continue
        start = next(iter(cells))
        visited = {start}
        queue = deque([start])
        while queue:
            x, y = queue.popleft()
            for dx, dy in dirs:
                nx, ny = x+dx, y+dy
                if (nx, ny) in cells and (nx, ny) not in visited:
                    visited.add((nx, ny))
                    queue.append((nx, ny))
        if len(visited) < len(cells):
            disconnected = cells - visited
            issues.append((color, len(cells), len(visited), disconnected))
    return issues

def main():
    pattern = ASSET_DIR + '/*.asset'
    files = glob.glob(pattern)

    broken_4 = 0
    broken_8 = 0
    fixed_by_8 = 0

    for fpath in sorted(files):
        with open(fpath, 'r', encoding='utf-8') as f:
            content = f.read()

        sx_m = re.search(r'sizeX:\s*(\d+)', content)
        sy_m = re.search(r'sizeY:\s*(\d+)', content)
        gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)
        if not sx_m or not sy_m or not gc_m:
            continue

        sizeX = int(sx_m.group(1))
        sizeY = int(sy_m.group(1))
        grid = parse_hex_int_array(gc_m.group(1))
        if len(grid) != sizeX * sizeY:
            continue

        issues_4 = check_contiguity(grid, sizeX, sizeY, use_8conn=False)
        issues_8 = check_contiguity(grid, sizeX, sizeY, use_8conn=True)

        if issues_4:
            broken_4 += 1
        if issues_8:
            broken_8 += 1
            name = fpath.rsplit('\\', 1)[-1].rsplit('/', 1)[-1].replace('.asset', '')
            print(f'{name}: still broken with 8-conn')
        elif issues_4:
            fixed_by_8 += 1

    print(f'\n4-conn broken: {broken_4}')
    print(f'8-conn broken: {broken_8}')
    print(f'Fixed by 8-conn: {fixed_by_8}')

if __name__ == '__main__':
    main()
