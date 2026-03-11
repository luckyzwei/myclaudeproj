using System;
using System.Collections.Generic;
using UnityEngine;

public class HintProximityCheck : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		var interactableCells = new List<int>();
		var cellConnection = new ManyToManyCellConnection();
		int totalFound = 0;

		// For each placed queen, find unmarked adjacent cells
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) == QueensGrid.QUEEN)
				{
					totalFound += CountUnmarkedCellsAround(gridState, x, y, interactableCells, cellConnection);
				}
			}
		}

		if (totalFound == 0) return false;

		result.isQueen = false;
		result.hintTechniqueName = "ProximityCheck";
		result.cellConnectionList = cellConnection;

		// Only highlight the interactible cells (cells to be X'd)
		// Queen cells are already visible - no need to highlight them
		for (int i = 0; i < interactableCells.Count; i++)
		{
			result.interactibleCells.Add(interactableCells[i]);
			result.highlightedCells.Add(interactableCells[i]);
		}

		string text = GetLocalisedText(m_textKey);
		result.explanation = !string.IsNullOrEmpty(text) ? text : "You can eliminate (X) all squares that touch Queens";
		return true;
	}

	private int CountUnmarkedCellsAround(GridState gridState, int x, int y, List<int> interactableCells, ManyToManyCellConnection cellConnection)
	{
		int queenIdx = gridState.Index(x, y);
		int count = 0;

		// Check all 8 adjacent cells (touching = neighbors only, not same row/col at distance)
		for (int dx = -1; dx <= 1; dx++)
		{
			for (int dy = -1; dy <= 1; dy++)
			{
				if (dx == 0 && dy == 0) continue;
				int nx = x + dx;
				int ny = y + dy;
				if (nx < 0 || nx >= gridState.Size.x || ny < 0 || ny >= gridState.Size.y) continue;
				if (gridState.GetSolution(nx, ny) == QueensGrid.NONE)
				{
					int idx = gridState.Index(nx, ny);
					if (!interactableCells.Contains(idx))
						interactableCells.Add(idx);
					cellConnection.Add(queenIdx, idx);
					count++;
				}
			}
		}
		return count;
	}

	public override void AutoDoAction(Action finishCallback)
	{
		finishCallback?.Invoke();
	}
}
