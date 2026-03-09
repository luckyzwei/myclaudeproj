using GoogleMobileAds.Api;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdsProviderAdMob : AdsProviderBase
	{
		public const string PROVIDER_NAME = "AdMob";

		private bool m_isInitialised;

		private bool m_initCompleted;

		private AdMobAppOpenProvider m_appOpenProvider;

		protected override bool Initialized => false;

		public override string GetProviderName()
		{
			return null;
		}

		public override void Init(GameObject parentObject)
		{
		}

		private void InitAdMob()
		{
		}

		private void OnSDKInitialised(InitializationStatus initializationStatus)
		{
		}

		public override void SetBannersVisible(bool visible)
		{
		}

		public override float GetBannerHeight()
		{
			return 0f;
		}

		public override void ClearInterstitial()
		{
		}

		public override CoreMediatorImpressionData GetCoreInterstitialImpressionData()
		{
			return null;
		}

		public override CoreMediatorImpressionData GetCoreRewardImpressionData()
		{
			return null;
		}

		public override CoreMediatorImpressionData GetCoreBannerImpressionData()
		{
			return null;
		}

		public override CoreMediatorImpressionData GetCoreNativeImpressionData()
		{
			return null;
		}

		public override CoreMediatorImpressionData GetCoreAppOpenImpressionData()
		{
			return null;
		}

		public override void SetCompetitorDataInterstitial(CoreCompetitorImpressionData competitorData)
		{
		}

		public override void SetCompetitorDataRewarded(CoreCompetitorImpressionData competitorData)
		{
		}

		public override void SetCompetitorDataBanner(CoreCompetitorImpressionData competitorData)
		{
		}

		public override void SetCompetitorDataNative(CoreCompetitorImpressionData competitorData)
		{
		}

		public override void SetCompetitorDataAppOpen(CoreCompetitorImpressionData competitorData)
		{
		}

		public override bool TryShowOpenAd(string location)
		{
			return false;
		}
	}
}
