using System.Collections.Generic;
using UnityEngine;

public class HintRemoteCellDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private HashSet<int> m_checkedColors;

	private GridState m_gridState;

	private List<Vector2Int> m_emptyCells;

	private List<Vector2Int> m_queenCells;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private void CollectInfo(HintsManager.HintResult result, int subjectColor)
	{
	}

	private bool CheckIfColorHasNoQueenAndLessThan5Cells(int checkingColor, List<Vector2Int> emptyCells)
	{
		return false;
	}

	private bool CheckForRemoteCell(List<Vector2Int> emptyCells, List<Vector2Int> queenCells)
	{
		return false;
	}
}
