using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using KWAnalytics.Analytics;

namespace KWAds.Ads
{
	public class AdMobAppOpenProvider
	{
		private static readonly TimeSpan AD_LIFE_SPAN;

		private readonly AdsProviderAdMob m_adsProvider;

		private string m_adUnitId;

		private OpenAdInfo m_adInfo;

		private DateTime m_adloadTime;

		private string m_currentAdLocation;

		public OpenAdInfo CurrentAdInfo { get; private set; }

		public AdMobAppOpenProvider(AdsProviderAdMob adsProvider)
		{
		}

		~AdMobAppOpenProvider()
		{
		}

		private void UpdateAdIdData()
		{
		}

		private bool IsAppMovedToForeground(AppState appState)
		{
			return false;
		}

		private void OnAppStateChanged(AppState appState)
		{
		}

		public void LoadNewAd()
		{
		}

		public bool TryShowOpenAd(string location)
		{
			return false;
		}

		public bool IsAdExpired()
		{
			return false;
		}

		private OpenAdInfo GetAdInfoFromWaterfall()
		{
			return null;
		}

		private void AddImpressionSchema<T>() where T : AdImpressionUnifiedSchema
		{
		}

		private void HandleAdPaid(AdValue value)
		{
		}

		private void HandleOnDisplay()
		{
		}

		private void HandleOnClosed()
		{
		}

		private void HandleOnAdFailed(AdError adError)
		{
		}

		private void HandleOnAdClick()
		{
		}

		private bool IsAppOpenAvailable()
		{
			return false;
		}
	}
}
