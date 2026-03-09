using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class FAInterstitialProvider
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndDo_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__15(int _003C_003E1__state)
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

		private readonly AdsProviderFakeAds m_adsProvider;

		private bool m_isAdReady;

		private int m_retryAttempt;

		private string m_currentAdLocation;

		public FAImpressionDataWrapper PendingImpressionData { get; private set; }

		public FAInterstitialProvider(AdsProviderFakeAds adsProvider)
		{
		}

		public void ShowAd(string placement)
		{
		}

		public bool IsAdReady()
		{
			return false;
		}

		public void OnApplicationPause(bool isPaused)
		{
		}

		public void ClearCurrentAd()
		{
		}

		private void LoadAd()
		{
		}

		private void AdAttemptCompleted()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__15))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}

		private void OnFakeAdInterstitialLoaded(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdInterstitialLoadedFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdInterstitialImpressionReady(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdInterstitialClicked(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdInterstitialShowSuccess(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdInterstitialShowFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdInterstitialClosed(FakeAdSettingsInfo adInfo)
		{
		}
	}
}
