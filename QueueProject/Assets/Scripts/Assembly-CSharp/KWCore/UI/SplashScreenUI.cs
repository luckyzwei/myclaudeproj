using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KWCore.UI
{
	[SortingLayer("LoadingScreen")]
	public class SplashScreenUI : PopUpBase
	{
		[CompilerGenerated]
		private sealed class _003CLerpLogoColour_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SplashScreenUI _003C_003E4__this;

			public float durationSeconds;

			private float _003Ct_003E5__2;

			private Color _003ClogoTargetColour_003E5__3;

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
			public _003CLerpLogoColour_003Ed__5(int _003C_003E1__state)
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

		[SerializeField]
		private Image m_logo;

		[SerializeField]
		private AnimationCurve m_curve;

		private float m_durationInSeconds;

		[EventsQueuePriority(QueueId = "SplashScreenUI.ShowSplash", Priority = 50)]
		public void InitSplash(float durationSeconds)
		{
		}

		private void ShowSplash()
		{
		}

		[IteratorStateMachine(typeof(_003CLerpLogoColour_003Ed__5))]
		private IEnumerator LerpLogoColour(float durationSeconds)
		{
			return null;
		}
	}
}
