using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KWAds.Ads
{
	public class FakeAdsBanner : FakeAdsGUI
	{
		[CompilerGenerated]
		private sealed class _003CLoadBanner_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsBanner _003C_003E4__this;

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
			public _003CLoadBanner_003Ed__7(int _003C_003E1__state)
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

		private const string PREFAB_NAME = "FakeAdsBanner";

		private const string PREFAB_PATH = "FakeAds/FakeAdsPrefabs/FakeAdsBanner";

		private GameObject m_bannerPrefab;

		public FakeAdsBanner(FakeAdsMediationSettings settings)
		{
		}

		public override void LoadAd()
		{
		}

		public override void ShowAd(string placement)
		{
		}

		public override void DestroyAd()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadBanner_003Ed__7))]
		private IEnumerator LoadBanner()
		{
			return null;
		}

		private void SetupPrefab()
		{
		}

		private void OnClickedAd(BaseEventData _)
		{
		}
	}
}
