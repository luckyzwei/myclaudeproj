using System.Collections.Generic;
using UnityEngine;

public class HintPointingPairs : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private Dictionary<int, List<int>> m_colorsInColumns;

	private Dictionary<int, List<int>> m_colorsInRows;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;
		m_gridState = gridState;

		// For each color without a queen, find which rows/columns its empty cells occupy
		// If all empty cells of a color are in a single row/column, we can eliminate other cells in that row/column

		var colorsChecked = new HashSet<int>();

		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				int color = gridState.GetColor(x, y);
				if (colorsChecked.Contains(color)) continue;

				// Skip colors that already have a queen
				if (gridState.GetSolution(x, y) == QueensGrid.QUEEN)
				{
					colorsChecked.Add(color);
					continue;
				}
			}
		}

		colorsChecked.Clear();

		// Build color -> columns map and color -> rows map
		m_colorsInColumns = new Dictionary<int, List<int>>();
		m_colorsInRows = new Dictionary<int, List<int>>();

		var colorsWithQueen = new HashSet<int>();
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) == QueensGrid.QUEEN)
					colorsWithQueen.Add(gridState.GetColor(x, y));
			}
		}

		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				int color = gridState.GetColor(x, y);
				if (colorsWithQueen.Contains(color)) continue;
				if (gridState.GetSolution(x, y) != QueensGrid.NONE) continue;

				// Track which columns this color occupies
				if (!m_colorsInColumns.TryGetValue(color, out var cols))
				{
					cols = new List<int>();
					m_colorsInColumns[color] = cols;
				}
				if (!cols.Contains(x)) cols.Add(x);

				// Track which rows
				if (!m_colorsInRows.TryGetValue(color, out var rows))
				{
					rows = new List<int>();
					m_colorsInRows[color] = rows;
				}
				if (!rows.Contains(y)) rows.Add(y);
			}
		}

		// Check columns: if a color's empty cells are all in one column, eliminate other cells in that column
		foreach (var kvp in m_colorsInColumns)
		{
			int color = kvp.Key;
			var cols = kvp.Value;
			if (cols.Count == 1)
			{
				int col = cols[0];
				if (IsThereOpenCellInRowColumn(col, true, color))
				{
					m_isColumn = true;
					CollectInfo(col, true, color, result);
					return true;
				}
			}
		}

		// Check rows
		foreach (var kvp in m_colorsInRows)
		{
			int color = kvp.Key;
			var rows = kvp.Value;
			if (rows.Count == 1)
			{
				int row = rows[0];
				if (IsThereOpenCellInRowColumn(row, false, color))
				{
					m_isColumn = false;
					CollectInfo(row, false, color, result);
					return true;
				}
			}
		}

		return false;
	}

	private bool IsThereOpenCellInRowColumn(int rowColIndex, bool isColumn, int excludeColor)
	{
		if (m_gridState == null) return false;

		if (isColumn)
		{
			for (int y = 0; y < m_gridState.Size.y; y++)
			{
				if (m_gridState.GetColor(rowColIndex, y) != excludeColor && m_gridState.GetSolution(rowColIndex, y) == QueensGrid.NONE)
					return true;
			}
		}
		else
		{
			for (int x = 0; x < m_gridState.Size.x; x++)
			{
				if (m_gridState.GetColor(x, rowColIndex) != excludeColor && m_gridState.GetSolution(x, rowColIndex) == QueensGrid.NONE)
					return true;
			}
		}
		return false;
	}

	private void CollectInfo(int index, bool isColumn, int columnColor, HintsManager.HintResult result)
	{
		result.isQueen = false;
		result.hintTechniqueName = "PointingPairs";

		// Interactible: non-color cells in this row/column that should be eliminated
		if (isColumn)
		{
			for (int y = 0; y < m_gridState.Size.y; y++)
			{
				if (m_gridState.GetColor(index, y) != columnColor && m_gridState.GetSolution(index, y) == QueensGrid.NONE)
					result.interactibleCells.Add(m_gridState.Index(index, y));
			}
		}
		else
		{
			for (int x = 0; x < m_gridState.Size.x; x++)
			{
				if (m_gridState.GetColor(x, index) != columnColor && m_gridState.GetSolution(x, index) == QueensGrid.NONE)
					result.interactibleCells.Add(m_gridState.Index(x, index));
			}
		}

		// Highlight: the color cells in this row/column (the "pointing pair")
		if (isColumn)
		{
			for (int y = 0; y < m_gridState.Size.y; y++)
			{
				if (m_gridState.GetColor(index, y) == columnColor && m_gridState.GetSolution(index, y) == QueensGrid.NONE)
					result.highlightedCells.Add(m_gridState.Index(index, y));
			}
		}
		else
		{
			for (int x = 0; x < m_gridState.Size.x; x++)
			{
				if (m_gridState.GetColor(x, index) == columnColor && m_gridState.GetSolution(x, index) == QueensGrid.NONE)
					result.highlightedCells.Add(m_gridState.Index(x, index));
			}
		}

		// Also highlight interactible cells
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
			result.explanation = string.Format("One of these {0} squares must have a Queen. You can eliminate (X) all other squares in this {1}",
				colorName, isColumn ? "column" : "row");
	}
}
