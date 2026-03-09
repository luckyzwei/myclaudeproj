using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KWAds.Ads
{
	public class FARewardVideoProvider
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndDo_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CWaitBeforeSkippingAd_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FARewardVideoProvider _003C_003E4__this;

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
			public _003CWaitBeforeSkippingAd_003Ed__19(int _003C_003E1__state)
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

		private readonly AdsProviderFakeAds m_adsProvider;

		private bool m_isAdRewarded;

		private bool m_isAdClosed;

		private int m_retryAttempt;

		private string m_currentAdLocation;

		private Coroutine m_skipAdCoroutine;

		public bool IsAdReady => false;

		public FAImpressionDataWrapper PendingImpressionData { get; private set; }

		public FARewardVideoProvider(AdsProviderFakeAds adsProvider)
		{
		}

		public void ShowAd(string placement)
		{
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

		[IteratorStateMachine(typeof(_003CWaitBeforeSkippingAd_003Ed__19))]
		private IEnumerator WaitBeforeSkippingAd()
		{
			return null;
		}

		private void GiveReward()
		{
		}

		private void ClearAdFlags()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__22))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}

		private void OnFakeAdRewardVideoLoaded(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdRewardVideoLoadedFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdRewardVideoImpressionReady(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdRewardVideoClicked(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdRewardVideoShowSuccess(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdRewardVideoShowFailed(FakeAdsError error)
		{
		}

		private void OnFakeAdRewardVideoRewarded(FakeAdSettingsInfo adInfo)
		{
		}

		private void OnFakeAdRewardVideoClosed(FakeAdSettingsInfo adInfo)
		{
		}
	}
}
