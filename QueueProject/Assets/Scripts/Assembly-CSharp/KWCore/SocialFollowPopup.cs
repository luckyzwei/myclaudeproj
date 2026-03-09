using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using KWLocalisation.Localisation;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace KWCore
{
	[SortingLayer("SocialFollowPopup")]
	public class SocialFollowPopup : PopUpBase
	{
		[CompilerGenerated]
		private sealed class _003CHandleButtonPressedAfterDelay_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Button pressedButton;

			public Action onComplete;

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
			public _003CHandleButtonPressedAfterDelay_003Ed__15(int _003C_003E1__state)
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

		private const string FOLLOW_BUTTON_PREFAB_NAME_PREFIX = "Button-Follow-";

		private const string BUTTON_ANIMATION_STATE_NAME = "Button-Pressed";

		private const float CLOSE_POPUP_DELAY = 0.2f;

		[SerializeField]
		private Button m_closeButton;

		[SerializeField]
		private Button m_clickOutsideButton;

		[SerializeField]
		private TextWrapper m_followUsText;

		[SerializeField]
		private TextWrapper m_rewardText;

		[SerializeField]
		private GameObject m_rewardContainer;

		[SerializeField]
		private Transform m_contentRoot;

		[SerializeField]
		private string m_rewardTextPrefix;

		[SerializeField]
		private SkeletonGraphic m_chestSkeletonGraphic;

		public void Initialize(bool isSocialPlatformBanned, string fallbackSocialMediaPlatformName, int rewardAmount, Action onFollowPressed, Action onClosePressed)
		{
		}

		private void ClosePopUp(Action onClosePressed)
		{
		}

		private void HandleEntryAnimationCompleted(TrackEntry trackEntry)
		{
		}

		private void CreateFollowUsButtonWithClickEvent(bool isSocialPlatformBanned, string fallbackSocialMediaPlatformName, Action onFollowClicked)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleButtonPressedAfterDelay_003Ed__15))]
		private IEnumerator HandleButtonPressedAfterDelay(Button pressedButton, Action onComplete)
		{
			return null;
		}

		private void SetRewardText(int rewardAmount)
		{
		}

		private void ToggleRewardUI(bool hasReward)
		{
		}
	}
}
