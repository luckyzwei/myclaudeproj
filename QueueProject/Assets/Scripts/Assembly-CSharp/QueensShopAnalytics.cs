using KWAnalytics.Analytics;
using UnityEngine;

public class QueensShopAnalytics : MonoBehaviour
{
	private const string START_EVENT_NAME = "store_start";

	private const string END_EVENT_NAME = "store_end";

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SendShopEndEvent()
	{
	}

	private void SendBasicShopEvent(string eventName)
	{
	}

	public void SendShopStartEvent(string source, string reason)
	{
	}

	private void ApplyLongString(ref GenericEvent genericEvent)
	{
	}
}
