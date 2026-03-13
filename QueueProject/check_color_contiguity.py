"""Check all level assets for disconnected color regions."""
import glob
import re
import struct
from collections import defaultdict, deque

ASSET_DIR = 'I:/client/myclaudeproj/QueueProject/Assets/MonoBehaviour'

def parse_hex_int_array(hex_str):
    """Parse Unity serialized int[] hex string (little-endian int32)."""
    data = bytes.fromhex(hex_str)
    count = len(data) // 4
    return list(struct.unpack(f'<{count}i', data))

def check_contiguity(grid, sizeX, sizeY):
    """Check if each color forms a contiguous region. Returns list of issues."""
    # Group cells by color
    color_cells = defaultdict(set)
    for y in range(sizeY):
        for x in range(sizeX):
            c = grid[y * sizeX + x]
            if c >= 0:
                color_cells[c].add((x, y))

    issues = []
    for color, cells in sorted(color_cells.items()):
        if len(cells) <= 1:
            continue
        # BFS from first cell
        start = next(iter(cells))
        visited = {start}
        queue = deque([start])
        while queue:
            x, y = queue.popleft()
            for dx, dy in [(0,1),(0,-1),(1,0),(-1,0)]:
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

    total = 0
    broken = 0

    for fpath in sorted(files):
        with open(fpath, 'r', encoding='utf-8') as f:
            content = f.read()

        # Extract sizeX, sizeY, gridColours
        sx_m = re.search(r'sizeX:\s*(\d+)', content)
        sy_m = re.search(r'sizeY:\s*(\d+)', content)
        gc_m = re.search(r'gridColours:\s*([0-9a-fA-F]+)', content)

        if not sx_m or not sy_m or not gc_m:
            continue

        sizeX = int(sx_m.group(1))
        sizeY = int(sy_m.group(1))
        hex_str = gc_m.group(1)

        grid = parse_hex_int_array(hex_str)
        expected = sizeX * sizeY
        if len(grid) != expected:
            continue

        total += 1
        issues = check_contiguity(grid, sizeX, sizeY)

        if issues:
            broken += 1
            name = fpath.rsplit('\\', 1)[-1].rsplit('/', 1)[-1].replace('.asset', '')
            print(f'\n=== {name} ({sizeX}x{sizeY}) ===')
            # Print grid
            for y in range(sizeY):
                row = ''
                for x in range(sizeX):
                    row += str(grid[y * sizeX + x]) + ' '
                print(f'  {row}')
            for color, total_cells, connected, disconnected in issues:
                print(f'  颜色{color}: {total_cells}格, 连通{connected}格, 断开{len(disconnected)}格 {disconnected}')

    print(f'\n=== 共检查 {total} 个关卡, {broken} 个有颜色不连通问题 ===')

if __name__ == '__main__':
    main()
