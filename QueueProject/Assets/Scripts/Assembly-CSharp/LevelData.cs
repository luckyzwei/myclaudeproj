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

	public List<List<int>> DebugCannot => null;

	public LevelData()
	{
	}

	public LevelData(LevelData other)
	{
	}

	public void GenerateUsedColours()
	{
	}

	public bool FixColours()
	{
		return false;
	}

	public void RandomQueenGeneration(int _sizeX, int _sizeY)
	{
	}

	public void RandomColourGeneration(bool useSwapConstraint)
	{
	}

	public void RandomColourGenerationInternal(bool useSwapConstraint)
	{
	}

	public int GetX(int index)
	{
		return 0;
	}

	public int GetY(int index)
	{
		return 0;
	}

	public int Index(int x, int y)
	{
		return 0;
	}

	private void GenerateQueenSolution()
	{
	}

	private void GenerateQueenSolutionInternal()
	{
	}

	private void IncreaseCount(int x, int y)
	{
	}

	private void TryFillPositionWithQueen(int x, int y)
	{
	}

	public void SetQueen(int x, int y, int value)
	{
	}

	private bool IsValidPosition(int x, int y, int[] qGrid, params int[] ignoreColours)
	{
		return false;
	}

	private bool IsEmptyPosition(int x, int y, int[] qGrid, params int[] ignoreColours)
	{
		return false;
	}

	public bool GetQueen(int x, int y, int[] qGrid = null)
	{
		return false;
	}

	public bool GetQueen(int index, int[] qGrid = null)
	{
		return false;
	}

	public int GetQueenRaw(int x, int y, int[] qGrid = null)
	{
		return 0;
	}

	public void SwapQueenToBeFix(int x, int y)
	{
	}

	public void SwapQueen(int x, int y, int value)
	{
	}

	public bool GetPrePlacedQueen(int x, int y)
	{
		return false;
	}

	public bool GetPrePlacedQueen(int index)
	{
		return false;
	}

	public int GetColor(int x, int y)
	{
		return 0;
	}

	public int GetColor(int index)
	{
		return 0;
	}

	public void SetColor(int x, int y, int color)
	{
	}

	public int QueenCount()
	{
		return 0;
	}

	private bool IsLevelFullyColoured()
	{
		return false;
	}

	private int TryGetRandomAdjacentColour(int cellIndex, List<List<int>> colorsACellCannotBe)
	{
		return 0;
	}

	public void AutomarkQueenSouroundings(int index, ref int[] solverArray)
	{
	}

	public void MarkQueenAdjacentCells(int index, ref int[] solverArray)
	{
	}

	public void MarkQueenHorizontalVerticalCells(int index, ref int[] solverArray)
	{
	}

	public void MarkQueenSameColorCells(int index, ref int[] solverArray)
	{
	}

	public void AutomarkQueenSouroundings(int x, int y, ref int[,] solverArray)
	{
	}

	private void Mark(int x, int y, ref int[,] solverArray)
	{
	}

	private void Mark(int x, int y, ref int[] solverArray)
	{
	}

	public int GenerateAllSolutions()
	{
		return 0;
	}

	private void PrintSolution(int[] solution)
	{
	}

	public bool ValidateSolution(int[] solution)
	{
		return false;
	}

	public int GetPreplacedQueenIndex()
	{
		return 0;
	}

	public List<int> GetSurroundingCellIndices(int index)
	{
		return null;
	}
}
