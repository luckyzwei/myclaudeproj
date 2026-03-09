using System;
using System.Collections.Generic;
using Balancy.Models;
using UnityEngine.Serialization;

[Serializable]
public class LevelData
{
	public string name;

	public LevelDifficulty levelDifficulty;

	public int levelDifficultyValue;

	public int sizeX;

	public int sizeY;

	[FormerlySerializedAs("queens")]
	public int[] queensGrid;

	public int[] gridColours;

	public int[] usedColors;

	private const int BRUTE_FORCE_ITERATION_COUNT_100K = 100000;

	private const int BRUTE_FORCE_ITERATION_COUNT_10K = 10000;

	private const int BRUTE_FORCE_ITERATION_COUNT_1K = 1000;

	private const int BRUTE_FORCE_ITERATION_COUNT_500 = 500;

	private int[] m_rowCount;

	private int[] m_columnCount;

	private List<List<int>> m_coloursACellCannotBe;

	public List<List<int>> DebugCannot => m_coloursACellCannotBe;

	public LevelData()
	{
	}

	public LevelData(LevelData other)
	{
		name = other.name;
		levelDifficulty = other.levelDifficulty;
		levelDifficultyValue = other.levelDifficultyValue;
		sizeX = other.sizeX;
		sizeY = other.sizeY;
		if (other.queensGrid != null)
		{
			queensGrid = new int[other.queensGrid.Length];
			Array.Copy(other.queensGrid, queensGrid, other.queensGrid.Length);
		}
		if (other.gridColours != null)
		{
			gridColours = new int[other.gridColours.Length];
			Array.Copy(other.gridColours, gridColours, other.gridColours.Length);
		}
		if (other.usedColors != null)
		{
			usedColors = new int[other.usedColors.Length];
			Array.Copy(other.usedColors, usedColors, other.usedColors.Length);
		}
	}

	public void GenerateUsedColours()
	{
		if (gridColours == null) return;
		var colorSet = new HashSet<int>();
		for (int i = 0; i < gridColours.Length; i++)
		{
			if (gridColours[i] >= 0)
				colorSet.Add(gridColours[i]);
		}
		usedColors = new int[colorSet.Count];
		int idx = 0;
		foreach (int c in colorSet)
			usedColors[idx++] = c;
		Array.Sort(usedColors);
	}

	public bool FixColours()
	{
		if (gridColours == null || queensGrid == null) return false;
		GenerateUsedColours();
		return true;
	}

	public void RandomQueenGeneration(int _sizeX, int _sizeY)
	{
		sizeX = _sizeX;
		sizeY = _sizeY;
		queensGrid = new int[sizeX * sizeY];
		GenerateQueenSolution();
	}

	public void RandomColourGeneration(bool useSwapConstraint)
	{
		gridColours = new int[sizeX * sizeY];
		for (int i = 0; i < gridColours.Length; i++)
			gridColours[i] = -1;
		RandomColourGenerationInternal(useSwapConstraint);
		GenerateUsedColours();
	}

	public void RandomColourGenerationInternal(bool useSwapConstraint)
	{
		if (queensGrid == null) return;
		m_coloursACellCannotBe = new List<List<int>>();
		for (int i = 0; i < sizeX * sizeY; i++)
			m_coloursACellCannotBe.Add(new List<int>());

		// Assign each queen a unique color
		int colorIdx = 0;
		for (int i = 0; i < queensGrid.Length; i++)
		{
			if (queensGrid[i] >= 1)
			{
				gridColours[i] = colorIdx++;
			}
		}

		// Fill remaining cells by expanding queen colors to adjacent cells
		bool changed = true;
		var rng = new System.Random(sizeX * 37 + sizeY);
		while (changed)
		{
			changed = false;
			for (int i = 0; i < gridColours.Length; i++)
			{
				if (gridColours[i] >= 0) continue;
				int col = TryGetRandomAdjacentColour(i, m_coloursACellCannotBe);
				if (col >= 0)
				{
					gridColours[i] = col;
					changed = true;
				}
			}
		}

		// Fill any remaining uncolored cells
		for (int i = 0; i < gridColours.Length; i++)
		{
			if (gridColours[i] < 0)
				gridColours[i] = rng.Next(0, colorIdx);
		}
	}

	public int GetX(int index)
	{
		return index % sizeX;
	}

	public int GetY(int index)
	{
		return index / sizeX;
	}

	public int Index(int x, int y)
	{
		if (x < 0 || x >= sizeX || y < 0 || y >= sizeY) return -1;
		return y * sizeX + x;
	}

	private void GenerateQueenSolution()
	{
		m_rowCount = new int[sizeY];
		m_columnCount = new int[sizeX];
		GenerateQueenSolutionInternal();
	}

	private void GenerateQueenSolutionInternal()
	{
		// Simple N-Queens solver using backtracking
		int n = Math.Min(sizeX, sizeY);
		int[] queenColumns = new int[n];
		for (int i = 0; i < n; i++) queenColumns[i] = -1;

		if (SolveNQueens(queenColumns, 0, n))
		{
			for (int row = 0; row < n; row++)
			{
				int idx = Index(queenColumns[row], row);
				if (idx >= 0) queensGrid[idx] = 1;
			}
		}
	}

	private bool SolveNQueens(int[] columns, int row, int n)
	{
		if (row >= n) return true;
		for (int col = 0; col < sizeX; col++)
		{
			bool safe = true;
			for (int prevRow = 0; prevRow < row; prevRow++)
			{
				if (columns[prevRow] == col ||
					Math.Abs(columns[prevRow] - col) == Math.Abs(prevRow - row))
				{
					safe = false;
					break;
				}
			}
			if (safe)
			{
				columns[row] = col;
				if (SolveNQueens(columns, row + 1, n))
					return true;
			}
		}
		return false;
	}

	private void IncreaseCount(int x, int y)
	{
		if (x >= 0 && x < sizeX && m_columnCount != null) m_columnCount[x]++;
		if (y >= 0 && y < sizeY && m_rowCount != null) m_rowCount[y]++;
	}

	private void TryFillPositionWithQueen(int x, int y)
	{
		if (IsValidPosition(x, y, queensGrid))
		{
			SetQueen(x, y, 1);
			IncreaseCount(x, y);
		}
	}

	public void SetQueen(int x, int y, int value)
	{
		int idx = Index(x, y);
		if (idx >= 0 && idx < queensGrid.Length)
			queensGrid[idx] = value;
	}

	private bool IsValidPosition(int x, int y, int[] qGrid, params int[] ignoreColours)
	{
		if (x < 0 || x >= sizeX || y < 0 || y >= sizeY) return false;
		int idx = Index(x, y);
		if (idx < 0 || idx >= qGrid.Length) return false;

		// Check if position already has a queen
		if (qGrid[idx] == 1) return false;

		// Check row
		for (int cx = 0; cx < sizeX; cx++)
		{
			if (cx == x) continue;
			int ci = Index(cx, y);
			if (ci >= 0 && qGrid[ci] == 1) return false;
		}

		// Check column
		for (int cy = 0; cy < sizeY; cy++)
		{
			if (cy == y) continue;
			int ci = Index(x, cy);
			if (ci >= 0 && qGrid[ci] == 1) return false;
		}

		// Check diagonals (adjacent only for this variant)
		int[] dx = { -1, -1, 1, 1 };
		int[] dy = { -1, 1, -1, 1 };
		for (int d = 0; d < 4; d++)
		{
			int nx = x + dx[d];
			int ny = y + dy[d];
			if (nx >= 0 && nx < sizeX && ny >= 0 && ny < sizeY)
			{
				int ni = Index(nx, ny);
				if (ni >= 0 && qGrid[ni] == 1) return false;
			}
		}

		// Check same color constraint
		if (gridColours != null)
		{
			int myColor = gridColours[idx];
			bool ignoreColor = false;
			for (int ic = 0; ic < ignoreColours.Length; ic++)
			{
				if (ignoreColours[ic] == myColor) { ignoreColor = true; break; }
			}
			if (!ignoreColor)
			{
				for (int i = 0; i < qGrid.Length; i++)
				{
					if (i == idx) continue;
					if (qGrid[i] == 1 && gridColours[i] == myColor) return false;
				}
			}
		}

		return true;
	}

	private bool IsEmptyPosition(int x, int y, int[] qGrid, params int[] ignoreColours)
	{
		int idx = Index(x, y);
		if (idx < 0 || idx >= qGrid.Length) return false;
		return qGrid[idx] == 0;
	}

	public bool GetQueen(int x, int y, int[] qGrid = null)
	{
		int idx = Index(x, y);
		if (idx < 0) return false;
		int[] grid = qGrid ?? queensGrid;
		if (grid == null || idx >= grid.Length) return false;
		return grid[idx] >= 1;
	}

	public bool GetQueen(int index, int[] qGrid = null)
	{
		int[] grid = qGrid ?? queensGrid;
		if (grid == null || index < 0 || index >= grid.Length) return false;
		return grid[index] >= 1;
	}

	public int GetQueenRaw(int x, int y, int[] qGrid = null)
	{
		int idx = Index(x, y);
		if (idx < 0) return 0;
		int[] grid = qGrid ?? queensGrid;
		if (grid == null || idx >= grid.Length) return 0;
		return grid[idx];
	}

	public void SwapQueenToBeFix(int x, int y)
	{
		int idx = Index(x, y);
		if (idx < 0 || queensGrid == null) return;
		queensGrid[idx] = queensGrid[idx] == 1 ? 0 : 1;
	}

	public void SwapQueen(int x, int y, int value)
	{
		SetQueen(x, y, value);
	}

	public bool GetPrePlacedQueen(int x, int y)
	{
		return GetQueen(x, y);
	}

	public bool GetPrePlacedQueen(int index)
	{
		return GetQueen(index);
	}

	public int GetColor(int x, int y)
	{
		int idx = Index(x, y);
		if (idx < 0 || gridColours == null || idx >= gridColours.Length) return 0;
		return gridColours[idx];
	}

	public int GetColor(int index)
	{
		if (gridColours == null || index < 0 || index >= gridColours.Length) return 0;
		return gridColours[index];
	}

	public void SetColor(int x, int y, int color)
	{
		int idx = Index(x, y);
		if (idx >= 0 && gridColours != null && idx < gridColours.Length)
			gridColours[idx] = color;
	}

	public int QueenCount()
	{
		if (queensGrid == null) return 0;
		int count = 0;
		for (int i = 0; i < queensGrid.Length; i++)
		{
			if (queensGrid[i] >= 1) count++;
		}
		return count;
	}

	public bool IsPrePlacedQueen(int index)
	{
		if (queensGrid == null || index < 0 || index >= queensGrid.Length) return false;
		return queensGrid[index] == 2;
	}

	private bool IsLevelFullyColoured()
	{
		if (gridColours == null) return false;
		for (int i = 0; i < gridColours.Length; i++)
		{
			if (gridColours[i] < 0) return false;
		}
		return true;
	}

	private int TryGetRandomAdjacentColour(int cellIndex, List<List<int>> colorsACellCannotBe)
	{
		int x = GetX(cellIndex);
		int y = GetY(cellIndex);
		var possibleColors = new List<int>();

		// Check 4 neighbors
		int[] dx = { 0, 0, -1, 1 };
		int[] dy = { -1, 1, 0, 0 };
		for (int d = 0; d < 4; d++)
		{
			int nx = x + dx[d];
			int ny = y + dy[d];
			int ni = Index(nx, ny);
			if (ni >= 0 && ni < gridColours.Length && gridColours[ni] >= 0)
			{
				int c = gridColours[ni];
				if (colorsACellCannotBe != null && cellIndex < colorsACellCannotBe.Count &&
					colorsACellCannotBe[cellIndex].Contains(c))
					continue;
				if (!possibleColors.Contains(c))
					possibleColors.Add(c);
			}
		}

		if (possibleColors.Count == 0) return -1;
		var rng = new System.Random(cellIndex * 37);
		return possibleColors[rng.Next(possibleColors.Count)];
	}

	public void AutomarkQueenSouroundings(int index, ref int[] solverArray)
	{
		if (solverArray == null) return;
		MarkQueenAdjacentCells(index, ref solverArray);
		MarkQueenHorizontalVerticalCells(index, ref solverArray);
		MarkQueenSameColorCells(index, ref solverArray);
	}

	public void MarkQueenAdjacentCells(int index, ref int[] solverArray)
	{
		int x = GetX(index);
		int y = GetY(index);
		for (int dx = -1; dx <= 1; dx++)
		{
			for (int dy = -1; dy <= 1; dy++)
			{
				if (dx == 0 && dy == 0) continue;
				int nx = x + dx;
				int ny = y + dy;
				int ni = Index(nx, ny);
				if (ni >= 0 && ni < solverArray.Length && solverArray[ni] == QueensGrid.NONE)
					solverArray[ni] = QueensGrid.X;
			}
		}
	}

	public void MarkQueenHorizontalVerticalCells(int index, ref int[] solverArray)
	{
		int x = GetX(index);
		int y = GetY(index);
		// Mark same row
		for (int cx = 0; cx < sizeX; cx++)
		{
			int ci = Index(cx, y);
			if (ci >= 0 && ci != index && ci < solverArray.Length && solverArray[ci] == QueensGrid.NONE)
				solverArray[ci] = QueensGrid.X;
		}
		// Mark same column
		for (int cy = 0; cy < sizeY; cy++)
		{
			int ci = Index(x, cy);
			if (ci >= 0 && ci != index && ci < solverArray.Length && solverArray[ci] == QueensGrid.NONE)
				solverArray[ci] = QueensGrid.X;
		}
	}

	public void MarkQueenSameColorCells(int index, ref int[] solverArray)
	{
		if (gridColours == null) return;
		int color = gridColours[index];
		for (int i = 0; i < solverArray.Length; i++)
		{
			if (i == index) continue;
			if (i < gridColours.Length && gridColours[i] == color && solverArray[i] == QueensGrid.NONE)
				solverArray[i] = QueensGrid.X;
		}
	}

	public void AutomarkQueenSouroundings(int x, int y, ref int[,] solverArray)
	{
		if (solverArray == null) return;
		// Adjacent
		for (int dx = -1; dx <= 1; dx++)
		{
			for (int dy = -1; dy <= 1; dy++)
			{
				if (dx == 0 && dy == 0) continue;
				Mark(x + dx, y + dy, ref solverArray);
			}
		}
		// Row and column
		for (int cx = 0; cx < sizeX; cx++) Mark(cx, y, ref solverArray);
		for (int cy = 0; cy < sizeY; cy++) Mark(x, cy, ref solverArray);
		// Same color
		int color = GetColor(x, y);
		for (int i = 0; i < sizeX * sizeY; i++)
		{
			if (gridColours != null && gridColours[i] == color)
				Mark(GetX(i), GetY(i), ref solverArray);
		}
	}

	private void Mark(int x, int y, ref int[,] solverArray)
	{
		if (x < 0 || x >= sizeX || y < 0 || y >= sizeY) return;
		if (solverArray[x, y] == QueensGrid.NONE)
			solverArray[x, y] = QueensGrid.X;
	}

	private void Mark(int x, int y, ref int[] solverArray)
	{
		int idx = Index(x, y);
		if (idx >= 0 && idx < solverArray.Length && solverArray[idx] == QueensGrid.NONE)
			solverArray[idx] = QueensGrid.X;
	}

	public int GenerateAllSolutions()
	{
		if (queensGrid == null) return 0;
		int totalCells = sizeX * sizeY;
		int queenTarget = QueenCount();
		int solutionCount = 0;

		// Brute force with backtracking
		int[] solution = new int[totalCells];
		CountSolutions(solution, 0, 0, queenTarget, ref solutionCount, BRUTE_FORCE_ITERATION_COUNT_10K);
		return solutionCount;
	}

	private void CountSolutions(int[] solution, int startIndex, int placed, int target, ref int count, int maxIterations)
	{
		if (count >= maxIterations) return;
		if (placed == target)
		{
			if (ValidateSolution(solution))
				count++;
			return;
		}
		int remaining = target - placed;
		int totalCells = sizeX * sizeY;
		for (int i = startIndex; i <= totalCells - remaining; i++)
		{
			solution[i] = 1;
			CountSolutions(solution, i + 1, placed + 1, target, ref count, maxIterations);
			solution[i] = 0;
			if (count >= maxIterations) return;
		}
	}

	private void PrintSolution(int[] solution)
	{
		string s = "";
		for (int y = 0; y < sizeY; y++)
		{
			for (int x = 0; x < sizeX; x++)
			{
				int idx = Index(x, y);
				s += solution[idx] == 1 ? "Q " : ". ";
			}
			s += "\n";
		}
		UnityEngine.Debug.Log(s);
	}

	public bool ValidateSolution(int[] solution)
	{
		if (solution == null) return false;

		// Check each queen against constraints
		for (int i = 0; i < solution.Length; i++)
		{
			if (solution[i] != QueensGrid.QUEEN && solution[i] != 1) continue;

			int x = GetX(i);
			int y = GetY(i);

			for (int j = i + 1; j < solution.Length; j++)
			{
				if (solution[j] != QueensGrid.QUEEN && solution[j] != 1) continue;

				int x2 = GetX(j);
				int y2 = GetY(j);

				// Same row
				if (y == y2) return false;
				// Same column
				if (x == x2) return false;
				// Adjacent diagonal
				if (Math.Abs(x - x2) <= 1 && Math.Abs(y - y2) <= 1) return false;
				// Same color
				if (gridColours != null && gridColours[i] == gridColours[j]) return false;
			}
		}

		return true;
	}

	public int GetPreplacedQueenIndex()
	{
		if (queensGrid == null) return -1;
		for (int i = 0; i < queensGrid.Length; i++)
		{
			if (queensGrid[i] >= 1) return i;
		}
		return -1;
	}

	public List<int> GetSurroundingCellIndices(int index)
	{
		var result = new List<int>();
		int x = GetX(index);
		int y = GetY(index);
		for (int dx = -1; dx <= 1; dx++)
		{
			for (int dy = -1; dy <= 1; dy++)
			{
				if (dx == 0 && dy == 0) continue;
				int ni = Index(x + dx, y + dy);
				if (ni >= 0)
					result.Add(ni);
			}
		}
		return result;
	}
}
