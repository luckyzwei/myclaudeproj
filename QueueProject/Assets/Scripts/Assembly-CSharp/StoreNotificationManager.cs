using Balancy.Data.SmartObjects;
using KWCore.Utils;

public class StoreNotificationManager : Singleton<StoreNotificationManager>
{
	public static string STORE_NOTIFICATION_ID;

	protected override void Init()
	{
	}

	private void OnNewOfferActivatedEvent(OfferInfo obj)
	{
	}

	private void OnOfferDeactivatedEvent(OfferInfo obj, bool wasPurchased)
	{
	}

	public static void CheckForShopNotifications()
	{
	}
}
