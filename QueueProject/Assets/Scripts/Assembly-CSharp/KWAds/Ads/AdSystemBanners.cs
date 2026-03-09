using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAnalytics.Analytics;
using KWGameSettings;
using UnityEngine;

namespace KWAds.Ads
{
	public class AdSystemBanners : AdSystemBase
	{
		public interface IDelegate
		{
			GameObject GetBannerBackgroundPrefab();
		}

		public enum BannerPosition
		{
			TOP = 1,
			BOTTOM = 2
		}

		public enum BannerSize
		{
			REGULAR = 1,
			LARGE = 2,
			RECTANGULAR = 3,
			SMART = 4
		}

		[CompilerGenerated]
		private sealed class _003CWaitLoadBanner_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdSystemBanners _003C_003E4__this;

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
			public _003CWaitLoadBanner_003Ed__41(int _003C_003E1__state)
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

		private const float AD_RELOAD_WAIT_TIME = 10f;

		private IDelegate m_delegate;

		private bool m_initialised;

		private bool m_bannerAdsEnabled;

		private bool m_bannerLoadingOrShowing;

		private bool m_bannerLoaded;

		private float m_adReloadTime;

		private float m_maxBannersHeight;

		private GameObject m_bannerBackground;

		private IEnumerator m_bannerLoadCoroutine;

		private bool m_visible;

		private bool m_showBannerBackground;

		private bool m_bannerHiddenOnAdPlayed;

		private CoreMediatorImpressionData m_impressionData;

		public bool AdsEnabled => false;

		public AdSystemBanners()
			: base(null)
		{
		}

		protected override void InitialiseProviders(List<AdsProviderBase> adsProvider)
		{
		}

		public void Initialise(List<AdsProviderBase> adsProvider, IDelegate del)
		{
		}

		private void OnAdStarted(string adsProviderName)
		{
		}

		private void OnAdFinished(AdType adType)
		{
		}

		public override void SetAdsEnabled(bool enabled)
		{
		}

		public override void ProductsStateUpdated()
		{
		}

		protected override string[] GetWaterfallFromAdsPlacementProvider(AdsPlacementProviderWaterfall adsPlacementProvider)
		{
			return null;
		}

		protected override void DealProviderAd()
		{
		}

		protected override AdSchema GetNewAdSchema(AdInteraction interaction)
		{
			return null;
		}

		public void EnableBannerAds(bool enabled)
		{
		}

		public void SetBannerSizeToRegular()
		{
		}

		public void SetBannerSizeToRectangular()
		{
		}

		public void SetBannersBackgroundVisible(bool visible)
		{
		}

		public void SetBannersVisible(bool visible)
		{
		}

		private void SetBannersVisibleInternal(bool visible)
		{
		}

		public void SetBannerSize(BannerSize size)
		{
		}

		public void SetBannerPosition(BannerPosition pos)
		{
		}

		public void SetBannerBackgroundColor(Color color)
		{
		}

		private void SelectPossibleWinningAdProviderFromWaterfall()
		{
		}

		private void LoadBanner()
		{
		}

		private void DestroyBanner()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitLoadBanner_003Ed__41))]
		private IEnumerator WaitLoadBanner()
		{
			return null;
		}

		private void ShowBannerBackground()
		{
		}

		private void ProviderAdLoadedEvent()
		{
		}

		private void ProviderAdLoadFailedEvent(string error, int errorCode, string adRequestId)
		{
		}

		private void StartBannerCoroutine()
		{
		}

		private void ProviderAdClickedEvent()
		{
		}

		private void ProviderAdScreenPresentedEvent()
		{
		}

		private void ProviderAdScreenDismissedEvent()
		{
		}

		public virtual float GetBannerHeight()
		{
			return 0f;
		}
	}
}
