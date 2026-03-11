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
		m_queensCount = 0;
		base.Play();

		GameplayEvents.HoldCancelled += OnHoldCancelled;
		if (m_grid != null)
			m_grid.CrossMarked += OnCrossMarked;
	}

	private void OnCrossMarked(int index)
	{
		// Cross marked in scheme C - may need to replay instructions
	}

	private void OnHoldCancelled()
	{
		if (m_cancelHoldPlayable != null)
		{
			if (m_refreshCancelPlayable)
				m_cancelHoldPlayable.Stop();
			m_cancelHoldPlayable.Play();
		}

		if (m_stopMainPlayableIfCancel && m_mainPlayable != null)
			m_mainPlayable.Stop();
	}

	protected override void Finished()
	{
		GameplayEvents.HoldCancelled -= OnHoldCancelled;
		if (m_grid != null)
			m_grid.CrossMarked -= OnCrossMarked;
		base.Finished();
	}
}
