using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KWAds.Ads
{
	public class FakeAdsNative : FakeAdsGUI
	{
		[CompilerGenerated]
		private sealed class _003CLoadNative_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsNative _003C_003E4__this;

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
			public _003CLoadNative_003Ed__10(int _003C_003E1__state)
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

		private const string TEXTURE_NAME = "FakeNativeAd";

		private const string PREFAB_PATH = "FakeAds/FakeNativeAd";

		private Texture m_nativeAd;

		private GameObject m_nativeAdView;

		public bool isShowingNative()
		{
			return false;
		}

		public FakeAdsNative(FakeAdsMediationSettings settings)
		{
		}

		public override void LoadAd()
		{
		}

		public override void ShowAd(string placement)
		{
		}

		public void ShowNative(FakeNativeAdView view)
		{
		}

		public override void DestroyAd()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadNative_003Ed__10))]
		private IEnumerator LoadNative()
		{
			return null;
		}

		protected void OnClickedAd(BaseEventData _)
		{
		}
	}
}
