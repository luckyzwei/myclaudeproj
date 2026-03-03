using System.Collections.Generic;

public class TpAppsflyerProp : IAnalytics
{
	private struct AppsFlyerLogReady
	{
		public string eventName;

		public Dictionary<string, string> parameters;
	}

	private List<AppsFlyerLogReady> list_LogReady;

	public void AppsflyerReadyLogComplete()
	{
	}

	public void Event(IngameEventType eventType, string eventName, params object[] args)
	{
	}

	public void EventWithParameter(string eventName, Dictionary<string, string> args = null)
	{
	}

	public void InAppPurchaseEvent(params object[] args)
	{
	}
}
