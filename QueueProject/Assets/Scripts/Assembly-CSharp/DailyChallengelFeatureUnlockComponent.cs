using System;
using KWCore.UI;
using UnityEngine;

public class DailyChallengelFeatureUnlockComponent : FeatureUnlockComponent
{
	[SerializeField]
	private string m_dailydhallengeID;

	[SerializeField]
	private QueensDailyChallenge m_queensDailyChallenge;

	[SerializeField]
	private DailyChallengeWidget m_widget;

	private Action m_callback;

	protected override int UnlockLevel()
	{
		return 0;
	}

	public override int GetPriority()
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

	private void OnPopupClosed(PopUpBase obj)
	{
	}
}
