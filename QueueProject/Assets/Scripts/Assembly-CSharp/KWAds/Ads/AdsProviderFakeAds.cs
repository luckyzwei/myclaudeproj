using System;
using KWAnalytics.Analytics;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdsProviderFakeAds : AdsProviderBase
	{
		private const long JSON_MAX_CHARACTER_COUNT = 4000L;

		public const string PROVIDER_NAME = "FakeAds";

		private const float BANNER_HEIGHT_DP = 50f;

		private const float STANDARD_SCREEN_DPI = 160f;

		private bool m_initialised;

		private FAInterstitialProvider m_interstitialsProvider;

		private FARewardVideoProvider m_rewardVideosProvider;

		private FABannerProvider m_bannersProvider;

		private FANativeProvider m_nativeProvider;

		public FAImpressionDataWrapper PendingIntImpressionData => null;

		public FAImpressionDataWrapper PendingRVImpressionData => null;

		public FAImpressionDataWrapper PendingBannerImpressionData => null;

		public FAImpressionDataWrapper PendingNativeImpressionData => null;

		protected override bool Initialized => false;

		public override string GetProviderName()
		{
			return null;
		}

		public override float GetBannerHeight()
		{
			return 0f;
		}

		public override void Init(GameObject parentObject)
		{
		}

		private void OnSDKInitialised()
		{
		}

		public override void OnApplicationPause(bool isPaused)
		{
		}

		public override void ClearInterstitial()
		{
		}

		public override void SetBannersVisible(bool visible)
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

		public override bool IsInterstitialReady()
		{
			return false;
		}

		public override void ShowInterstitial(string location, Action adShowCalledCallback = null)
		{
		}

		public override bool IsRewardedVideoAvailable(string location = null)
		{
			return false;
		}

		public override void ShowRewardedVideo(string location, Action adShowCalledCallback = null)
		{
		}

		public override void LoadBanner()
		{
		}

		public override void DestroyBanner()
		{
		}

		public override void LoadNativeAd()
		{
		}

		public override void ShowNativeAd<T>(string location, T nativeObject, Action adShowCalledCallback = null)
		{
		}

		public override void DestroyNative()
		{
		}

		public override bool IsForcedOverMediators()
		{
			return false;
		}

		public override int GetWaterfallIndex()
		{
			return 0;
		}

		private CoreMediatorImpressionData GetCoreImpressionData(FAImpressionDataWrapper dataWrapper, AdFormat format)
		{
			return null;
		}

		private string ReturnAllCompetitorsAuctionResultJson(FAImpressionDataWrapper impressionData)
		{
			return null;
		}

		private long GetMediatorJsonMaxCount()
		{
			return 0L;
		}

		public void SendCustomImpressionData<T>(FAImpressionDataWrapper impressionData, string type, bool sendInstantly = false) where T : AdImpressionUnifiedSchema
		{
		}
	}
}
