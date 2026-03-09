using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KWAds.Ads
{
	public abstract class AdsProviderBase
	{
		private bool m_providingInt;

		private bool m_providingBanner;

		private bool m_providingRV;

		private bool m_providingNative;

		private bool m_providingAppOpen;

		protected abstract bool Initialized { get; }

		public static event Action<AdsProviderBase> OnInterstitialAdReadyEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AdsProviderBase, string, string> OnInterstitialAdLoadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AdsProviderBase, string, int, string> OnInterstitialAdLoadFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnInterstitialAdShowSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnInterstitialAdShowFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnInterstitialAdClickedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<CoreAdImpressionData> OnInterstitialAdStartedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnInterstitialAdFinishedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnInterstitialAdPaidEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerAdLoadedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string, int, string> OnBannerAdLoadFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerAdClickedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerAdScreenPresentedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerAdScreenDismissedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerAdLeftApplicationEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AdsProviderBase, string, string> OnRewardedAdLoadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AdsProviderBase> OnRewardedVideoAdLoadedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<AdsProviderBase, string, int, string> OnRewardedAdLoadFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<CoreAdImpressionData> OnRewardedVideoAdStartedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnRewardedVideoAdRewardedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, string> OnRewardedVideoAdShowFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnRewardedVideoAdClickedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnRewardedVideoAdSkippedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnRewardedAdPaidEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnNativeAdLoadedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnNativeAdLoadFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnNativeAdShowSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnNativeAdClickedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnNativeAdStartedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> OnNativeAdFinishedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAppOpenClosedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAppOpenDisplayEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string, int> OnAppOpenFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAppOpenClickedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAppOpenLoadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnAppOpenRequestedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static List<AdsProviderBase> GetAllProjectProviders()
		{
			return null;
		}

		public static bool DoProvidersNamesMatch(AdsProviderBase firstProvider, AdsProviderBase secondProvider)
		{
			return false;
		}

		public bool IsInitialized()
		{
			return false;
		}

		protected bool IsProvidingInterstitials()
		{
			return false;
		}

		protected bool IsProvidingRewardVideo()
		{
			return false;
		}

		protected bool IsProvidingBanner()
		{
			return false;
		}

		protected bool IsProvidingNative()
		{
			return false;
		}

		protected bool IsProvidingAppOpen()
		{
			return false;
		}

		public virtual void Init(GameObject parentObject)
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual bool IsForcedOverMediators()
		{
			return false;
		}

		public virtual int GetWaterfallIndex()
		{
			return 0;
		}

		public virtual bool IsInterstitialReady()
		{
			return false;
		}

		public virtual bool IsNativeReady()
		{
			return false;
		}

		public virtual void DealInterstial()
		{
		}

		public virtual void DealRewards()
		{
		}

		public virtual void DealBanners()
		{
		}

		public virtual void DealNatives()
		{
		}

		public virtual void DealAppOpen()
		{
		}

		public virtual void ShowInterstitial(string location, Action adShowCalledCallback = null)
		{
		}

		public virtual bool IsInterstitialPlacementCapped(string location)
		{
			return false;
		}

		public virtual bool IsRewardedVideoAvailable(string location)
		{
			return false;
		}

		public virtual void ShowRewardedVideo(string location, Action adShowCalledCallback = null)
		{
		}

		public virtual void OnApplicationPause(bool isPaused)
		{
		}

		public virtual void Update(float time)
		{
		}

		public virtual void LoadBanner()
		{
		}

		public virtual void SetBannerPosition(AdSystemBanners.BannerPosition pos)
		{
		}

		public virtual void SetBannerSize(AdSystemBanners.BannerSize size)
		{
		}

		public virtual void SetBannerBackgroundColor(Color color)
		{
		}

		public virtual void DestroyBanner()
		{
		}

		public virtual void SetConsent(bool consented)
		{
		}

		public virtual void LoadNativeAd()
		{
		}

		public virtual void ShowNativeAd<T>(string location, T nativeObject, Action adShowCalledCallback = null)
		{
		}

		public virtual void DestroyNative()
		{
		}

		public virtual bool IsNativeAdAvailable(string location)
		{
			return false;
		}

		public virtual Hashtable GetWaterfallStatusData()
		{
			return null;
		}

		public virtual bool TryShowOpenAd(string location)
		{
			return false;
		}

		public abstract void SetBannersVisible(bool visible);

		public abstract string GetProviderName();

		public abstract float GetBannerHeight();

		public abstract void ClearInterstitial();

		public abstract CoreMediatorImpressionData GetCoreInterstitialImpressionData();

		public abstract CoreMediatorImpressionData GetCoreRewardImpressionData();

		public abstract CoreMediatorImpressionData GetCoreBannerImpressionData();

		public abstract CoreMediatorImpressionData GetCoreNativeImpressionData();

		public abstract CoreMediatorImpressionData GetCoreAppOpenImpressionData();

		public abstract void SetCompetitorDataInterstitial(CoreCompetitorImpressionData competitorData);

		public abstract void SetCompetitorDataRewarded(CoreCompetitorImpressionData competitorData);

		public abstract void SetCompetitorDataBanner(CoreCompetitorImpressionData competitorData);

		public abstract void SetCompetitorDataNative(CoreCompetitorImpressionData competitorData);

		public abstract void SetCompetitorDataAppOpen(CoreCompetitorImpressionData competitorData);

		public void OnInterstitialAdReady(AdsProviderBase adMediator)
		{
		}

		public void OnInterstitialAdLoad(AdsProviderBase adMediator, string adFormat, string adRequestId)
		{
		}

		public void OnInterstitialAdLoadFailed(AdsProviderBase adMediator, string error, int errorCode, string adRequestId)
		{
		}

		public void OnInterstitialAdShowSucceeded()
		{
		}

		public void OnInterstitialAdShowFailed(string error)
		{
		}

		public void OnInterstitialAdClicked(string adLocation)
		{
		}

		public void OnInterstitialAdStarted(CoreAdImpressionData adImpressionData)
		{
		}

		public void OnInterstitialAdFinished(string adUnit)
		{
		}

		public void OnInterstitialAdPaid()
		{
		}

		public void OnBannerAdLoaded()
		{
		}

		public void OnBannerAdLoadFailed(string error, int errorCode, string adRequestId)
		{
		}

		public void OnBannerAdClicked()
		{
		}

		public void OnBannerAdScreenPresented()
		{
		}

		public void OnBannerAdScreenDismissed()
		{
		}

		public void OnBannerAdLeftApplication()
		{
		}

		public void OnRewardedAdLoad(AdsProviderBase adMediator, string adFormat, string adRequestId)
		{
		}

		public void OnRewardedVideoAdLoaded(AdsProviderBase adMediator)
		{
		}

		public void OnRewardedAdLoadFailed(AdsProviderBase adMediator, string error, int errorCode, string adRequestId)
		{
		}

		public void OnRewardedVideoAdStarted(CoreAdImpressionData adImpressionData)
		{
		}

		public void OnRewardedVideoAdRewarded()
		{
		}

		public void OnRewardedVideoAdShowFailed(int errorCode, string error)
		{
		}

		public void OnRewardedVideoAdClicked(string adLocation)
		{
		}

		public void OnRewardedVideoAdSkipped()
		{
		}

		public void OnRewardedAdPaid()
		{
		}

		public void OnNativeAdLoaded()
		{
		}

		public void OnNativeAdLoadFailed(string error)
		{
		}

		public void OnNativeAdShowSucceeded()
		{
		}

		public void OnNativeAdClicked()
		{
		}

		public void OnNativeAdStarted()
		{
		}

		public void OnNativeAdFinished(string adUnit)
		{
		}

		public void OnAppOpenClosed()
		{
		}

		public void OnAppOpenDisplay()
		{
		}

		public void OnAppOpenFailed(string error, int code)
		{
		}

		public void OnAppOpenClicked()
		{
		}

		public void OnAppOpenLoad()
		{
		}

		public void OnAppOpenRequested()
		{
		}
	}
}
