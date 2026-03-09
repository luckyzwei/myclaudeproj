using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SpecialOfferCooldown
{
	[CompilerGenerated]
	private sealed class _003CAvailableCountdown_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CAvailableCountdown_003Ed__6(int _003C_003E1__state)
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

	private static IEnumerator m_availableCoroutine;

	public static void InitialCheck()
	{
	}

	public static bool IsInCooldown()
	{
		return false;
	}

	public static void AddCooldownTime(long time)
	{
	}

	public static void AddOfferAvailableTime(long time)
	{
	}

	public static bool IsOfferAvailable()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CAvailableCountdown_003Ed__6))]
	private static IEnumerator AvailableCountdown()
	{
		return null;
	}

	public static long GetAvailableRemainingSeconds()
	{
		return 0L;
	}

	private static void AvailableTimeFinished()
	{
	}
}
