using System;

public class RoyalTournamentLeaderboardDisplayer : IQueueableEntity
{
	private Action m_destroyCallback;

	public void StartProcess(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}
}
