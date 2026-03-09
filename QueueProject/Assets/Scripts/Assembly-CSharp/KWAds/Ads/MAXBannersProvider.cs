using System.Collections.Generic;
using MAX.AmazonAds;

namespace KWAds.Ads
{
	public class MAXBannersProvider
	{
		private readonly AdsProviderMAX m_adsProvider;

		private MaxWaterfallStatusData[] m_waterfallData;

		private readonly List<MaxWaterfallStatusData> m_waterfallHistory;

		private MaxSdkBase.BannerPosition m_bannerPosition;

		private APSBannerAdRequest m_amazonBannerAdRequest;

		private int m_currentWaterfall;

		private bool m_bannerHasBeenDestroyed;

		private bool m_isFullScreenAdShowing;

		private bool m_isBannerShownPreviously;

		public int BestWaterfallIndex { get; private set; }

		public MAXImpressionDataWrapper CurrentImpressionData { get; private set; }

		public MAXBannersProvider(AdsProviderMAX adsProvider)
		{
		}

		private void HandleFullScreenAdFinishedEvent(AdType adType)
		{
		}

		private void HandleFullScreenAdStartedEvent(string providerName)
		{
		}

		private void InitialiseBanners()
		{
		}

		private (int, int) GetBannerDimensions()
		{
			return default((int, int));
		}

		private void CreateMaxBannerAd(string unitId, MaxSdkBase.BannerPosition bannerPosition)
		{
		}

		public void SetBannersVisible(bool visible)
		{
		}

		public void ShowAds()
		{
		}

		public void StopAds()
		{
		}

		public void SetBannerPosition(AdSystemBanners.BannerPosition pos)
		{
		}

		private void OnGameSettingsUpdated()
		{
		}

		private void UpdateWaterfallData()
		{
		}

		private void UpdateBestWaterfallIndex()
		{
		}

		public List<MaxWaterfallStatusData> GetWaterfallStatus()
		{
			return null;
		}

		private List<MaxWaterfallStatusData> GetWaterfallHistory()
		{
			return null;
		}

		private string GetAmazonBannerSlotId()
		{
			return null;
		}

		private void OnBannerLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnBannerClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}
	}
}
