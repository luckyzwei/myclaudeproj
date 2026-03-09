using System;
using System.Collections;
using System.Collections.Generic;
using KWAnalytics.Analytics;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdsProviderMAX : AdsProviderBase
	{
		public const string PROVIDER_NAME = "MAX";

		private const long JSON_MAX_CHARACTER_COUNT = 4000L;

		private const int BANNER_HEIGHT_DP = 65;

		private const float STANDARD_SCREEN_DPI = 160f;

		private const float LONG_SCREEN_DEVICES_HEIGHT_DP = 110f;

		private const float FALLBACK_SCREEN_DPI = 475f;

		private bool m_isInitialised;

		private bool m_initCompleted;

		private MAXInterstitialsProvider m_interstitialsProvider;

		private MAXRewardVideosProvider m_rewardVideosProvider;

		private MAXBannersProvider m_bannersProvider;

		public MAXImpressionDataWrapper CurrentBannerImpressionData => null;

		public MAXImpressionDataWrapper PendingIntImpressionData => null;

		public MAXImpressionDataWrapper PendingRVImpressionData => null;

		public MAXImpressionDataWrapper CurrentIntImpressionData => null;

		public MAXImpressionDataWrapper CurrentRVImpressionData => null;

		protected override bool Initialized => false;

		public static void CanUseProvider(Action<bool> canUseCallback)
		{
		}

		public override string GetProviderName()
		{
			return null;
		}

		public override void Init(GameObject parentObject)
		{
		}

		public override void ClearInterstitial()
		{
		}

		private void OnSDKInitialised(MaxSdkBase.SdkConfiguration sdkConfiguration)
		{
		}

		private void AmazonInitialize()
		{
		}

		public override void OnApplicationPause(bool isPaused)
		{
		}

		public override void SetConsent(bool consented = false)
		{
		}

		public override bool IsInterstitialReady()
		{
			return false;
		}

		public override bool IsRewardedVideoAvailable(string location = null)
		{
			return false;
		}

		public override void SetBannersVisible(bool visible)
		{
		}

		public override void ShowInterstitial(string location, Action adShowCalledCallback = null)
		{
		}

		public override void ShowRewardedVideo(string location, Action adShowCalledCallback = null)
		{
		}

		public override void SetBannerPosition(AdSystemBanners.BannerPosition pos)
		{
		}

		public override void LoadBanner()
		{
		}

		public override void DestroyBanner()
		{
		}

		public override Hashtable GetWaterfallStatusData()
		{
			return null;
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

		public override float GetBannerHeight()
		{
			return 0f;
		}

		private Hashtable WaterFallStatusFromListToHashTable(List<MaxWaterfallStatusData> waterfallInfoList)
		{
			return null;
		}

		private Hashtable GetWaterfallTable(MaxWaterfallStatusData waterfall)
		{
			return null;
		}

		public override int GetWaterfallIndex()
		{
			return 0;
		}

		public void SendCustomImpressionData<T>(MAXImpressionDataWrapper impressionData, string type, bool sendInstantly = false) where T : AdImpressionUnifiedSchema
		{
		}

		private string ReturnAllCompetitorsAuctionResultJson(MAXImpressionDataWrapper impressionData)
		{
			return null;
		}

		private long GetMediatorJsonMaxCount()
		{
			return 0L;
		}

		private string GetAdFormatStandard(string adFormat)
		{
			return null;
		}
	}
}
