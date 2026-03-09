using System.Collections.Generic;
using KWAnalytics.Analytics;
using KWGameSettings;

namespace KWAds.Ads
{
	public abstract class AdSystemBase
	{
		protected enum AdInteraction
		{
			REQUESTED = 0,
			DOWNLOADED = 1,
			TRIGGERED = 2,
			SHOWN = 3,
			CLICKED = 4,
			REWARDED = 5,
			SKIPPED = 6,
			COMPLETED = 7,
			FAILED = 8
		}

		protected static bool s_isAdShowing;

		protected static bool s_isCrossAdCall;

		protected string m_rejectionCauseMediator;

		protected string m_rejectionCauseSystem;

		protected AdsProviderBase m_providerInUseForAdLoad;

		protected bool m_adsEnabled;

		protected string m_currentAdLocation;

		protected AdsProviderBase m_currentProviderInUse;

		protected AdsProviderWaterfallBase m_providersWaterfall;

		private string m_currentRequestId;

		private string m_currentAdOpportunityId;

		private long m_requestStartTime;

		public static bool IsAdShowing => false;

		public static bool IsCrossAdCall => false;

		public string SystemName { get; private set; }

		private string GenerateUniqueAdId(string adId)
		{
			return null;
		}

		protected void StartRequestTracking()
		{
		}

		protected void StartOpportunityTracking()
		{
		}

		private long GetLoadTime()
		{
			return 0L;
		}

		private bool AreSegmentedAdsAnalyticsEnabled()
		{
			return false;
		}

		public AdSystemBase(string systemName)
		{
		}

		protected abstract void InitialiseProviders(List<AdsProviderBase> adsProvider);

		public virtual void CoreInitialisationCompleted()
		{
		}

		public virtual void ProductsStateUpdated()
		{
		}

		public virtual void SetAdsEnabled(bool enabled)
		{
		}

		public string GetCurrentRequestId()
		{
			return null;
		}

		public string[] GetProvidersWaterfall()
		{
			return null;
		}

		protected abstract string[] GetWaterfallFromAdsPlacementProvider(AdsPlacementProviderWaterfall adsPlacementProvider);

		protected abstract void DealProviderAd();

		protected abstract AdSchema GetNewAdSchema(AdInteraction interaction);

		protected virtual void SetAdUniqueIDToSchema(AdSchema adSchema, AdInteraction interaction)
		{
		}

		protected virtual void SetRejectionCause(string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		protected string GetMediatorName()
		{
			return null;
		}

		protected void OnAdStarted()
		{
		}

		protected void OnAdFinished()
		{
		}

		protected void SendAthenaAdEvent(AdInteraction interaction, int waterfallChosen = 0, bool isNoFill = false)
		{
		}

		protected void TryGetConnectivityOrMediatorNoShowReason(out string rejectionCause)
		{
			rejectionCause = null;
		}

		private void SetAdFormat(AdSchema adSchema)
		{
		}

		private void SetAppAdPlacementFormat(AdSchema adSchema)
		{
		}

		public virtual bool IsRevenueHigherByPercentage(double? revenue1, double? revenue2, float percentage)
		{
			return false;
		}
	}
}
