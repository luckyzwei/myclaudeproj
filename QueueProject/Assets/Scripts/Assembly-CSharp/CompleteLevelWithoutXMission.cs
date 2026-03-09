public class CompleteLevelWithoutXMission : BaseMission
{
	private bool m_anyXUsedThisLevel;

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

	private void OnLevelStarted()
	{
	}

	private void OnXPlaced(int obj)
	{
	}

	private void OnLevelCompleted()
	{
	}
}
