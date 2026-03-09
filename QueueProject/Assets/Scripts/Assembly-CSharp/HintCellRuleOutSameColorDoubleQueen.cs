using System;
using System.Collections.Generic;
using UnityEngine;

public class HintCellRuleOutSameColorDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyPlural;

	[SerializeField]
	private string m_textKeyOtherColors;

	[SerializeField]
	private string m_textKeyPluralOtherColors;

	private Dictionary<int, List<Vector2Int>> m_colors;

	private Dictionary<int, List<Vector2Int>> m_repeats;

	private List<int> m_allColors;

	private HashSet<int> m_removedColors;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool CanCellSeeEntireOtherColor(Vector2Int viewerCell, int subjectColor)
	{
		return false;
	}

	private void CollectInfo(GridState gridState, List<Vector2Int> viewerCells, int subjectColor, HintsManager.HintResult result)
	{
	}

	public override void AutoDoAction(Action finishCallback)
	{
	}
}
