namespace KWAds.Ads
{
	public class AppOpenAdImpressionData
	{
		public string AdUnitIdentifier { get; private set; }

		public AdFormat? AdFormat { get; private set; }

		public string AdFormatStandard { get; private set; }

		public string AdFormatFromProvider { get; private set; }

		public double? Revenue { get; private set; }

		public string Currency { get; private set; }

		public string MediatorName { get; private set; }

		public string AdNetworkName { get; private set; }

		public string AdNetworkPlacementID { get; private set; }

		public string ResponseID { get; private set; }

		public AppOpenAdImpressionData()
		{
		}

		public AppOpenAdImpressionData(string adUnitIdentifier, AdFormat? adFormat, string adFormatStandard, string adFormatFromProvider, double? revenue, string currency, string mediatorName, string adNetworkName, string networkPlacementID, string responseID)
		{
		}
	}
}
