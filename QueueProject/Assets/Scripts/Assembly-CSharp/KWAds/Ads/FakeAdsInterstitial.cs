using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KWAds.Ads
{
	public class FakeAdsInterstitial : FakeAdsGUI
	{
		[CompilerGenerated]
		private sealed class _003CCloseInterstitialAd_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsInterstitial _003C_003E4__this;

			private int _003CwaitTime_003E5__2;

			private float _003CelapsedTime_003E5__3;

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
			public _003CCloseInterstitialAd_003Ed__18(int _003C_003E1__state)
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
		private sealed class _003CLoadInterstitial_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsInterstitial _003C_003E4__this;

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
			public _003CLoadInterstitial_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CWaitAndDo_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CWaitBeforeCloseAd_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsInterstitial _003C_003E4__this;

			public Button btn;

			private int _003CwaitTime_003E5__2;

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
			public _003CWaitBeforeCloseAd_003Ed__17(int _003C_003E1__state)
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

		private const string PREFAB_NAME = "FakeAdsInterstitial";

		private const string PREFAB_PATH = "FakeAds/FakeAdsPrefabs/FakeAdsInterstitial";

		private const string CLOSE_BTN = "InterstitialCloseButton";

		private const string FAIL_BTN = "InterstitialForceFailButton";

		private GameObject m_interstitialPrefab;

		private bool m_isCloseAdCoroutineTriggered;

		private Coroutine m_closeAdCoroutine;

		public bool isInterstitialReady()
		{
			return false;
		}

		public FakeAdsInterstitial(FakeAdsMediationSettings settings)
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

		[IteratorStateMachine(typeof(_003CLoadInterstitial_003Ed__12))]
		private IEnumerator LoadInterstitial()
		{
			return null;
		}

		private void SetupPrefab()
		{
		}

		protected void OnClickedAd(BaseEventData _)
		{
		}

		private void OnClickedClose()
		{
		}

		private void OnClickedForceFail()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitBeforeCloseAd_003Ed__17))]
		private IEnumerator WaitBeforeCloseAd(Button btn)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloseInterstitialAd_003Ed__18))]
		public IEnumerator CloseInterstitialAd()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__19))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}
	}
}
