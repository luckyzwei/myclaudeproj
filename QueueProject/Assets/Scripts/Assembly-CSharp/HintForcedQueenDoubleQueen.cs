using System.Collections.Generic;
using UnityEngine;

public class HintForcedQueenDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyPlural;

	private bool m_isColumn;

	private GridState m_gridState;

	private List<Vector2Int> m_emptyCells;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool HasRowColLessThan2EmptyCell(int rowCol, bool isColumn)
	{
		return false;
	}

	private void CollectInfo(GridState gridState, int index, bool isColumn, HintsManager.HintResult result)
	{
	}
}
