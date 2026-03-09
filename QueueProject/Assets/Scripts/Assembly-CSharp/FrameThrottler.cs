using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine;

public class FrameThrottler : MonoSingleton<FrameThrottler>
{
	[CompilerGenerated]
	private sealed class _003CDelayFrameReduction_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FrameThrottler _003C_003E4__this;

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
		public _003CDelayFrameReduction_003Ed__12(int _003C_003E1__state)
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
	[Tooltip("fps during normal gameplay")]
	private int m_targetFPS;

	[SerializeField]
	[Tooltip("Throttled fps")]
	private int m_minFPS;

	[SerializeField]
	[Tooltip("Render Frames Per Second when throttled, otherwise its synced to target fps")]
	private float m_minRFPS;

	[SerializeField]
	[Tooltip("Time before frame is throttled to allow for residual animations")]
	private float m_throttleDelay;

	private Coroutine m_coroutine;

	private int m_performanceCritical;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	public void EnteredPerformanceCritical()
	{
	}

	public void ExitedPerformanceCritical()
	{
	}

	public void OneOffPerformanceCritical()
	{
	}

	private void TriggerPerformanceCritical()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayFrameReduction_003Ed__12))]
	private IEnumerator DelayFrameReduction()
	{
		return null;
	}
}
