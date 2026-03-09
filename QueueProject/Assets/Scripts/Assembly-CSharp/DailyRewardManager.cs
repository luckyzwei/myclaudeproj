using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class DailyRewardManager : MonoSingleton<DailyRewardManager>
{
	public delegate void DailyRewardDelegate(LiveOps.DailyBonus.RewardInfo dailyReward);

	[CompilerGenerated]
	private sealed class _003CListenForNewDay_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyRewardManager _003C_003E4__this;

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
		public _003CListenForNewDay_003Ed__17(int _003C_003E1__state)
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

	public const int DAYS_IN_WEEK = 7;

	public const string NOTIFICATION_WIDGET_ID = "DailyReward";

	protected PopUpDailyReward m_popUpDailyReward;

	public static event DailyRewardDelegate DailyRewardObtained
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

	public static event DailyRewardDelegate NewDayStarted
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

	public static void DailyRewardObtainedEvent(LiveOps.DailyBonus.RewardInfo dailyReward)
	{
	}

	public static void SendNewDayStartedEvent(LiveOps.DailyBonus.RewardInfo dailyReward)
	{
	}

	protected override void Init()
	{
	}

	private void CheckForNewDayReset()
	{
	}

	public void ShowDailyReward()
	{
	}

	public virtual LiveOps.DailyBonus.RewardInfo GetTodaysReward()
	{
		return default(LiveOps.DailyBonus.RewardInfo);
	}

	public virtual LiveOps.DailyBonus.RewardInfo[] GetWeeklyReward()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CListenForNewDay_003Ed__17))]
	private IEnumerator ListenForNewDay()
	{
		return null;
	}

	public long CalculateMSLeftUntilNextDay()
	{
		return 0L;
	}

	protected bool IsANewDay()
	{
		return false;
	}

	public long GetToday()
	{
		return 0L;
	}

	public (int, int) GetTargetDailyRewardWeekAndDayIndex()
	{
		return default((int, int));
	}

	public bool HasClaimedRewardToday()
	{
		return false;
	}

	public bool HasClaimedRewardForIndex(int index)
	{
		return false;
	}

	public int GetNumRewardsClaimedToday()
	{
		return 0;
	}

	protected void IncrementRewardsClaimed(int numClaimed)
	{
	}

	private void ResetClaimedToday()
	{
	}

	protected void OnRewardObtained()
	{
	}

	protected Reward GenerateMultipliedRewardForToday(int multiplier)
	{
		return null;
	}

	public virtual void ClaimDailyRewardForToday(int multiplier, Action onRewardFlowComplete, string rewardPopupPath, string rewardBoxPopupPath, bool rv)
	{
	}
}
