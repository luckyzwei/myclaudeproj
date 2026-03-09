using KWAds;

public class WatchOptionalAdMission : BaseMission
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

	private void OnAdFinished(AdType adType)
	{
	}
}
