using System.Collections.Generic;
using UnityEngine;

public class HintTriplePointingPairs : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private Dictionary<int, List<int>> m_colorsInColumns;

	private Dictionary<int, List<int>> m_colorsInRows;

	private List<int> m_colorsThatExistIn2RowCols;

	private List<int> m_combinedList;

	private HashSet<int> m_uniqueRowCols;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private List<int> GetBiggestList(List<int> list1, List<int> list2, List<int> list3)
	{
		return null;
	}

	private bool HasSameMembers(List<int> list1, List<int> list2, List<int> list3)
	{
		return false;
	}

	private bool IsThereOpenCellInRowColumn(List<int> rowColIndexes, bool isColumn, params int[] excludeColors)
	{
		return false;
	}

	private void CollectInfo(List<int> indexes, bool isColumn, HintsManager.HintResult result, params int[] columnColors)
	{
	}
}
