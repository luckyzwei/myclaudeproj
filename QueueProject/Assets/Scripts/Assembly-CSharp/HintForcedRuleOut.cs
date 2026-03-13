using System.Collections.Generic;
using UnityEngine;

public class HintForcedRuleOut : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private bool m_isColumn;

	private GridState m_gridState;

	private List<int> m_cellsList;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;
		m_gridState = gridState;
		m_cellsList = new List<int>();

		// Check columns: if a column has only one color left (no queen yet),
		// then the queen MUST be that color => eliminate all other cells of that color outside this column
		for (int x = 0; x < gridState.Size.x; x++)
		{
			int oneColor = GetColumnOneColor(x);
			if (oneColor >= 0 && HasOpenCellsWithColor(gridState, x, oneColor, true))
			{
				CollectInfo(gridState, x, true, oneColor, result);
				if (result.interactibleCells.Count > 0)
					return true;
				result.Clear();
				result.highlightedCells = new List<int>();
				result.interactibleCells = new List<int>();
			}
		}

		// Check rows
		for (int y = 0; y < gridState.Size.y; y++)
		{
			int oneColor = GetRowOneColor(y);
			if (oneColor >= 0 && HasOpenCellsWithColor(gridState, y, oneColor, false))
			{
				CollectInfo(gridState, y, false, oneColor, result);
				if (result.interactibleCells.Count > 0)
					return true;
				result.Clear();
				result.highlightedCells = new List<int>();
				result.interactibleCells = new List<int>();
			}
		}

		return false;
	}

	private bool HasOpenCellsWithColor(GridState gridState, int rowColumnIndex, int wantedColor, bool isColumn)
	{
		// Check if there are unmarked cells of wantedColor OUTSIDE this row/column
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (isColumn && x == rowColumnIndex) continue;
				if (!isColumn && y == rowColumnIndex) continue;
				if (gridState.GetColor(x, y) == wantedColor && gridState.GetSolution(x, y) == QueensGrid.NONE)
					return true;
			}
		}
		return false;
	}

	private int GetColumnOneColor(int column)
	{
		if (m_gridState == null) return -1;
		int foundColor = -1;
		bool hasQueen = false;

		for (int y = 0; y < m_gridState.Size.y; y++)
		{
			int sol = m_gridState.GetSolution(column, y);
			if (sol == QueensGrid.QUEEN)
			{
				hasQueen = true;
				break;
			}
			if (sol == QueensGrid.NONE)
			{
				int color = m_gridState.GetColor(column, y);
				if (foundColor == -1)
					foundColor = color;
				else if (foundColor != color)
					return -1; // multiple colors => not forced
			}
		}

		if (hasQueen) return -1;
		return foundColor;
	}

	private int GetRowOneColor(int row)
	{
		if (m_gridState == null) return -1;
		int foundColor = -1;
		bool hasQueen = false;

		for (int x = 0; x < m_gridState.Size.x; x++)
		{
			int sol = m_gridState.GetSolution(x, row);
			if (sol == QueensGrid.QUEEN)
			{
				hasQueen = true;
				break;
			}
			if (sol == QueensGrid.NONE)
			{
				int color = m_gridState.GetColor(x, row);
				if (foundColor == -1)
					foundColor = color;
				else if (foundColor != color)
					return -1;
			}
		}

		if (hasQueen) return -1;
		return foundColor;
	}

	private void CollectInfo(GridState gridState, int index, bool isColumn, int columnColor, HintsManager.HintResult result)
	{
		m_isColumn = isColumn;
		result.isQueen = false;
		result.hintTechniqueName = "ForcedRuleOut";

		// Cells to eliminate: all cells of columnColor OUTSIDE this row/column
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (isColumn && x == index) continue;
				if (!isColumn && y == index) continue;
				if (gridState.GetColor(x, y) == columnColor && gridState.GetSolution(x, y) == QueensGrid.NONE)
				{
					int idx = gridState.Index(x, y);
					result.interactibleCells.Add(idx);
				}
			}
		}

		// Highlight the forced row/column cells
		if (isColumn)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(index, y) == QueensGrid.NONE)
					result.highlightedCells.Add(gridState.Index(index, y));
			}
		}
		else
		{
			for (int x = 0; x < gridState.Size.x; x++)
			{
				if (gridState.GetSolution(x, index) == QueensGrid.NONE)
					result.highlightedCells.Add(gridState.Index(x, index));
			}
		}
		// Also highlight interactible
		for (int i = 0; i < result.interactibleCells.Count; i++)
		{
			if (!result.highlightedCells.Contains(result.interactibleCells[i]))
				result.highlightedCells.Add(result.interactibleCells[i]);
		}

		string colorName = GetHighlighterLocalisedColorName(columnColor);
		bool isDefaultColor = HintsManager.Instance != null && HintsManager.Instance.IsDefaultColorSelected();
		string key = isDefaultColor ? m_textKey : m_textKeyOtherColors;
		string text = GetLocalisedText(key);
		if (!string.IsNullOrEmpty(text))
		{
			text = string.Format(text, colorName);
			result.explanation = ReplaceRowColTag(text, isColumn);
		}
		else
			result.explanation = string.Format("The Queen in this {0} must be {1}. You can therefore eliminate (X) all other {1} squares",
				isColumn ? "column" : "row", colorName);
	}
}
