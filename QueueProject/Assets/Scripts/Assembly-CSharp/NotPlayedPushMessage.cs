public class NotPlayedPushMessage : BasePushMessage
{
	private const string ID = "0003";

	private const float DELAY = 3f;

	public override string GetPushMessageID()
	{
		return null;
	}

	private void Start()
	{
	}

	public override void ReCheck()
	{
	}

	private void RefreshPushMessage()
	{
	}
}
