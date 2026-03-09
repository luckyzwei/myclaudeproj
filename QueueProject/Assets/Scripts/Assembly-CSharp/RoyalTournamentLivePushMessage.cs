public class RoyalTournamentLivePushMessage : BasePushMessage
{
	private const string ID = "0006";

	private const float DELAY = 3f;

	public override string GetPushMessageID()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void ReCheck()
	{
	}
}
