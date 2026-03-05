using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEntityWaitTime : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CWaitTime_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityWaitTime _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWaitTime_003Ed__2(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = new WaitForSeconds(_003C_003E4__this.waitTime);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E4__this.Done();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private float waitTime;

	public override void StartEntity()
	{
		base.StartEntity();
		StartCoroutine(WaitTime());
	}

	[IteratorStateMachine(typeof(_003CWaitTime_003Ed__2))]
	private IEnumerator WaitTime()
	{
		var d = new _003CWaitTime_003Ed__2(0);
		d._003C_003E4__this = this;
		return d;
	}
}
