using UnityEngine;

public class HintForcedQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;
		m_gridState = gridState;

		// Check each row for exactly one empty cell (no queen placed yet)
		for (int y = 0; y < gridState.Size.y; y++)
		{
			if (HasRowOneEmptyCell(y, out Vector2Int coords))
			{
				DoActionInternal(gridState, y, false, coords, result);
				return true;
			}
		}

		// Check each column for exactly one empty cell
		for (int x = 0; x < gridState.Size.x; x++)
		{
			if (HasColumnOneEmptyCell(x, out Vector2Int coords))
			{
				DoActionInternal(gridState, x, true, coords, result);
				return true;
			}
		}

		return false;
	}

	private bool HasRowOneEmptyCell(int row, out Vector2Int coords)
	{
		coords = default(Vector2Int);
		if (m_gridState == null) return false;

		int emptyCount = 0;
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
				emptyCount++;
				coords = new Vector2Int(x, row);
			}
		}

		if (hasQueen) return false;
		return emptyCount == 1;
	}

	private bool HasColumnOneEmptyCell(int column, out Vector2Int coords)
	{
		coords = default(Vector2Int);
		if (m_gridState == null) return false;

		int emptyCount = 0;
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
				emptyCount++;
				coords = new Vector2Int(column, y);
			}
		}

		if (hasQueen) return false;
		return emptyCount == 1;
	}

	private void DoActionInternal(GridState gridState, int index, bool isColumn, Vector2Int cellCoords, HintsManager.HintResult result)
	{
		m_isColumn = isColumn;
		int cellIndex = gridState.Index(cellCoords);

		result.isQueen = true;
		result.hintTechniqueName = "ForcedQueen";
		result.interactibleCells.Add(cellIndex);
		result.highlightedCells.Add(cellIndex);

		string text = GetLocalisedText(m_textKey);
		if (!string.IsNullOrEmpty(text))
			result.explanation = ReplaceRowColTag(text, isColumn);
		else
			result.explanation = "This is the last available square in the " + (isColumn ? "column" : "row") + " so it must be a Queen";
	}
}
