using System;
using System.Collections.Generic;
using KWAnalytics.Analytics;
using KWGameSettings;

namespace KWAds.Ads
{
	public class AdSystemOpen : AdSystemBase
	{
		private const string AD_LOCATION_SPLASH = "splash_screen";

		private bool m_initialised;

		private AdsAppOpen m_adsAppOpen;

		private Action m_onClosedCallBack;

		private Action m_onDisplayCallBack;

		private Action m_onAdClickCallBack;

		private DateTime m_adloadTime;

		private bool m_bannerCheck;

		public AdSystemOpen()
			: base(null)
		{
		}

		protected override void InitialiseProviders(List<AdsProviderBase> adsProvider)
		{
		}

		public void Initialise(List<AdsProviderBase> adsProvider)
		{
		}

		private bool IsAdEnabled()
		{
			return false;
		}

		public bool IsAllowedToShow()
		{
			return false;
		}

		private void HandleSplashScreenCompleted()
		{
		}

		private bool CanShowAdAtLocation(string locationName)
		{
			return false;
		}

		private bool CheckProbability(OpenAdLocation location)
		{
			return false;
		}

		public void TryShowOpenAd(string location, Action onClosedCallBack = null, Action onDisplayCallBack = null, Action onAdClickCallBack = null)
		{
		}

		private void HandleOnDisplay()
		{
		}

		private void HandleOnClosed()
		{
		}

		private void HandleOnAdFailed(string adError, int errorCode)
		{
		}

		private void HandleOnAdClick()
		{
		}

		private void HandleOnAdLoad()
		{
		}

		private void HandleOnAdRequested()
		{
		}

		private OpenAdLocation GetLocationInfo(string locationName)
		{
			return null;
		}

		private void ClearAdCallbacks()
		{
		}

		protected override string[] GetWaterfallFromAdsPlacementProvider(AdsPlacementProviderWaterfall adsPlacementProvider)
		{
			return null;
		}

		protected override void DealProviderAd()
		{
		}

		protected override AdSchema GetNewAdSchema(AdInteraction interaction)
		{
			return null;
		}

		protected override void SetAdUniqueIDToSchema(AdSchema adSchema, AdInteraction interaction)
		{
		}
	}
}
