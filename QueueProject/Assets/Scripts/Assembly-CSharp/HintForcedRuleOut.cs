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
		return false;
	}

	private bool HasOpenCellsWithColor(GridState gridState, int rowColumnIndex, int wantedColor, bool isColumn)
	{
		return false;
	}

	private int GetColumnOneColor(int column)
	{
		return 0;
	}

	private int GetRowOneColor(int row)
	{
		return 0;
	}

	private void CollectInfo(GridState gridState, int index, bool isColumn, int columnColor, HintsManager.HintResult result)
	{
	}
}
