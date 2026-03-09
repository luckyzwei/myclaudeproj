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

	public Vector2Int Size => default(Vector2Int);

	public int ColorsCount => 0;

	public int GetColor(int x, int y)
	{
		return 0;
	}

	public int GetSolution(int x, int y)
	{
		return 0;
	}

	public bool IsQueen(int x, int y)
	{
		return false;
	}

	public int Index(Vector2Int coords)
	{
		return 0;
	}

	public int Index(int x, int y)
	{
		return 0;
	}

	public int GetX(int index)
	{
		return 0;
	}

	public int GetY(int index)
	{
		return 0;
	}

	public void LoadLevel(QueensGrid grid)
	{
	}

	public void LoadLevel(LevelData levelData)
	{
	}

	private int CountColorsUsed(int[] colors)
	{
		return 0;
	}

	public void LoadFromGrid(QueensGrid grid)
	{
	}

	public void ApplyChanges(HintsManager.HintResult hintResult)
	{
	}

	public bool IsSolved()
	{
		return false;
	}
}
