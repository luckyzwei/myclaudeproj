public class ClearAllBoosterButton : BoosterButton
{
	protected override bool TryPerformAction()
	{
		return false;
	}

	public override void OnButtonPressed()
	{
	}

	protected override void ConfigureVisuals()
	{
	}

	public override void PlayAlertAnimation()
	{
	}
}
