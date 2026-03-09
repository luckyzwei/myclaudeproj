using System.Collections.Generic;
using UnityEngine;

public class GridState
{
	private const int MAX_LEVEL_SIZE = 20;

	private Vector2Int m_size;

	private int[][] m_colors;

	private int[][] m_queens;

	private int[][] m_grid;

	private int m_colorsCount;

	private int m_queensFound;

	private int m_totalQueens;

	private HashSet<int> m_usedColors;

	public Vector2Int Size => m_size;

	public int ColorsCount => m_colorsCount;

	public int GetColor(int x, int y)
	{
		if (m_colors == null || x < 0 || x >= m_size.x || y < 0 || y >= m_size.y) return 0;
		return m_colors[x][y];
	}

	public int GetSolution(int x, int y)
	{
		if (m_grid == null || x < 0 || x >= m_size.x || y < 0 || y >= m_size.y) return 0;
		return m_grid[x][y];
	}

	public bool IsQueen(int x, int y)
	{
		if (m_queens == null || x < 0 || x >= m_size.x || y < 0 || y >= m_size.y) return false;
		return m_queens[x][y] == 1;
	}

	public int Index(Vector2Int coords)
	{
		return Index(coords.x, coords.y);
	}

	public int Index(int x, int y)
	{
		if (x < 0 || x >= m_size.x || y < 0 || y >= m_size.y) return -1;
		return y * m_size.x + x;
	}

	public int GetX(int index)
	{
		return index % m_size.x;
	}

	public int GetY(int index)
	{
		return index / m_size.x;
	}

	public void LoadLevel(QueensGrid grid)
	{
		if (grid == null || grid.LevelData == null) return;
		LoadLevel(grid.LevelData);
		LoadFromGrid(grid);
	}

	public void LoadLevel(LevelData levelData)
	{
		if (levelData == null) return;
		m_size = new Vector2Int(levelData.sizeX, levelData.sizeY);
		m_colorsCount = levelData.usedColors != null ? levelData.usedColors.Length : 0;
		m_usedColors = new HashSet<int>();
		m_totalQueens = levelData.QueenCount();
		m_queensFound = 0;

		m_colors = new int[m_size.x][];
		m_queens = new int[m_size.x][];
		m_grid = new int[m_size.x][];

		for (int x = 0; x < m_size.x; x++)
		{
			m_colors[x] = new int[m_size.y];
			m_queens[x] = new int[m_size.y];
			m_grid[x] = new int[m_size.y];

			for (int y = 0; y < m_size.y; y++)
			{
				int idx = levelData.Index(x, y);
				m_colors[x][y] = levelData.GetColor(idx);
				m_queens[x][y] = levelData.GetQueen(idx) ? 1 : 0;
				m_grid[x][y] = QueensGrid.NONE;
				m_usedColors.Add(m_colors[x][y]);
			}
		}
	}

	private int CountColorsUsed(int[] colors)
	{
		if (colors == null) return 0;
		var set = new HashSet<int>();
		for (int i = 0; i < colors.Length; i++)
			set.Add(colors[i]);
		return set.Count;
	}

	public void LoadFromGrid(QueensGrid grid)
	{
		if (grid == null || grid.LevelData == null) return;
		m_queensFound = 0;
		for (int x = 0; x < m_size.x; x++)
		{
			for (int y = 0; y < m_size.y; y++)
			{
				int idx = grid.LevelData.Index(x, y);
				int val = grid.GetPlayerSolution(idx);
				m_grid[x][y] = val;
				if (val == QueensGrid.QUEEN)
					m_queensFound++;
			}
		}
	}

	public void ApplyChanges(HintsManager.HintResult hintResult)
	{
		if (hintResult == null || hintResult.interactibleCells == null) return;
		for (int i = 0; i < hintResult.interactibleCells.Count; i++)
		{
			int idx = hintResult.interactibleCells[i];
			int x = GetX(idx);
			int y = GetY(idx);
			if (x >= 0 && x < m_size.x && y >= 0 && y < m_size.y)
			{
				if (hintResult.isQueen)
					m_grid[x][y] = QueensGrid.QUEEN;
				else
					m_grid[x][y] = QueensGrid.X;
			}
		}
	}

	public bool IsSolved()
	{
		if (m_queens == null || m_grid == null) return false;
		for (int x = 0; x < m_size.x; x++)
		{
			for (int y = 0; y < m_size.y; y++)
			{
				if (m_queens[x][y] == 1 && m_grid[x][y] != QueensGrid.QUEEN)
					return false;
			}
		}
		return true;
	}
}
