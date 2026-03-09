using System;
using System.Collections.Generic;
using KWAds.Interface;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdsManager : MonoBehaviour
	{
		public enum VideoResult
		{
			Failed = 0,
			FailedNoInternet = 1,
			Skipped = 2,
			Finished = 3
		}

		private const string EVENTS_QUEUE_ID = "AdsManager.InitialiseAdSystems";

		private readonly List<AdsProviderBase> m_providersToUse;

		private AdsInterface m_adsInterface;

		private AdSystemOpen m_openSystem;

		private AdSystemInterstitials m_intsSystem;

		private AdSystemRewardVideos m_rvsSystem;

		private AdSystemBanners m_bannersSystem;

		private List<AdSystemBase> m_adSystems;

		private AdSystemNative m_nativeSystem;

		private AdsProviderChecker m_providerChecker;

		public void Initialise(AdsInterface adsInterface)
		{
		}

		private void CreateAdSystems()
		{
		}

		private void SendActiveMediatorsAnalyticsEvent()
		{
		}

		private void InitialiseAdSystems()
		{
		}

		public void CoreInitialisationCompleted()
		{
		}

		public List<AdsProviderBase> GetProvidersInProject()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void DoOnApplicationPause(bool isPaused)
		{
		}

		public bool CanShowInterstitial(string location, bool skipCoolDown = false)
		{
			return false;
		}

		public void TryToShowInterstitial(string location, Action onFinish = null, bool skipCoolDown = false)
		{
		}

		public void ShowAppOpenAd(string location, Action onFinish)
		{
		}

		public void ShowRewardAdAd(string location, Action<VideoResult> onFinish)
		{
		}

		public void SetBannersVisible(bool visible)
		{
		}

		public void SetBannersBackgroundVisible(bool visible)
		{
		}

		public void EnableBannerAds(bool enabled)
		{
		}

		public bool GetBannerAdsEnabled()
		{
			return false;
		}

		public float GetBannersHeight()
		{
			return 0f;
		}

		public void ShowNativeAd<T>(string location, T nativeObject, Action onAdShowCompleted = null)
		{
		}

		public void SetBannerSizeToRegular()
		{
		}

		public void SetBannerSizeToRectangular()
		{
		}

		public void SetBannerSize(AdSystemBanners.BannerSize size)
		{
		}

		public void SetBannerPosition(AdSystemBanners.BannerPosition pos)
		{
		}

		public void SetBannerBackgroundColor(Color color)
		{
		}

		private List<AdsProviderBase> GetAdSystemProviders(AdSystemBase adSystem)
		{
			return null;
		}

		private void SetAvailableProviders(AdSystemBase adSystem, List<AdsProviderBase> providers)
		{
		}

		private void AddProvidersToUse(AdsProviderBase provider)
		{
		}

		private bool CheckIfProviderNamesMatch(string providerName)
		{
			return false;
		}

		private void ConfigureAdsEnabled()
		{
		}

		private void SetAdsEnabled(bool enabled)
		{
		}

		private void SetConsent(bool canTrack)
		{
		}

		private void HandleProductsStateUpdated()
		{
		}
	}
}
