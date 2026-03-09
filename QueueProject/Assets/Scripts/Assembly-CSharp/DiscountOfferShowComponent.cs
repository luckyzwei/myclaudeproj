using System;

public class DiscountOfferShowComponent : FeatureUnlockComponent
{
	private string m_source;

	private bool m_tap;

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
