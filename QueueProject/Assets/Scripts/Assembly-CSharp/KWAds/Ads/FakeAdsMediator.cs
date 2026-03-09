using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class FakeAdsMediator
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndSendInitializedEvent_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CWaitAndSendInitializedEvent_003Ed__23(int _003C_003E1__state)
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

		private const string FAKE_ADS_RESOURCE_FOLDER = "FakeAds/";

		private static FakeAdsMediator s_Instance;

		private readonly FakeAdsMediationSettings m_mediationSettings;

		private FakeAdsInterstitial m_interstitial;

		private FakeAdsRewardVideo m_rewardVideo;

		private FakeAdsBanner m_banner;

		private FakeAdsNative m_native;

		public static FakeAdsMediator Agent => null;

		public void Init()
		{
		}

		public void LoadInterstitial()
		{
		}

		public void ShowInterstitial(string placement)
		{
		}

		public bool IsRewardVideoReady()
		{
			return false;
		}

		public void LoadRewardVideo()
		{
		}

		public void ShowRewardVideo(string placement)
		{
		}

		public void ShowBanner()
		{
		}

		public void LoadBanner()
		{
		}

		public void DestroyBanner()
		{
		}

		public bool IsShowingNative()
		{
			return false;
		}

		public void ShowNative(FakeNativeAdView view)
		{
		}

		public void LoadNative()
		{
		}

		public void DestroyNative()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndSendInitializedEvent_003Ed__23))]
		private IEnumerator WaitAndSendInitializedEvent()
		{
			return null;
		}
	}
}
