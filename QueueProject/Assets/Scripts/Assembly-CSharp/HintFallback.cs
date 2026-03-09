using System.Collections.Generic;
using UnityEngine;

public class HintFallback : BaseHint
{
	private const int HINT_CELLS_COUNT = 3;

	[SerializeField]
	private string m_textKey;

	private List<int> m_candiateCells;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}
}
