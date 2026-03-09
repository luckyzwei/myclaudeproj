public class NextJigsawRewardPushMessage : BasePushMessage
{
	private const string ID = "0004";

	private int m_remainingSeconds;

	public override string GetPushMessageID()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void ReCheck()
	{
	}

	private void OnHomeScreenLoaded()
	{
	}

	private void OnJigsawPieceDistributed()
	{
	}

	private int HowManyPiecesNeededForNextJigsaw()
	{
		return 0;
	}
}
