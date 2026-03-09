using System;
using System.Collections.Generic;
using UnityEngine;

public class HintNakedSingle : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColours;

	[SerializeField]
	private string m_textKeyOnlyCell;

	[SerializeField]
	private string m_textKeyOtherColoursOnlyCell;

	private int m_color;

	private HashSet<int> m_checkedColors;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool HasOnlyOneEmptyCellNoQueen(GridState gridState, int checkingColor, out Vector2Int emptyCellCoords, out int totalCount)
	{
		emptyCellCoords = default(Vector2Int);
		totalCount = default(int);
		return false;
	}

	private void CollectInfo(int cellIndex, bool onlyCell, HintsManager.HintResult result)
	{
	}

	public override void AutoDoAction(Action finishCallback)
	{
	}
}
