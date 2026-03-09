public class DecoramaFeatureUnlockComponent : FeatureUnlockComponent
{
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
}
