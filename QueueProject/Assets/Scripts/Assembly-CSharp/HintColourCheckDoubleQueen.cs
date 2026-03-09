using System.Collections.Generic;
using UnityEngine;

public class HintColourCheckDoubleQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	[SerializeField]
	private string m_textKeyOtherColors;

	private Dictionary<int, int> m_colorWithOpenCells;

	private HashSet<int> m_colorsWithQueen;

	private int m_color;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private int CountUnmarkedCellsInColor(GridState gridState, int wantedColor)
	{
		return 0;
	}

	private void CollectInfo(GridState gridState, HintsManager.HintResult result)
	{
	}
}
