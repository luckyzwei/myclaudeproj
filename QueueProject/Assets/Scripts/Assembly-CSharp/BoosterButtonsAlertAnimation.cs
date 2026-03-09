using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterButtonsAlertAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayAlertAnimationCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoosterButtonsAlertAnimation _003C_003E4__this;

		private float _003Cdelay_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CPlayAlertAnimationCoroutine_003Ed__12(int _003C_003E1__state)
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

	private List<BoosterButton> m_boosterButtons;

	private bool m_alertEnabled;

	private bool m_alertInProgress;

	private float m_lastTapTime;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void AddBoosterButton(BoosterButton button)
	{
	}

	private void OnLevelStart()
	{
	}

	private void OnQueenMarked(int obj)
	{
	}

	private void OnLifeLost(int obj)
	{
	}

	private void Update()
	{
	}

	private void PlayAlertAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayAlertAnimationCoroutine_003Ed__12))]
	private IEnumerator PlayAlertAnimationCoroutine()
	{
		return null;
	}
}
