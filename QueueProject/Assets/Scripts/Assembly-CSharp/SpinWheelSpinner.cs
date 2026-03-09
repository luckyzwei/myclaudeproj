using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpinWheelSpinner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIdleSpinCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinWheelSpinner _003C_003E4__this;

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
		public _003CIdleSpinCoroutine_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CSpinCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinWheelSpinner _003C_003E4__this;

		private float _003CstartAngle_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private float _003CfinalRotation_003E5__4;

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
		public _003CSpinCoroutine_003Ed__19(int _003C_003E1__state)
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

	private const float FULL_ROTATION = 360f;

	[SerializeField]
	private Transform m_spinPivot;

	[Header("Idle Tween")]
	[SerializeField]
	private float m_idleSpeed;

	[Header("Spin Tween")]
	[SerializeField]
	private int m_fullRotations;

	[SerializeField]
	private float m_totalSpinTime;

	[SerializeField]
	private AnimationCurve m_spinCurve;

	[SerializeField]
	private float m_finalPositionOffset;

	private Action m_spinCompleteCallback;

	private int m_segments;

	private int m_targetSegment;

	private bool m_canSpin;

	private bool m_isIdleSpinning;

	public bool IsIdleSpinning => false;

	public Transform SpinPivot => null;

	public void Config(int segments)
	{
	}

	[IteratorStateMachine(typeof(_003CIdleSpinCoroutine_003Ed__17))]
	private IEnumerator IdleSpinCoroutine()
	{
		return null;
	}

	public void Reset()
	{
	}

	[IteratorStateMachine(typeof(_003CSpinCoroutine_003Ed__19))]
	private IEnumerator SpinCoroutine()
	{
		return null;
	}

	public void StartIdleSpin()
	{
	}

	public void StartSpin(int targetSegment, Action spinComplete = null)
	{
	}
}
