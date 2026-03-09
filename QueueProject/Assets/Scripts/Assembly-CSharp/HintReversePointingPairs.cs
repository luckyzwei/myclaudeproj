using System.Collections.Generic;
using UnityEngine;

public class HintReversePointingPairs : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	[SerializeField]
	private int m_rowsColsCount;

	private Dictionary<int, List<int>> m_rowsWithColors;

	private Dictionary<int, List<int>> m_columnsWithColours;

	private List<int> m_combinedList;

	private GridState m_gridState;

	protected virtual int GetRowsColCount()
	{
		return 0;
	}

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private void CollectInfo(List<int> rowColsList, List<int> colorsList, bool isColumn, HintsManager.HintResult result)
	{
	}

	private void GetOtherCells(List<int> rowColsList, List<int> colorsList, bool isColumn, HintsManager.HintResult result)
	{
	}

	private List<int> GetBiggestList(params List<int>[] lists)
	{
		return null;
	}
}
