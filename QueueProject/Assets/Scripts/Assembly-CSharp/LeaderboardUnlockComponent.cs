using System;
using UnityEngine;

public class LeaderboardUnlockComponent : FeatureUnlockComponent
{
	[SerializeField]
	private int m_leaderboardTabIndex;

	public override int GetPriority()
	{
		return 0;
	}

	protected override int UnlockLevel()
	{
		return 0;
	}

	protected override bool IsFeatureUnlocked()
	{
		return false;
	}

	protected override void SetFeatureUnlocked()
	{
	}

	public override void ShowFeatureUnlockPopup(Action onFeatureUnlockComplete)
	{
	}
}
