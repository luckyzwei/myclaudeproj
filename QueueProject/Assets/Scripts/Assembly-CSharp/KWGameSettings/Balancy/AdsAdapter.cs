namespace KWGameSettings.Balancy
{
	public class AdsAdapter : Ads
	{
		public override AdsInterstitial Interstitials { get; set; }

		public override AdsRewardAds RewardAds { get; set; }

		public override AdsAppOpen AppOpenAds { get; set; }

		public override AdsBreakPopup BreakPopup { get; set; }

		public override AdsPlacementProviderWaterfall PlacementProviderWaterfall { get; set; }

		public override AdsPlayerAdScore PlayerAdScore { get; set; }

		public override RvInsteadOfInt RvInsteadOfInt { get; set; }

		public override IntInsteadOfRv IntInsteadOfRv { get; set; }

		public override bool EnableMetricAdaptiveAdSystem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override long MediatorJsonMaxCount
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override bool ShiftBannerCloseButtonPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool EnableSegmentedAdsAnalytics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
