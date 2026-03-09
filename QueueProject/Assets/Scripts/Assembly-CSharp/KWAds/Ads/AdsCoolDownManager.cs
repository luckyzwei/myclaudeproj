namespace KWAds.Ads
{
	public class AdsCoolDownManager
	{
		private readonly FixedAdsCoolDownSystem m_fixedAdsCoolDownSystem;

		private readonly MetricAdaptiveAdsCoolDownSystem m_metricAdaptiveAdsCoolDownSystem;

		private IAdsCoolDownSystem m_coolDownSystem;

		public bool CanShowInterstitialAtLocation(string location, bool isConsecutiveAd, out string rejectionCause, out bool canShowAdBreakPopup, double impressionRevenue = 0.0, bool isProviderNoFill = false, bool skipCoolDown = false, bool isCrossAdCall = false)
		{
			rejectionCause = null;
			canShowAdBreakPopup = default(bool);
			return false;
		}

		private void SelectBakedCoolDownSystem()
		{
		}

		private void SelectLiveCooldownSystem()
		{
		}
	}
}
