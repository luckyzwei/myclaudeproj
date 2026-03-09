using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Ads
	{
		public abstract AdsInterstitial Interstitials { get; set; }

		public abstract AdsAppOpen AppOpenAds { get; set; }

		public abstract AdsRewardAds RewardAds { get; set; }

		public abstract AdsBreakPopup BreakPopup { get; set; }

		public abstract AdsPlacementProviderWaterfall PlacementProviderWaterfall { get; set; }

		public abstract AdsPlayerAdScore PlayerAdScore { get; set; }

		public abstract RvInsteadOfInt RvInsteadOfInt { get; set; }

		public abstract IntInsteadOfRv IntInsteadOfRv { get; set; }

		public abstract bool EnableMetricAdaptiveAdSystem { get; set; }

		public abstract long MediatorJsonMaxCount { get; set; }

		public abstract bool ShiftBannerCloseButtonPosition { get; set; }

		public abstract bool EnableSegmentedAdsAnalytics { get; set; }
	}
}
