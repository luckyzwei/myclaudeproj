public class CompleteTimedLevelMission : BaseMission
{
	private int m_firstTimedLevel;

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

	private int FindFirstTimedLevel()
	{
		return 0;
	}

	private void OnLevelSolved()
	{
	}
}
