namespace KWAds.Ads
{
	public class CoreCompetitorImpressionData
	{
		public double? CompetitorBestBid { get; private set; }

		public string CompetitorName { get; private set; }

		public string AllCompetitorsAuctionResultJson { get; private set; }

		public CoreCompetitorImpressionData(double? competitorBestBid, string competitorName, string allCompetitorsAuctionResultJson)
		{
		}
	}
}
