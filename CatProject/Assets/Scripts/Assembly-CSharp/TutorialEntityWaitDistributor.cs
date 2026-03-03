using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
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
		public _003CSetAndWaitTime_003Ed__6(int _003C_003E1__state)
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
	private int TutorialDistributeTimeSec;

	[SerializeField]
	private float WaitTimeSec;

	[SerializeField]
	private CamOffset CamOffset;

	private UnityAction<int, BigInteger> DistributeCallback;

	public override void StartEntity()
	{
	}

	private void ZoomDistributorObj()
	{
	}

	[IteratorStateMachine(typeof(_003CSetAndWaitTime_003Ed__6))]
	private IEnumerator SetAndWaitTime()
	{
		return null;
	}
}
