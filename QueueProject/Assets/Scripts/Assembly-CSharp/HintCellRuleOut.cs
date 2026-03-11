using System;
using System.Collections.Generic;
using UnityEngine;

public class HintCellRuleOut : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyPlural;

	[SerializeField]
	private string m_textKeyOtherColors;

	[SerializeField]
	private string m_textKeyPluralOtherColors;

	private Dictionary<int, List<Vector2Int>> m_colors;

	private Dictionary<int, List<Vector2Int>> m_repeats;

	private List<int> m_allColors;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;
		m_gridState = gridState;

		// Build map of color -> list of empty (NONE) cell coords
		m_colors = new Dictionary<int, List<Vector2Int>>();
		m_allColors = new List<int>();

		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				int color = gridState.GetColor(x, y);
				// Only consider colors that don't already have a queen
				if (gridState.GetSolution(x, y) == QueensGrid.QUEEN)
				{
					// This color already has a queen, skip it entirely
					if (m_colors.ContainsKey(color))
						m_colors.Remove(color);
					if (!m_allColors.Contains(-color)) // mark as "has queen"
						m_allColors.Add(-color);
					continue;
				}
				if (m_allColors.Contains(-color)) continue; // already has queen

				if (!m_colors.TryGetValue(color, out var list))
				{
					list = new List<Vector2Int>();
					m_colors[color] = list;
					m_allColors.Add(color);
				}
				if (gridState.GetSolution(x, y) == QueensGrid.NONE)
					list.Add(new Vector2Int(x, y));
			}
		}

		// For each empty cell, check if it can "see" all remaining cells of some other color
		// If so, this cell can be eliminated because placing a queen here would block all cells of that color
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) != QueensGrid.NONE) continue;
				int cellColor = gridState.GetColor(x, y);
				var viewerCell = new Vector2Int(x, y);

				foreach (var kvp in m_colors)
				{
					int subjectColor = kvp.Key;
					if (subjectColor == cellColor) continue;
					if (kvp.Value.Count == 0) continue;

					if (CanCellSeeEntireOtherColor(viewerCell, subjectColor))
					{
						var viewerCells = new List<Vector2Int> { viewerCell };
						CollectInfo(gridState, viewerCells, subjectColor, result);
						return true;
					}
				}
			}
		}

		return false;
	}

	private bool CanCellSeeEntireOtherColor(Vector2Int viewerCell, int subjectColor)
	{
		if (m_gridState == null || !m_colors.ContainsKey(subjectColor)) return false;
		var cells = m_colors[subjectColor];

		for (int i = 0; i < cells.Count; i++)
		{
			if (!CanSee(viewerCell, cells[i]))
				return false;
		}
		return true;
	}

	private void CollectInfo(GridState gridState, List<Vector2Int> viewerCells, int subjectColor, HintsManager.HintResult result)
	{
		result.isQueen = false;
		result.hintTechniqueName = "CellRuleOut";

		// The viewer cells should be X'd (eliminated)
		for (int i = 0; i < viewerCells.Count; i++)
		{
			int idx = gridState.Index(viewerCells[i]);
			result.interactibleCells.Add(idx);
			result.highlightedCells.Add(idx);
		}

		// Also highlight the subject color cells
		if (m_colors.ContainsKey(subjectColor))
		{
			var cells = m_colors[subjectColor];
			for (int i = 0; i < cells.Count; i++)
			{
				int idx = gridState.Index(cells[i]);
				if (!result.highlightedCells.Contains(idx))
					result.highlightedCells.Add(idx);
			}
		}

		bool plural = viewerCells.Count > 1;
		bool isDefaultColor = HintsManager.Instance != null && HintsManager.Instance.IsDefaultColorSelected();
		string colorName = GetHighlighterLocalisedColorName(subjectColor);
		string key;
		if (plural)
			key = isDefaultColor ? m_textKeyPlural : m_textKeyPluralOtherColors;
		else
			key = isDefaultColor ? m_textKey : m_textKeyOtherColors;

		string text = GetLocalisedText(key);
		if (!string.IsNullOrEmpty(text))
			result.explanation = string.Format(text, colorName);
		else
			result.explanation = string.Format("This square can 'see' all remaining {0} squares. Because of this, you can eliminate (X) this square.", colorName);
	}

	public override void AutoDoAction(Action finishCallback)
	{
		finishCallback?.Invoke();
	}
}
