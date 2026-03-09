using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class AdImpressionUnifiedSchema : ClosedSchema
	{
		public AdImpressionUnifiedSchema(string type, string mediatorName, string adUnitID, string adUnitName, string adUnitFormat, string appAdLocation, double? bid, double? competitorBestBid, string competitorBestMediatorName, string allCompetitorsAuctionResultJson, string networkName, string networkPlacementID, string adUniqueId, string creativeId, long? loadTime, string abGroup, string segmentName, double? lifetimeRevenue, string appAdPlacementFormat)
		{
		}

		private void SetStageStatus()
		{
		}
	}
}
