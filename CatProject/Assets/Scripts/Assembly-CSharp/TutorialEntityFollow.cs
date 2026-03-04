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
		public _003CWaitVip_003Ed__9(int _003C_003E1__state)
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
	}

	[IteratorStateMachine(typeof(_003CWaitVip_003Ed__9))]
	private IEnumerator WaitVip()
	{
		yield break;
	}

	private void Update()
	{
	}
}
