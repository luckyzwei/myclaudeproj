using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaunchingPad : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitDelay_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LaunchingPad _003C_003E4__this;

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
		public _003CWaitDelay_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CWaitInit_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitInit_003Ed__13(int _003C_003E1__state)
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

	public Transform addSlotBtnTrans;

	[SerializeField]
	private Animation ani;

	[SerializeField]
	private float delayTime;

	[SerializeField]
	private int floor;

	[SerializeField]
	private int slotIdx;

	[SerializeField]
	private List<SpriteRenderer> targetSRs;

	[SerializeField]
	private Material grayScaleMat;

	private Material originMat;

	private Action MoveCallback;

	public void Shot(Action moveCallback)
	{
	}

	public void SetEnable(bool value)
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitDelay_003Ed__12))]
	private IEnumerator WaitDelay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitInit_003Ed__13))]
	private IEnumerator WaitInit()
	{
		return null;
	}
}
