using System.Collections.Generic;
using UnityEngine;

public class HintRowColumnCheck : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		var cellsList = new List<int>();
		var cellConnection = new ManyToManyCellConnection();

		// For each placed queen, check its row and column for unmarked cells
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) != QueensGrid.QUEEN) continue;

				int queenIdx = gridState.Index(x, y);
				AddUnmarkedCellInRow(gridState, y, queenIdx, cellsList, cellConnection);
				AddUnmarkedCellInColumn(gridState, x, queenIdx, cellsList, cellConnection);
			}
		}

		if (cellsList.Count == 0) return false;

		result.isQueen = false;
		result.hintTechniqueName = "RowColumnCheck";
		result.cellConnectionList = cellConnection;

		// Only highlight the interactible cells (cells to be X'd)
		// Queen cells are already visible - no need to highlight them
		for (int i = 0; i < cellsList.Count; i++)
		{
			result.interactibleCells.Add(cellsList[i]);
			result.highlightedCells.Add(cellsList[i]);
		}

		string text = GetLocalisedText(m_textKey);
		result.explanation = !string.IsNullOrEmpty(text) ? text : "You can eliminate (X) all squares in the same row or column as a Queen";
		return true;
	}

	private bool AddUnmarkedCellInRow(GridState gridState, int row, int queenCell, List<int> cellsList, ManyToManyCellConnection cellConnection)
	{
		bool found = false;
		for (int x = 0; x < gridState.Size.x; x++)
		{
			int idx = gridState.Index(x, row);
			if (idx == queenCell) continue;
			if (gridState.GetSolution(x, row) == QueensGrid.NONE)
			{
				if (!cellsList.Contains(idx))
					cellsList.Add(idx);
				cellConnection.Add(queenCell, idx);
				found = true;
			}
		}
		return found;
	}

	private bool AddUnmarkedCellInColumn(GridState gridState, int column, int queenCell, List<int> cellsList, ManyToManyCellConnection cellConnection)
	{
		bool found = false;
		for (int y = 0; y < gridState.Size.y; y++)
		{
			int idx = gridState.Index(column, y);
			if (idx == queenCell) continue;
			if (gridState.GetSolution(column, y) == QueensGrid.NONE)
			{
				if (!cellsList.Contains(idx))
					cellsList.Add(idx);
				cellConnection.Add(queenCell, idx);
				found = true;
			}
		}
		return found;
	}
}
