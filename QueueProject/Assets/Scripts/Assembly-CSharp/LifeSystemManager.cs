using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

public class LifeSystemManager : MonoSingleton<LifeSystemManager>
{
	public delegate void LifeDelegate(int newLifeCount);

	[CompilerGenerated]
	private sealed class _003CGiveLives_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LifeSystemManager _003C_003E4__this;

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
		public _003CGiveLives_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CInfiniteLivesCountdown_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LifeSystemManager _003C_003E4__this;

		private long _003CinfiniteLivesRemainingSeconds_003E5__2;

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
		public _003CInfiniteLivesCountdown_003Ed__50(int _003C_003E1__state)
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

	public const string LIFE_ITEM_ID = "life";

	public const string INFINITE_LIVES_ID = "infinite_lives";

	private Coroutine m_giveLivesCoroutine;

	private Coroutine m_infiniteLivesCoroutine;

	private bool m_initialCheckComplete;

	public static event LifeDelegate LivesValueChanged
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

	public static event GameplayEvents.BasicDelegate InfiniteLivesExpired
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

	public static event GameplayEvents.BasicDelegate InfiniteLivesStarted
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

	public static void SendLivesValueChanged(int newLifeCount)
	{
	}

	public static void SendInfiniteLivesExpired()
	{
	}

	public static void SendInfiniteLivesStarted()
	{
	}

	private void UnSubscribe()
	{
	}

	protected override void Init()
	{
	}

	private void CoreEventsOnOnSplashScreenCompleted()
	{
	}

	private void TryInitialCheck()
	{
	}

	public void OnProfileLoaded()
	{
	}

	private void TryGiveLives()
	{
	}

	[IteratorStateMachine(typeof(_003CGiveLives_003Ed__24))]
	private IEnumerator GiveLives()
	{
		return null;
	}

	private void OnSmartObjectsInitializedEvent()
	{
	}

	private void OnBalancyProfileReset()
	{
	}

	private void CheckLivesToGive()
	{
	}

	public long GetSecondsUntilNextLife()
	{
		return 0L;
	}

	private void OnNewLifeAdded(Item item, int count, int slotindex)
	{
	}

	public void AddInfiniteLives(long seconds)
	{
	}

	private void OnInfiniteLivesAdded(Item item, int count, int slotindex)
	{
	}

	private void SetFullLives()
	{
	}

	private void OnItemWasRemoved(Item item, int count, int slotindex)
	{
	}

	public bool IsEnabled()
	{
		return false;
	}

	public bool DoesHaveLives()
	{
		return false;
	}

	public bool CheckCanPlay(bool showPopUp = true, Action onPopUpClosed = null)
	{
		return false;
	}

	public int NumLives()
	{
		return 0;
	}

	public bool CanAutoRegenerateLives()
	{
		return false;
	}

	public void AddLives(int amountToAdd = 1)
	{
	}

	public void RemoveLives(int amountToRemove = 1)
	{
	}

	private void IncreaseSequentialLivesLost(int numLost)
	{
	}

	public void ResetSequentialLivesLost()
	{
	}

	private void SetGameLossTime(long time)
	{
	}

	public void ShowLifeLossWarningPopUp(Action onPopUpDismissed, Action onReplayPressed, Action onHomePressed)
	{
	}

	public void ShowLifeLostPopUp(Action onReplayPressed, Action onHomePressed)
	{
	}

	private void CheckInfiniteLives()
	{
	}

	public bool DoesHaveInfiniteLives()
	{
		return false;
	}

	public long GetInfiniteLivesRemainingSeconds()
	{
		return 0L;
	}

	private void CountdownInfiniteLivesTime()
	{
	}

	[IteratorStateMachine(typeof(_003CInfiniteLivesCountdown_003Ed__50))]
	private IEnumerator InfiniteLivesCountdown()
	{
		return null;
	}

	public void SetGameLost()
	{
	}
}
