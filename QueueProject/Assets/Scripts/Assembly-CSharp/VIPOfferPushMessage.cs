public class VIPOfferPushMessage : BasePushMessage
{
	private const string ID = "0002";

	public override string GetPushMessageID()
	{
		return null;
	}

	protected void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void ReCheck()
	{
	}

	private void OnDiscountStarted()
	{
	}

	private void OnVipChecked(int times)
	{
	}
}
