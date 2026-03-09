using KWAnalytics.Analytics;
using UnityEngine;

public class ShopAnalytics : MonoBehaviour
{
	private const string START_EVENT_NAME = "store_start";

	private const string END_EVENT_NAME = "store_end";

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SendShopStartedEvent()
	{
	}

	public void SendShopEndEvent()
	{
	}

	private void SendBasicShopEvent(string eventName)
	{
	}

	private void ApplyLongString(ref GenericEvent genericEvent)
	{
	}
}
