using KWGameSettings;

namespace KWAds.Ads
{
	public class MetricAdaptiveAdsCoolDownSystem : IAdsCoolDownSystem
	{
		private int m_numIntLocationsReached;

		public void Dispose()
		{
		}

		public bool CheckIntLocationAndCoolDown(string location, out bool canShowAdBreakPopup, out string rejectionCause, bool isConsecutiveAd, double impressionRevenue = 0.0, bool isProviderNoFill = false, bool skipCooldown = false, bool isCrossAdCall = false)
		{
			canShowAdBreakPopup = default(bool);
			rejectionCause = null;
			return false;
		}

		private AdsInterstitialLocation GetInterstitialLocation(string location)
		{
			return null;
		}

		private bool IsPlayerAdScoreAboveThreshold(double playerAdScore, float[] impressionsThreshold, float[] noFillImpressionsThreshold, float noFillThresholdScaleFactor, bool isProviderNoFill, string adLocation)
		{
			return false;
		}

		private void SetIntImpressionsDataToBucket(CoreMediatorImpressionData impressionData)
		{
		}
	}
}
