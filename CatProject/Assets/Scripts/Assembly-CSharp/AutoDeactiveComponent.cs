using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AutoDeactiveComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoDeactive_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AutoDeactiveComponent _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CAutoDeactive_003Ed__6(int _003C_003E1__state)
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
	private float DactiveTime;

	private float PlaySpeed;

	private Coroutine DeactiveCoroutine;

	public void SetPlaySpeed(float playSpeed)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoDeactive_003Ed__6))]
	private IEnumerator AutoDeactive()
	{
		yield break;
	}
}
