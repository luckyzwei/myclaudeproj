using System.Collections.Generic;
using UnityEngine;

public class HintRowColumnRuleOutDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyPlural;

	private bool m_isColumn;

	private GridState m_gridState;

	private List<int> m_emptyCells;

	private List<int> m_remainingEmptyCells;

	private List<Vector2Int> m_viewerCells;

	private Dictionary<int, List<Vector2Int>> m_colRemovers;

	private Dictionary<int, List<Vector2Int>> m_rowRemovers;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool CheckRowColumn(int viewerColumn, bool isColumn, List<int> emptyCells)
	{
		return false;
	}

	private bool IsRowColEligible(int rowColIndex, bool isColumn, List<int> emptyCells)
	{
		return false;
	}

	private void CollectInfo(List<Vector2Int> viewerCells, int rowColIndex, HintsManager.HintResult result)
	{
	}
}
