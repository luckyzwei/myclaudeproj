using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimerDisposable : IDisposable
{
	public enum TimerState
	{
		STOPPED = 0,
		RUNNING = 1,
		PAUSED = 2
	}

	[Serializable]
	public class TimerEvents
	{
		public Action OnTimerStarted;

		public Action OnTimerStopped;

		public Action OnTimerPaused;

		public Action OnTimerResumed;

		public Action<float> OnTimerTick;

		public Action OnTimerCompleted;
	}

	[CompilerGenerated]
	private sealed class _003CTimerRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimerDisposable _003C_003E4__this;

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
		public _003CTimerRoutine_003Ed__20(int _003C_003E1__state)
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

	private const string TIMER_NAME_FORMAT = "Timer_{0}";

	private Coroutine m_timerCoroutine;

	private float m_remainingTime;

	private float m_totalDuration;

	private float m_tickInterval;

	private WaitForSecondsRealtime m_waitForSecondsRealtime;

	private readonly bool m_disposeOnComplete;

	private readonly TimerEvents m_events;

	private readonly string m_timerName;

	public TimerState CurrentState { get; private set; }

	public float RemainingTime => 0f;

	public TimerDisposable(bool disposeOnComplete, TimerEvents timerEvents = null, int debugLogLevel = 0, string timerName = "")
	{
	}

	~TimerDisposable()
	{
	}

	public void StartTimer(float duration, float tickInterval = 1f)
	{
	}

	[IteratorStateMachine(typeof(_003CTimerRoutine_003Ed__20))]
	private IEnumerator TimerRoutine()
	{
		return null;
	}

	public void ForceComplete()
	{
	}

	private void Complete()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Stop()
	{
	}

	public void Dispose()
	{
	}
}
