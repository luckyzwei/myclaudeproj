using System;
using UnityEngine;

public class ShopUnlockComponent : FeatureUnlockComponent
{
	[SerializeField]
	private int m_shopTabIndex;

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
