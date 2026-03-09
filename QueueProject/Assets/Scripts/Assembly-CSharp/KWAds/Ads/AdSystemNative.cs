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
	public class AdSystemNative : AdSystemBase
	{
		public interface IDelegate
		{
			GameObject GetNativeView();
		}

		[CompilerGenerated]
		private sealed class _003CLoadDelay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdSystemNative _003C_003E4__this;

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
			public _003CLoadDelay_003Ed__25(int _003C_003E1__state)
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

		private const string AD_UNIT_TYPE_NATIVE = "native";

		private const float LOAD_DELAY = 3f;

		private bool m_nativeAdsEnabled;

		private Action m_adCallback;

		private IDelegate m_delegate;

		protected override void InitialiseProviders(List<AdsProviderBase> adsProvider)
		{
		}

		public AdSystemNative()
			: base(null)
		{
		}

		public void Initialise(List<AdsProviderBase> adsProvider, IDelegate del)
		{
		}

		public void EnableNativeAds(bool enabled)
		{
		}

		public override void SetAdsEnabled(bool enabled)
		{
		}

		private void LoadNative()
		{
		}

		public void DestroyNativeAd()
		{
		}

		public void ShowNativeAd<T>(string location, T nativeAdView, Action onFinish = null)
		{
		}

		private void SendNoFillAnalyticEvent(string adUnitFormat, string rejectionCauseSystem, string rejectionCauseMediator)
		{
		}

		private bool TryShowProviderAd<T>(T nativeAdView)
		{
			return false;
		}

		private void CallNativeCallBack()
		{
		}

		public GameObject GetNativeGameObject()
		{
			return null;
		}

		private void AdShowFailEvent(string error, bool isXPromoAd)
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

		private void ProviderAdLoadFailedEvent(string error)
		{
		}

		private void ProviderAdShowSuccessEvent()
		{
		}

		private void ProviderAdShowFailEvent(string error)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadDelay_003Ed__25))]
		private IEnumerator LoadDelay()
		{
			return null;
		}

		private void ProviderAdClickedEvent()
		{
		}

		private void AdClickedEvent(bool isXPromoAd)
		{
		}

		private void ProviderAdStartedEvent()
		{
		}

		private void AdStartedEvent(bool isXPromoAd)
		{
		}

		private void ProviderAdFinishedEvent(string adUnit)
		{
		}

		private void AdFinishedEvent(bool isXPromoAd)
		{
		}
	}
}
