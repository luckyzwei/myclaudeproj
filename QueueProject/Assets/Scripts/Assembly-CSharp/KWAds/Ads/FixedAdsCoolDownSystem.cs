using System.Collections.Generic;

namespace KWAds.Ads
{
	public class FixedAdsCoolDownSystem : IAdsCoolDownSystem
	{
		private long m_timeSinceLastRewardAd;

		private long m_timeSinceLastInterstitial;

		private Dictionary<string, long> m_timeSinceLastInterstitialAtLocation;

		private int m_levelsSinceLastRewardAd;

		private int m_levelsSinceLastInterstitial;

		private Dictionary<string, int> m_levelsSinceLastInterstitialAtLocation;

		private int m_intsPlayed;

		public void Dispose()
		{
		}

		private long GetInterstitialGlobalCoolDown()
		{
			return 0L;
		}

		private long GetInterstitialGlobalCoolDownByLevel()
		{
			return 0L;
		}

		private bool IsIntCoolDownOver(bool isConsecutiveAd, out string rejectionCause)
		{
			rejectionCause = null;
			return false;
		}

		public bool CheckIntLocationAndCoolDown(string location, out bool canShowAdBreakPopup, out string rejectionCause, bool isConsecutiveAd, double impressionRevenue = 0.0, bool isProviderNoFill = false, bool skipCooldown = false, bool isCrossAdCall = false)
		{
			canShowAdBreakPopup = default(bool);
			rejectionCause = null;
			return false;
		}

		private void UpdateLastInterstialAdTime(string location)
		{
		}

		private void UpdateLastRewardAdTime(string location)
		{
		}
	}
}
