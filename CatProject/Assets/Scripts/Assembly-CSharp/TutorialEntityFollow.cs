using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEntityFollow : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CWaitVip_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityFollow _003C_003E4__this;

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
		public _003CWaitVip_003Ed__9(int _003C_003E1__state)
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
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.followWorker != null && !_003C_003E4__this.followWorker.IsState(_003C_003E4__this.waitState))
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
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
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private Worker.E_State waitState;

	[SerializeField]
	private float zoomSize;

	[SerializeField]
	private bool basicZoom;

	private GameObject target;

	private Worker followWorker;

	public override void StartEntity()
	{
		base.StartEntity();
		// Find target worker by id/targetIdx
		StartCoroutine(WaitVip());
	}

	[IteratorStateMachine(typeof(_003CWaitVip_003Ed__9))]
	private IEnumerator WaitVip()
	{
		var d = new _003CWaitVip_003Ed__9(0);
		d._003C_003E4__this = this;
		return d;
	}

	private void Update()
	{
		if (followWorker != null && target == null)
			target = followWorker.gameObject;
		if (target != null)
		{
			// Camera follows the target
		}
	}
}
