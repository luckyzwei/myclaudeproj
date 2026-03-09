using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class MAXInterstitialsProvider : FullScreenAdLifeCycle
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndDo_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__28(int _003C_003E1__state)
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

		private readonly AdsProviderMAX m_adsProvider;

		private string m_currentAdLocation;

		private MaxWaterfallStatusData[] m_waterfallData;

		private readonly List<MaxWaterfallStatusData> m_waterfallHistory;

		private int m_retryAttempt;

		private bool m_isFirstApsLoad;

		public int BestWaterfallIndex { get; private set; }

		public MAXImpressionDataWrapper CurrentImpressionData { get; private set; }

		public MAXImpressionDataWrapper PendingImpressionData => null;

		public MAXInterstitialsProvider(AdsProviderMAX adsProvider)
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

		public void ClearCurrentAd()
		{
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

		private string GetAmazonInterstitialSlotId()
		{
			return null;
		}

		private void AdAttemptCompleted(string adUnitId)
		{
		}

		private void ClearWaterfallIndex(string adUnitId)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__28))]
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

		private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}
	}
}
