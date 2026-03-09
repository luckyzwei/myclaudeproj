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
	public class AdSystemRewardVideos : AdSystemBase, RewardAdBlocker.IDelegate
	{
		public interface IDelegate
		{
			GameObject GetAdClearPrefab();

			GameObject GetRewardAdBlocker();
		}

		public class AdPlacement
		{
			public string RewardName { get; }

			public int RewardAmount { get; }

			public string PlacementName { get; }

			public AdPlacement(string placementName, string rewardName, int rewardAmount)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowRVClearPopUp_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdSystemRewardVideos _003C_003E4__this;

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
			public _003CShowRVClearPopUp_003Ed__29(int _003C_003E1__state)
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

		private const string AD_UNIT_TYPE_REWARD = "reward";

		private const float REWARD_FAILED_WAIT = 2f;

		private const int ERROR_CODE_NO_INTERNET = 520;

		private const float RV_CLEAR_POP_UP_WAIT_TIME = 0.5f;

		private bool m_initialised;

		private Action<AdsManager.VideoResult> m_adCallback;

		private IDelegate m_delegate;

		private RewardAdBlocker m_rewardAdBlocker;

		private ClearAdPopUp m_clearRVPopUp;

		private Coroutine m_rvClearPopUpCoroutine;

		private CoreMediatorImpressionData m_currentImpressionData;

		public AdSystemRewardVideos()
			: base(null)
		{
		}

		protected override void InitialiseProviders(List<AdsProviderBase> adsProvider)
		{
		}

		public void Initialise(List<AdsProviderBase> adsProvider, IDelegate del)
		{
		}

		protected override string[] GetWaterfallFromAdsPlacementProvider(AdsPlacementProviderWaterfall adsPlacementProvider)
		{
			return null;
		}

		protected override void DealProviderAd()
		{
		}

		private bool CanShowInterstitialOnRewarded()
		{
			return false;
		}

		private void ShowInterstitialOnRewarded(string location, Action<AdsManager.VideoResult> onFinish)
		{
		}

		public void ShowRewardAd(string location, Action<AdsManager.VideoResult> onFinish)
		{
		}

		private void SendLocationReachEvent(bool isAdShown, string noShowContext = "")
		{
		}

		private bool TryShowProviderAd(string location, ref string rejectionCause)
		{
			return false;
		}

		private void CallRewardCallback(AdsManager.VideoResult result)
		{
		}

		public void RetryRewardVideo()
		{
		}

		protected override AdSchema GetNewAdSchema(AdInteraction interaction)
		{
			return null;
		}

		protected override void SetAdUniqueIDToSchema(AdSchema adSchema, AdInteraction interaction)
		{
		}

		protected override void SetRejectionCause(string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		private void SendNoFillAnalyticEvent(string adUnitFormat, string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		[IteratorStateMachine(typeof(_003CShowRVClearPopUp_003Ed__29))]
		private IEnumerator ShowRVClearPopUp()
		{
			return null;
		}

		private void ClearRVAd()
		{
		}

		private void ClearRVPopUp()
		{
		}

		private void ShowRewardAdBlocker()
		{
		}

		public void KillRewardAdBlocker()
		{
		}

		private void RemoveRewardAdBlocker()
		{
		}

		private void ProviderAdRequestedEvent(AdsProviderBase adMediator, string adFormat, string adRequestId)
		{
		}

		private void AdLoadedEvent(AdsProviderBase adMediator)
		{
		}

		private void AdLoadFailedEvent(AdsProviderBase adMediator, string error, int errorCode, string adRequestId)
		{
		}

		private void ProviderAdStartedEvent(CoreAdImpressionData coreADImpression)
		{
		}

		private void AdStartedEvent()
		{
		}

		private void ProviderAdSkippedEvent()
		{
		}

		private void AdSkippedEvent()
		{
		}

		private void ProviderAdRewardedEvent()
		{
		}

		private void AdRewardedEvent()
		{
		}

		private void ProviderAdShowFailedEvent(int errorCode, string error)
		{
		}

		private void AdShowFailedEvent(int errorCode, string error)
		{
		}

		private void ProviderAdClickedEvent(string adLocation)
		{
		}

		private void AdClickedEvent()
		{
		}

		private void ProviderAdPaidEvent()
		{
		}
	}
}
