using System;

namespace KWAds.Ads
{
	[Serializable]
	public class CoreMediatorImpressionData
	{
		public string AdUnitIdentifier { get; private set; }

		public string AdRequestUnitIdentifier { get; private set; }

		public AdFormat? AdFormat { get; private set; }

		public string AdFormatStandard { get; private set; }

		public string AdFormatFromProvider { get; private set; }

		public double? Revenue { get; private set; }

		public string JsonRepresentation { get; private set; }

		public string MediatorName { get; private set; }

		public string AdNetworkName { get; private set; }

		public string AdNetworkPlacementID { get; private set; }

		public string AdSegmentName { get; private set; }

		public string AdCreativeId { get; private set; }

		public string AdAuctionType { get; private set; }

		public string AppAdPlacementFormat { get; private set; }

		public CoreMediatorImpressionData(string adUnitIdentifier, string adRequestUnitIdentifier, AdFormat? adFormat, string adFormatStandard, string adFormatFromProvider, double? revenue, string jsonRepresentation, string mediatorName, string adNetworkName, string networkPlacementID, string segmentName, string adCreativeId, string adAuctionType)
		{
		}

		public void SetAppAdPlacementFormat(string appAdPlacementFormat)
		{
		}
	}
}
