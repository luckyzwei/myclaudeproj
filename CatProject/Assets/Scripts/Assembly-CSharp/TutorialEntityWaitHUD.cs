using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class TutorialEntityWaitHUD : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CWaitHUD_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityWaitHUD _003C_003E4__this;

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
		public _003CWaitHUD_003Ed__1(int _003C_003E1__state)
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
					// Wait until HUD is loaded and visible
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

	public override void StartEntity()
	{
		base.StartEntity();
		StartCoroutine(WaitHUD());
	}

	[IteratorStateMachine(typeof(_003CWaitHUD_003Ed__1))]
	private IEnumerator WaitHUD()
	{
		var d = new _003CWaitHUD_003Ed__1(0);
		d._003C_003E4__this = this;
		return d;
	}
}
