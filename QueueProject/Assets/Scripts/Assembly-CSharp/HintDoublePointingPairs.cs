using System.Collections.Generic;
using UnityEngine;

public class HintDoublePointingPairs : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private Dictionary<int, List<int>> m_colorsInColumns;

	private Dictionary<int, List<int>> m_colorsInRows;

	private List<int> m_colorsThatExistIn2RowCols;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool HasSameMembers(List<int> list1, List<int> list2)
	{
		return false;
	}

	private bool IsThereOpenCellInRowColumn(List<int> rowColIndexes, bool isColumn, params int[] excludeColors)
	{
		return false;
	}

	private void CollectInfo(GridState gridState, HintsManager.HintResult result, List<int> indexes, bool isColumn, params int[] columnColors)
	{
	}
}
