public class StreakStartedPushMessage : BasePushMessage
{
	private const string ID = "0007";

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

	private void OnWinStreakIncreased(int days, bool isNewRecord)
	{
	}

	public override void ReCheck()
	{
	}
}
