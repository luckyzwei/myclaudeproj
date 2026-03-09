using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MAX.AmazonAds;
using UnityEngine;

namespace KWAds.Ads
{
	public class MAXRewardVideosProvider : FullScreenAdLifeCycle
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndDo_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public Action action;

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
			public _003CWaitAndDo_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitBeforeSkippingAd_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MAXRewardVideosProvider _003C_003E4__this;

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
			public _003CWaitBeforeSkippingAd_003Ed__31(int _003C_003E1__state)
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

		private const float AD_REWARD_MAX_WAIT_TIME = 0.5f;

		private readonly AdsProviderMAX m_adsProvider;

		private MaxWaterfallStatusData[] m_waterfallData;

		private readonly List<MaxWaterfallStatusData> m_waterfallHistory;

		private int m_retryAttempt;

		private bool m_isAdRewarded;

		private bool m_isAdClosed;

		private bool m_isFirstApsRewardedLoad;

		private Coroutine m_skipAdCoroutine;

		private APSVideoAdRequest m_amazonRewardedAdRequest;

		private string m_currentAdLocation;

		public int BestWaterfallIndex { get; private set; }

		public MAXImpressionDataWrapper CurrentImpressionData { get; private set; }

		public MAXImpressionDataWrapper PendingImpressionData => null;

		public MAXRewardVideosProvider(AdsProviderMAX adsProvider)
		{
		}

		public void ShowAd(string placement)
		{
		}

		public void OnApplicationPause(bool isPaused)
		{
		}

		public bool IsAdReady()
		{
			return false;
		}

		private void UpdateWaterfallData()
		{
		}

		private void UpdateBestWaterfallIndex()
		{
		}

		private void OnGameSettingsUpdated()
		{
		}

		private void LoadAd()
		{
		}

		private string GetAmazonRewardedSlotId()
		{
			return null;
		}

		private void AdAttemptCompleted()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitBeforeSkippingAd_003Ed__31))]
		private IEnumerator WaitBeforeSkippingAd()
		{
			return null;
		}

		private void RewardWatchedAd()
		{
		}

		private void ClearAdFlags()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__34))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}

		public List<MaxWaterfallStatusData> GetWaterfallStatus()
		{
			return null;
		}

		private List<MaxWaterfallStatusData> GetWaterfallHistory()
		{
			return null;
		}

		private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}
	}
}
