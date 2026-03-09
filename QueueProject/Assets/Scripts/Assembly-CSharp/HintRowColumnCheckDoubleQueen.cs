using System.Collections.Generic;
using UnityEngine;

public class HintRowColumnCheckDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	private Dictionary<int, int> m_rowsWithQueens;

	private Dictionary<int, int> m_columnsWithQueens;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool IsThereEmptyCellsInRowColumn(GridState gridState, int rowCol, bool isColumn, int queenCell1, int queenCell2, HintsManager.HintResult result)
	{
		return false;
	}
}
