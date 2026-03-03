using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using anzu;

namespace Anzu.Examples
{
	public class Reward : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedTurnOffReward_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Reward _003C_003E4__this;

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
			public _003CDelayedTurnOffReward_003Ed__16(int _003C_003E1__state)
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

		public Text _coinText;

		public AnzuAd _anzuAd;

		public Button _skipButton;

		public Button _startButton;

		public GameObject _coinObject;

		public Image _adRenderer;

		public Image _playbackIndicator;

		private int _coinCount;

		private bool _hasImpression;

		private bool _playbackIsPlaying;

		private const float _coinShowOffTime = 1f;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void RewardUser()
		{
		}

		private void RenderPlaybackIndicator()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedTurnOffReward_003Ed__16))]
		private IEnumerator DelayedTurnOffReward()
		{
			return null;
		}

		private void OnPlaybackStarted()
		{
		}

		private void OnPlaybackComplete()
		{
		}

		private void OnStartButtonPress()
		{
		}

		private void OnSkipButtonPress()
		{
		}

		private void GetChannelImpression(int channelID)
		{
		}
	}
}
