using UnityEngine;

public class AddQueenSchemeCFtueAction : AddQueenFtueAction
{
	[SerializeField]
	private PlayableDirectorHelper m_cancelHoldPlayable;

	[SerializeField]
	private bool m_refreshCancelPlayable;

	[SerializeField]
	private bool m_stopMainPlayableIfCancel;

	[SerializeField]
	private PlayableDirectorHelper m_mainPlayable;

	private int m_queensCount;

	public override void Play()
	{
	}

	private void OnCrossMarked(int index)
	{
	}

	private void OnHoldCancelled()
	{
	}

	protected override void Finished()
	{
	}
}
