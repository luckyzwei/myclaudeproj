using System;
using UnityEngine;

public class QueensEventEndedComponent : FeatureUnlockComponent
{
	[SerializeField]
	private string m_location;

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
}
