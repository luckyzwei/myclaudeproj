using System.Collections.Generic;
using UnityEngine;

public class HintColourCheck : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private Dictionary<int, int> m_colorWithOpenCells;

	private int m_color;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		m_colorWithOpenCells = new Dictionary<int, int>();

		// Find colors that already have a queen placed
		var colorsWithQueens = new HashSet<int>();
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) == QueensGrid.QUEEN)
					colorsWithQueens.Add(gridState.GetColor(x, y));
			}
		}

		// For each color with a queen, find unmarked cells of the same color that can be eliminated
		foreach (int color in colorsWithQueens)
		{
			int count = CountUnmarkedCellsInColor(gridState, color);
			if (count > 0)
			{
				m_color = color;
				CollectInfo(gridState, result);
				return true;
			}
		}

		return false;
	}

	private int CountUnmarkedCellsInColor(GridState gridState, int wantedColor)
	{
		int count = 0;
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetColor(x, y) == wantedColor && gridState.GetSolution(x, y) == QueensGrid.NONE)
					count++;
			}
		}
		return count;
	}

	private void CollectInfo(GridState gridState, HintsManager.HintResult result)
	{
		result.isQueen = false;
		result.hintTechniqueName = "ColourCheck";

		// Find unmarked cells of this color (these should be X'd)
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetColor(x, y) == m_color && gridState.GetSolution(x, y) == QueensGrid.NONE)
				{
					int idx = gridState.Index(x, y);
					result.interactibleCells.Add(idx);
				}
			}
		}

		// Highlight only the interactible cells (cells to be X'd)
		// Queen cells are already visible on the board - no need to highlight them
		for (int i = 0; i < result.interactibleCells.Count; i++)
		{
			result.highlightedCells.Add(result.interactibleCells[i]);
		}

		string colorName = GetHighlighterLocalisedColorName(m_color);
		bool isDefaultColor = HintsManager.Instance != null && HintsManager.Instance.IsDefaultColorSelected();
		string key = isDefaultColor ? m_textKey : m_textKeyOtherColors;
		string text = GetLocalisedText(key);
		if (!string.IsNullOrEmpty(text))
			result.explanation = string.Format(text, colorName);
		else
			result.explanation = string.Format("There is already a Queen on {0} so you can eliminate (X) these squares", colorName);
	}
}
