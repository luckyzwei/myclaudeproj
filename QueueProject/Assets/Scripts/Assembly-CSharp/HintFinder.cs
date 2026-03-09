using System.Collections.Generic;

public class HintFinder
{
	private enum CellState
	{
		AVAILABLE = 0,
		ALREADY_OCCUPIED = 1,
		SAME_COLOUR_AS_VISIBLE_QUEEN = 2,
		SAME_ROW_COLUMN_AS_VISIBLE_QUEEN = 3,
		ADJACENT_TO_VISIBLE_QUEEN = 4
	}

	private const int AMOUNT_OF_HINTS = 3;

	private static void MarkStates(int[] markedCells, CellState[] cellStates, CellState cellState)
	{
	}

	private static int CountCellStates(CellState[] cellStates, CellState requiredState)
	{
		return 0;
	}

	private static int[] GetCellsOfState(CellState[] cellStates, CellState requiredState)
	{
		return null;
	}

	public static int[] FindHints(int[] playerSolution, LevelData levelData)
	{
		return null;
	}

	private static int[] SelectHintCells(List<int[]> cellGroups)
	{
		return null;
	}
}
