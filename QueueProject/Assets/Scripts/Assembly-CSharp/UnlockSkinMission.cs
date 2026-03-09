public class UnlockSkinMission : BaseMission
{
	public override void StartTracking()
	{
	}

	public override void StopTracking()
	{
	}

	public override bool IsEligible()
	{
		return false;
	}

	private void OnSkinPurchased(string text)
	{
	}
}
