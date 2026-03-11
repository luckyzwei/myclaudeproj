using System;
using System.Collections.Generic;
using UnityEngine;

public class HintNakedSingle : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColours;

	[SerializeField]
	private string m_textKeyOnlyCell;

	[SerializeField]
	private string m_textKeyOtherColoursOnlyCell;

	private int m_color;

	private HashSet<int> m_checkedColors;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		m_checkedColors = new HashSet<int>();

		// For each color, check if there's only one empty (NONE) cell left that doesn't have a queen yet
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				int color = gridState.GetColor(x, y);
				if (m_checkedColors.Contains(color)) continue;
				m_checkedColors.Add(color);

				if (HasOnlyOneEmptyCellNoQueen(gridState, color, out Vector2Int emptyCellCoords, out int totalCount))
				{
					m_color = color;
					int cellIndex = gridState.Index(emptyCellCoords);
					bool onlyCell = (totalCount == 1);
					CollectInfo(cellIndex, onlyCell, result);
					return true;
				}
			}
		}
		return false;
	}

	private bool HasOnlyOneEmptyCellNoQueen(GridState gridState, int checkingColor, out Vector2Int emptyCellCoords, out int totalCount)
	{
		emptyCellCoords = default(Vector2Int);
		totalCount = 0;
		int emptyCount = 0;
		bool hasQueen = false;

		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetColor(x, y) != checkingColor) continue;
				totalCount++;
				int sol = gridState.GetSolution(x, y);
				if (sol == QueensGrid.QUEEN)
				{
					hasQueen = true;
					break;
				}
				if (sol == QueensGrid.NONE)
				{
					emptyCount++;
					emptyCellCoords = new Vector2Int(x, y);
				}
			}
			if (hasQueen) break;
		}

		if (hasQueen) return false;
		return emptyCount == 1;
	}

	private void CollectInfo(int cellIndex, bool onlyCell, HintsManager.HintResult result)
	{
		result.isQueen = true;
		result.hintTechniqueName = "NakedSingle";
		result.interactibleCells.Add(cellIndex);
		result.highlightedCells.Add(cellIndex);

		string colorName = GetHighlighterLocalisedColorName(m_color);
		bool isDefaultColor = HintsManager.Instance != null && HintsManager.Instance.IsDefaultColorSelected();
		string key = onlyCell
			? (isDefaultColor ? m_textKeyOnlyCell : m_textKeyOtherColoursOnlyCell)
			: (isDefaultColor ? m_textKey : m_textKeyOtherColours);
		string text = GetLocalisedText(key);
		if (!string.IsNullOrEmpty(text))
			result.explanation = string.Format(text, colorName);
		else
			result.explanation = string.Format("This is the last square of {0}! So it must be a Queen", colorName);
	}

	public override void AutoDoAction(Action finishCallback)
	{
		finishCallback?.Invoke();
	}
}
