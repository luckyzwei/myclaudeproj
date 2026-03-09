using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.UI;

namespace KWAds.UI
{
	[SortingLayer("PopupAdBreak")]
	public abstract class AdBreakPopupBase : PopUpBase
	{
		[CompilerGenerated]
		private sealed class _003CShowAdAfterPopupIsFullyVisible_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdBreakPopupBase _003C_003E4__this;

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
			public _003CShowAdAfterPopupIsFullyVisible_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CTriggerInterstitialAdShowCallback_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AdBreakPopupBase _003C_003E4__this;

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
			public _003CTriggerInterstitialAdShowCallback_003Ed__17(int _003C_003E1__state)
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

		protected const string REWARD_EARNED_CONTEXT = "ad_break_popup";

		[SerializeField]
		protected GameObject m_interstitialRewardCoinDisplayUI;

		[SerializeField]
		protected Image m_adBreakPopUpBackgroundImage;

		[SerializeField]
		protected TextWrapper m_interstitialRewardText;

		protected Coroutine m_showIntCoroutine;

		protected Action m_interstitialAdShowHandler;

		protected Action m_rewardAdCallback;

		protected bool m_noRewardOffered;

		protected int m_backgroundTransparency;

		protected float m_moneyEarnedInt;

		private int m_minRewardAmountInt;

		private float m_rewardPercentageInt;

		private long m_autoplayIntAfterMs;

		public virtual void Initialise(Action interstitialAdShowHandler, Action rewardAdCallback)
		{
		}

		protected virtual void SetAdBreakPopupSettingsValues()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void TriggerInterstitialAd()
		{
		}

		[IteratorStateMachine(typeof(_003CTriggerInterstitialAdShowCallback_003Ed__17))]
		private IEnumerator TriggerInterstitialAdShowCallback(float delay)
		{
			return null;
		}

		protected virtual void SetEarningsText()
		{
		}

		protected abstract void SetupBackground();

		protected virtual void GiveAdWatchedReward()
		{
		}

		[IteratorStateMachine(typeof(_003CShowAdAfterPopupIsFullyVisible_003Ed__21))]
		protected IEnumerator ShowAdAfterPopupIsFullyVisible()
		{
			return null;
		}
	}
}
