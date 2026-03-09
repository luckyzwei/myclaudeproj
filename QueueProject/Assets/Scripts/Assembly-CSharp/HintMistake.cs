using UnityEngine;

public class HintMistake : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}
}
