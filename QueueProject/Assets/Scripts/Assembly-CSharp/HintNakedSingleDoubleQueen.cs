using System.Collections.Generic;
using UnityEngine;

public class HintNakedSingleDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColours;

	[SerializeField]
	private string m_textKey1Queen;

	[SerializeField]
	private string m_textKeyOtherColours1Queen;

	private int m_color;

	private HashSet<int> m_checkedColors;

	private List<Vector2Int> m_queens;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool HasOnlyOneEmptyCellNoQueen(GridState gridState, int checkingColor, List<Vector2Int> emptyCellCoords)
	{
		return false;
	}

	private void CollectInfo(GridState gridState, HintsManager.HintResult result)
	{
	}
}
