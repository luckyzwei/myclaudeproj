using System;

public class JigsawPuzzleFeatureUnlockComponent : FeatureUnlockComponent
{
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
