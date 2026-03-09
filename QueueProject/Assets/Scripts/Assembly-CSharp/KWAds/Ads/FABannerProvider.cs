using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class FABannerProvider
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

		private bool m_adsEnabled;

		private int m_retryAttempt;

		private bool m_fistTimeBannerLoaded;

		public FAImpressionDataWrapper PendingImpressionData { get; private set; }

		public FABannerProvider(AdsProviderFakeAds adsProvider)
		{
		}

		public void ShowAds()
		{
		}

		public void SetBannersVisible(bool visible)
		{
		}

		public void StopAds()
		{
		}

		private void LoadAd()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__13))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}

		private void OnBannerLoadedEvent(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnBannerLoadFailedEvent(FakeAdsError error)
		{
		}

		private void OnBannerClickedEvent(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnBannerPresentedEvent(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnBannerDismissedEvent(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnImpressionDataReadyEvent(FakeAdSettingsInfo impressionData)
		{
		}
	}
}
