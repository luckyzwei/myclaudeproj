using System.Collections.Generic;
using UnityEngine;

public class HintFallback : BaseHint
{
	private const int HINT_CELLS_COUNT = 3;

	[SerializeField]
	private string m_textKey;

	private List<int> m_candiateCells;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		m_candiateCells = new List<int>();

		// Find cells that should be X'd (empty cells where the solution is not a queen)
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) == QueensGrid.NONE && !gridState.IsQueen(x, y))
				{
					m_candiateCells.Add(gridState.Index(x, y));
					if (m_candiateCells.Count >= HINT_CELLS_COUNT)
						break;
				}
			}
			if (m_candiateCells.Count >= HINT_CELLS_COUNT) break;
		}

		// Also check for cells that should be queens (empty cells where solution IS queen)
		if (m_candiateCells.Count == 0)
		{
			for (int x = 0; x < gridState.Size.x; x++)
			{
				for (int y = 0; y < gridState.Size.y; y++)
				{
					if (gridState.GetSolution(x, y) == QueensGrid.NONE && gridState.IsQueen(x, y))
					{
						m_candiateCells.Add(gridState.Index(x, y));
						result.isQueen = true;
						break;
					}
				}
				if (m_candiateCells.Count > 0) break;
			}
		}

		if (m_candiateCells.Count == 0) return false;

		if (!result.isQueen)
			result.isQueen = false;
		result.hintTechniqueName = "Fallback";

		for (int i = 0; i < m_candiateCells.Count; i++)
		{
			result.interactibleCells.Add(m_candiateCells[i]);
			result.highlightedCells.Add(m_candiateCells[i]);
		}

		string text = GetLocalisedText(m_textKey);
		result.explanation = !string.IsNullOrEmpty(text) ? text : "You can eliminate (X) these squares.";
		return true;
	}
}
