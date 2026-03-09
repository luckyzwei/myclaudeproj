using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsAdapter : Ads
	{
		[SerializeField]
		private AdsInterstitialAdapter interstitial;

		[SerializeField]
		private AdsRewardAdsAdapter rewardAds;

		[SerializeField]
		private AdsBreakPopupAdapter adsBreakPopup;

		[SerializeField]
		private AdsPlacementProviderWaterfallAdapter placementProviderWaterfall;

		[SerializeField]
		private AdsPlayerAdScoreAdapter playerAdScore;

		[SerializeField]
		private AdsAppOpenAdapter appOpenAds;

		[SerializeField]
		private RvInsteadOfIntAdapter rvInsteadOfInt;

		[SerializeField]
		private IntInsteadOfRvAdapter intInsteadOfRv;

		[SerializeField]
		private bool enableMetricAdaptiveAdSystem;

		[SerializeField]
		private long mediatorJsonMaxCount;

		[SerializeField]
		private bool shiftBannerCloseButtonPosition;

		[SerializeField]
		private bool enableSegmentedAdsAnalytics;

		public override AdsInterstitial Interstitials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsAppOpen AppOpenAds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsRewardAds RewardAds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsBreakPopup BreakPopup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsPlacementProviderWaterfall PlacementProviderWaterfall
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsPlayerAdScore PlayerAdScore
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override RvInsteadOfInt RvInsteadOfInt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IntInsteadOfRv IntInsteadOfRv
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
