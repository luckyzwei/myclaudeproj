using System;

namespace KWAds.Ads
{
	public class AdImpressionEvents
	{
		public static Action<CoreMediatorImpressionData> OnAdRevenuePaidEvent;

		public static void SendRevenuePaidEvent(CoreMediatorImpressionData coreMediatorImpressionData)
		{
		}
	}
}
