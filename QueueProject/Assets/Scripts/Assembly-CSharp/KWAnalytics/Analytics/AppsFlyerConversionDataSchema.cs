using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class AppsFlyerConversionDataSchema : ClosedSchema
	{
		public AppsFlyerConversionDataSchema(string mediaSource, long? installTime, long? clickTime, string afStatus, string afSiteId, string adGroupId, string adSet, string adSetId, string campaign, string campaignId)
		{
		}
	}
}
