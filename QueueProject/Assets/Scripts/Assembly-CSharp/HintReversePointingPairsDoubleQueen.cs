using System.Collections.Generic;
using UnityEngine;

public class HintReversePointingPairsDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	[SerializeField]
	private int m_rowsColsCount;

	private Dictionary<int, List<int>> m_rowsWithColors;

	private Dictionary<int, List<int>> m_columnsWithColours;

	private Dictionary<int, int> m_rowsWithQueens;

	private Dictionary<int, int> m_columnsWithQueens;

	private HashSet<int> m_colorsWithQueens;

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

	private bool HasQueens(List<int> rows, Dictionary<int, int> rowsWithQueens, HashSet<int> colorsWithQueens, bool isColumn)
	{
		return false;
	}

	private void GetRowsAndColumnsWithQueens()
	{
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
