using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class TutorialEntityWaitDistributor : TutorialEntity
{
	[CompilerGenerated]
	private sealed class _003CSetAndWaitTime_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityWaitDistributor _003C_003E4__this;

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
		public _003CSetAndWaitTime_003Ed__6(int _003C_003E1__state)
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
					// Set distributor time to tutorial value
					_003C_003E2__current = new WaitForSeconds(_003C_003E4__this.WaitTimeSec);
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
	private int TutorialDistributeTimeSec;

	[SerializeField]
	private float WaitTimeSec;

	[SerializeField]
	private CamOffset CamOffset;

	private UnityAction<int, BigInteger> DistributeCallback;

	public override void StartEntity()
	{
		base.StartEntity();
		ZoomDistributorObj();
		StartCoroutine(SetAndWaitTime());
	}

	private void ZoomDistributorObj()
	{
		// Zoom camera to distributor building with CamOffset
	}

	[IteratorStateMachine(typeof(_003CSetAndWaitTime_003Ed__6))]
	private IEnumerator SetAndWaitTime()
	{
		var d = new _003CSetAndWaitTime_003Ed__6(0);
		d._003C_003E4__this = this;
		return d;
	}
}
