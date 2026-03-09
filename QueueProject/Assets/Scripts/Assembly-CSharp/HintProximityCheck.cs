using System;
using System.Collections.Generic;
using UnityEngine;

public class HintProximityCheck : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private int CountUnmarkedCellsAround(GridState gridState, int x, int y, List<int> interactableCells, ManyToManyCellConnection cellConnection)
	{
		return 0;
	}

	public override void AutoDoAction(Action finishCallback)
	{
	}
}
