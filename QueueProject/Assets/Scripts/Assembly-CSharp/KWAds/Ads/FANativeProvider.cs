using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class FANativeProvider
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndDo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__13(int _003C_003E1__state)
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

		public FANativeProvider(AdsProviderFakeAds adsProvider)
		{
		}

		public void ShowNativeAd(FakeNativeAdView view)
		{
		}

		public void LoadNativeAd()
		{
		}

		public void DestroyNativeAd()
		{
		}

		private void AdAttemptCompleted()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__13))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}

		private void OnFakeAdNativeLoaded(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdNativeLoadedFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdNativeImpressionReady(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdNativeClicked(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdNativeShowSuccess(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdNativeShowFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdNativeClosed(FakeAdSettingsInfo adInfo)
		{
		}
	}
}
