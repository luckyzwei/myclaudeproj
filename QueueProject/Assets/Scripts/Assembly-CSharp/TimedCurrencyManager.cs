using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

public class TimedCurrencyManager : MonoSingleton<TimedCurrencyManager>
{
	[CompilerGenerated]
	private sealed class _003CTimerCountdown_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimedCurrencyManager _003C_003E4__this;

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
		public _003CTimerCountdown_003Ed__24(int _003C_003E1__state)
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

	private Coroutine m_timerCoroutine;

	private bool m_initialCheckComplete;

	private HashSet<string> m_activeTimers;

	public event Action<string> TimerStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string> TimerFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action NoAdsStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action NoAdsFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Init()
	{
	}

	private void BalancyBootstrapEventsOnProfileWasReset()
	{
	}

	private void EverythingLoaded()
	{
	}

	private void OnLoadingCompleted()
	{
	}

	private void TryInitialCheck()
	{
	}

	private void CheckAllTimers()
	{
	}

	private void CheckTimer(string clientId)
	{
	}

	private void OnTimerItemAdded(Item item, int count, int slotindex)
	{
	}

	private void StartTimerCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CTimerCountdown_003Ed__24))]
	private IEnumerator TimerCountdown()
	{
		return null;
	}

	private void CompleteTimer(string clientId)
	{
	}

	public long GetRemainingSeconds(string clientId)
	{
		return 0L;
	}

	public long GetNoAdsRemainingSeconds()
	{
		return 0L;
	}

	public bool IsTimerActive(string clientId)
	{
		return false;
	}

	public void ClearTimer(string clientId)
	{
	}
}
