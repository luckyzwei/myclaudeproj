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
	public class FakeAdsRewardVideo : FakeAdsGUI
	{
		[CompilerGenerated]
		private sealed class _003CCloseRewardAd_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsRewardVideo _003C_003E4__this;

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
			public _003CCloseRewardAd_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CLoadRewardVideo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsRewardVideo _003C_003E4__this;

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
			public _003CLoadRewardVideo_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CWaitAndDo_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitAndDo_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CWaitBeforeCloseAd_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FakeAdsRewardVideo _003C_003E4__this;

			public Button closeBtn;

			public Button skipBtn;

			private int _003CwaitTime_003E5__2;

			private int _003CskipTime_003E5__3;

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
			public _003CWaitBeforeCloseAd_003Ed__19(int _003C_003E1__state)
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

		private const string PREFAB_NAME = "FakeAdsRewardVideo";

		private const string PREFAB_PATH = "FakeAds/FakeAdsPrefabs/FakeAdsRewardVideo";

		private const string CLOSE_BTN = "RewardVideoCloseButton";

		private const string SKIP_BTN = "RewardVideoSkipButton";

		private const string FAIL_BTN = "RewardVideoForceFailButton";

		private GameObject m_rewardVideoPrefab;

		private Coroutine m_timerCoroutine;

		private bool m_isCloseAdCoroutineFinishRunning;

		public bool isRewardVideoReady()
		{
			return false;
		}

		public FakeAdsRewardVideo(FakeAdsMediationSettings settings)
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

		[IteratorStateMachine(typeof(_003CLoadRewardVideo_003Ed__13))]
		private IEnumerator LoadRewardVideo()
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

		private void OnClickedSkip()
		{
		}

		private void OnClickedForceFail()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitBeforeCloseAd_003Ed__19))]
		private IEnumerator WaitBeforeCloseAd(Button closeBtn, Button skipBtn)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloseRewardAd_003Ed__20))]
		public IEnumerator CloseRewardAd()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitAndDo_003Ed__21))]
		private IEnumerator WaitAndDo(float time, Action action)
		{
			return null;
		}
	}
}
