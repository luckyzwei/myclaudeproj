using System.Collections.Generic;
using UnityEngine;

public class HintRowColumnRuleOut : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyPlural;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private void CheckRow(Vector2Int coords, int index, Dictionary<int, List<Vector2Int>> rowRemovers)
	{
	}

	private void CheckColumn(Vector2Int coords, int column, Dictionary<int, List<Vector2Int>> columnRemovers)
	{
	}

	private bool CanSeeAllEmptyCellsOfRow(Vector2Int viewerCell, int row)
	{
		return false;
	}

	private bool CanSeeAllEmptyCellsOfColumn(Vector2Int viewerCell, int column)
	{
		return false;
	}

	private void CollectInfo(List<Vector2Int> viewerCells, int rowColIndex, HintsManager.HintResult result)
	{
	}
}
