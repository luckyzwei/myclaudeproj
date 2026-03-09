using System.Collections.Generic;
using KWAds.Ads;
using KWGameSettings;

namespace KWCore.Facebook
{
	public class FacebookEventsManager
	{
		private const string PLACEHOLDER = "{0}";

		private double m_totalAdRevenue;

		private int m_lastAdRevenueEventFired;

		private int m_lastTotalRevenueEventFired;

		private List<string> m_completedEvents;

		private void OnMediatorRevenuePaidEvent(CoreMediatorImpressionData impression)
		{
		}

		private void VerifyAndSendAdRevenueEvent()
		{
		}

		private void OnCombinedRevenuePaidEvent(float totalRevenue)
		{
		}

		private void SendFacebookEvent(string eventName, int? valueToSum = null, Dictionary<string, object> parameters = null)
		{
		}

		private bool ShouldSendEvent(string eventName)
		{
			return false;
		}

		private FacebookCustomEventSettings[] GetCustomEventSettings()
		{
			return null;
		}

		private int[] GetEventValuesByEventName(string eventName)
		{
			return null;
		}
	}
}
