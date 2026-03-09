using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrownExplosionFragment : CurrencyExplosionCell
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrownExplosionFragment _003C_003E4__this;

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
		public _003CStart_003Ed__7(int _003C_003E1__state)
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

	private const string ANIM_INTRO = "Intro";

	private const string ANIM_MOVETOTARGET = "MoveToTarget";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private float m_delayBeforeMoveAnimation;

	[Header("Rotation")]
	[SerializeField]
	private Transform m_rotatingObject;

	[SerializeField]
	private float m_maxRotation;

	[SerializeField]
	private float m_rotationTime;

	[IteratorStateMachine(typeof(_003CStart_003Ed__7))]
	private IEnumerator Start()
	{
		return null;
	}

	private void PlayStartMovingCrownSfx()
	{
	}

	private void PlayCrownReachedCellSfx()
	{
	}
}
