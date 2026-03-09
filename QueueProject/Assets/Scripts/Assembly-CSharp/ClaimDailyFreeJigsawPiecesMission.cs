public class ClaimDailyFreeJigsawPiecesMission : BaseMission
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

	private void OnFreeJigsawPiecesCollected(int tier)
	{
	}

	protected virtual bool DoesTierMatch(int tier)
	{
		return false;
	}
}
