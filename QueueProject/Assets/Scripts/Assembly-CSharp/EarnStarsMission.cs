public class EarnStarsMission : BaseMission
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

	private void OnLeaderboardScoreAdded(int count)
	{
	}
}
