using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEntitySeasonalShowWorker : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CWaitAndHide_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntitySeasonalShowWorker _003C_003E4__this;

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
		public _003CWaitAndHide_003Ed__2(int _003C_003E1__state)
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
					_003C_003E2__current = new WaitForSeconds(2f);
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
	private bool IsShow;

	public override void StartEntity()
	{
		base.StartEntity();
		// Show or hide seasonal workers based on IsShow flag
		StartCoroutine(WaitAndHide());
	}

	[IteratorStateMachine(typeof(_003CWaitAndHide_003Ed__2))]
	private IEnumerator WaitAndHide()
	{
		var d = new _003CWaitAndHide_003Ed__2(0);
		d._003C_003E4__this = this;
		return d;
	}
}
