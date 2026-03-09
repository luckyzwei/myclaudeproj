using GoogleMobileAds.Api;

namespace KWAds.Ads
{
	public class OpenAdInfo
	{
		private string m_unitID;

		private AppOpenAd m_ad;

		public double Revenue { get; set; }

		public AdValue.PrecisionType Precision { get; set; }

		public string Currency { get; set; }

		public OpenAdInfo(AppOpenAd ad, string unitID = "")
		{
		}

		public AppOpenAd GetOpenAd()
		{
			return null;
		}

		public string GetResponseID()
		{
			return null;
		}

		public string GetAdInfo()
		{
			return null;
		}

		public string GetAdNetwork()
		{
			return null;
		}

		public double GetPreciseRevenue()
		{
			return 0.0;
		}

		public string GetPrecisionType()
		{
			return null;
		}

		public string GetAdPlacementID()
		{
			return null;
		}

		public string GetJsonRepresentation()
		{
			return null;
		}
	}
}
