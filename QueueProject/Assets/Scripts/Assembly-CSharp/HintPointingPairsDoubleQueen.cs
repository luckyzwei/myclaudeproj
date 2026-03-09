using System.Collections.Generic;
using UnityEngine;

public class HintPointingPairsDoubleQueen : BaseHint
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
		return false;
	}

	private bool IsThereOpenCellInRowColumn(int rowColIndex, bool isColumn, int excludeColor)
	{
		return false;
	}

	private int IsThereColorOnlyIn1RowCol(Dictionary<int, List<int>> dictionary, int excludeColor)
	{
		return 0;
	}

	private void CollectInfo(int index, bool isColumn, int color1, int color2, HintsManager.HintResult result)
	{
	}
}
