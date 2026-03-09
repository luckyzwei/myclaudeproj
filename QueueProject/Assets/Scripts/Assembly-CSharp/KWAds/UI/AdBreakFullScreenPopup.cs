using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAds.Ads;
using KWLocalisation.Localisation;
using UnityEngine;

namespace KWAds.UI
{
	public class AdBreakFullScreenPopup : AdBreakPopupBase
	{
		[CompilerGenerated]
		private sealed class _003CEnableNoThanksButtonAfterDelay_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AdBreakFullScreenPopup _003C_003E4__this;

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
			public _003CEnableNoThanksButtonAfterDelay_003Ed__27(int _003C_003E1__state)
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

		private const string AD_BREAK_RV_LOCATION = "ad_break_popup";

		private const string TEXT_COLLECT = "AdBreakPopup.CollectButton";

		private const string TEXT_CONTINUE = "AdBreakPopup.ContinueButton";

		[SerializeField]
		protected GameObject m_rewardButton;

		[SerializeField]
		protected GameObject m_noThanksButton;

		[SerializeField]
		protected GameObject m_collectButton;

		[SerializeField]
		protected TextWrapper m_rvRewardText;

		[SerializeField]
		protected TextWrapper m_noThanksRewardText;

		[SerializeField]
		protected TextWrapper m_collectButtonText;

		private string m_backgroundColorHexCode;

		private Coroutine m_noThanksDelayCoroutine;

		private bool m_enableRVOption;

		private bool m_isCollectButtonEnabled;

		private int m_minRewardAmountRV;

		private float m_rewardPercentageRV;

		private float m_moneyEarnedRV;

		private long m_delayUntilNoThanksMs;

		public override void Initialise(Action interstitialAdShowHandler, Action rewardAdCallback)
		{
		}

		protected override void SetupBackground()
		{
		}

		protected override void SetAdBreakPopupSettingsValues()
		{
		}

		protected override void SetEarningsText()
		{
		}

		public void OnRewardAdButtonPressed()
		{
		}

		public void OnNoThanksButtonPressed()
		{
		}

		public void OnCollectButtonPressed()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void GiveAdWatchedReward()
		{
		}

		private void SetPopupDataIfRVOptionEnabled()
		{
		}

		[IteratorStateMachine(typeof(_003CEnableNoThanksButtonAfterDelay_003Ed__27))]
		private IEnumerator EnableNoThanksButtonAfterDelay(float delay)
		{
			return null;
		}

		private void SetCollectButtonText()
		{
		}

		private void OnRewardAdFinished(AdsManager.VideoResult result)
		{
		}
	}
}
