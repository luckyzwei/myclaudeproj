using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAds.UI;
using KWAnalytics.Analytics;
using KWGameSettings;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdSystemInterstitials : AdSystemBase
	{
		public interface IDelegate
		{
			GameObject GetAdClearPrefab();

			GameObject GetFullScreenAdBreakPopup();

			GameObject GetBannerAdBreakPopup();
		}

		[CompilerGenerated]
		private sealed class _003CShowInterstitialClearPopUp_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdSystemInterstitials _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowInterstitialClearPopUp_003Ed__40(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string AD_UNIT_TYPE_INTERSTITIAL = "interstitial";

		private const string SPLASH_INTERSTITIAL_LOCATION = "splash_interstitial";

		private const float INTERSTITIAL_CLEAR_POP_UP_WAIT_TIME = 0.5f;

		private bool m_initialised;

		private bool m_showConsecutiveAd;

		private bool m_isGameStarted;

		private bool m_isSplashAdShowAttempted;

		private IDelegate m_delegate;

		private Action m_adCallback;

		private AdsCoolDownManager m_adsCoolDownManager;

		private Coroutine m_interstitialClearPopUpCoroutine;

		private ClearAdPopUp m_clearInterstitialPopUp;

		private AdBreakPopupManager m_adBreakPopupManager;

		private int m_intsCountSinceLastRvReplacement;

		private CoreMediatorImpressionData m_currentImpressionData;

		public AdSystemInterstitials()
			: base(null)
		{
		}

		protected override void InitialiseProviders(List<AdsProviderBase> adsProvider)
		{
		}

		public void Initialise(List<AdsProviderBase> adsProvider, IDelegate del)
		{
		}

		public override void CoreInitialisationCompleted()
		{
		}

		protected override string[] GetWaterfallFromAdsPlacementProvider(AdsPlacementProviderWaterfall adsPlacementProvider)
		{
			return null;
		}

		protected override void DealProviderAd()
		{
		}

		public bool CanShowInterstitial(string location, bool skipCoolDown = false)
		{
			return false;
		}

		public void TryToShowInterstitial(string location, Action onFinish = null, bool skipCoolDown = false)
		{
		}

		private void SendLocationReachEvent(bool isAdShown, string noShowContext = "")
		{
		}

		private bool CanShowRewardedOnInterstitial()
		{
			return false;
		}

		private void ShowRewardedOnInterstitial(string location, Action onFinish)
		{
		}

		private void ShowInterstitialAd(string rejectionCauseSystem, ref string rejectionCauseMediator)
		{
		}

		private bool TryShowProviderAd(ref string rejectionCause)
		{
			return false;
		}

		private void CheckProbabilityForConsecutiveAd()
		{
		}

		private void CallInterstitialCallback()
		{
		}

		private int GetWaterfallIndex()
		{
			return 0;
		}

		private bool CanShowAdBreakPopup(bool canShowAdBreakPopup, bool isProviderReady)
		{
			return false;
		}

		private void ShowAdBreakPopup(Action interstitialAdShowHandler)
		{
		}

		private void OnGameStarted(int stageNumber, bool hasStages = false)
		{
		}

		protected override void SetRejectionCause(string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		private bool CheckDayChanged()
		{
			return false;
		}

		protected override AdSchema GetNewAdSchema(AdInteraction interaction)
		{
			return null;
		}

		protected override void SetAdUniqueIDToSchema(AdSchema adSchema, AdInteraction interaction)
		{
		}

		private void SendNoFillAnalyticEvent(string adUnitFormat, string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		[IteratorStateMachine(typeof(_003CShowInterstitialClearPopUp_003Ed__40))]
		private IEnumerator ShowInterstitialClearPopUp()
		{
			return null;
		}

		private void ClearInterstitialAd()
		{
		}

		private void ClearInterstitialClearPopUp()
		{
		}

		private void TryShowSplashAd()
		{
		}

		private bool CanShowSplashAd()
		{
			return false;
		}

		private void ProviderAdRequestedEvent(AdsProviderBase adMediator, string adFormat, string adRequestId)
		{
		}

		private void ProviderAdReadyEvent(AdsProviderBase adMediator)
		{
		}

		private void ProviderAdLoadFailedEvent(AdsProviderBase adMediator, string error, int errorCode, string adRequestId)
		{
		}

		private void ProviderAdShowSuccessEvent()
		{
		}

		private void ProviderAdShowFailEvent(string error)
		{
		}

		private void AdShowFailEvent(string error)
		{
		}

		private void ProviderAdClickedEvent(string adLocation)
		{
		}

		private void AdClickedEvent()
		{
		}

		private void ProviderAdStartedEvent(CoreAdImpressionData coreADImpression)
		{
		}

		private void AdStartedEvent()
		{
		}

		private void ProviderAdFinishedEvent(string adUnit)
		{
		}

		private void ProviderAdPaidEvent()
		{
		}

		private void AdFinishedEvent()
		{
		}
	}
}
