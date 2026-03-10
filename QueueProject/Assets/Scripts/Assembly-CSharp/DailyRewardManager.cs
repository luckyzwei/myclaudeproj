using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

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
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CListenForNewDay_003Ed__17(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					goto case 1;
				case 1:
					// Wait until a new day starts
					long msLeft = _003C_003E4__this.CalculateMSLeftUntilNextDay();
					if (msLeft > 60000)
					{
						_003C_003E2__current = new WaitForSeconds(60f);
						_003C_003E1__state = 1;
						return true;
					}
					if (msLeft > 0)
					{
						_003C_003E2__current = new WaitForSeconds(msLeft / 1000f);
						_003C_003E1__state = 2;
						return true;
					}
					goto case 2;
				case 2:
					_003C_003E1__state = -1;
					_003C_003E4__this.CheckForNewDayReset();
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
		void IEnumerator.Reset() { }
	}

	public const int DAYS_IN_WEEK = 7;

	public const string NOTIFICATION_WIDGET_ID = "DailyReward";

	private const string LAST_CLAIM_DAY_KEY = "daily_reward_last_claim_day";
	private const string REWARDS_CLAIMED_TODAY_KEY = "daily_reward_claimed_today";
	private const string REWARD_WEEK_INDEX_KEY = "daily_reward_week_index";

	protected PopUpDailyReward m_popUpDailyReward;

	private static DailyRewardDelegate _DailyRewardObtained;
	public static event DailyRewardDelegate DailyRewardObtained
	{
		add { _DailyRewardObtained += value; }
		remove { _DailyRewardObtained -= value; }
	}

	private static DailyRewardDelegate _NewDayStarted;
	public static event DailyRewardDelegate NewDayStarted
	{
		add { _NewDayStarted += value; }
		remove { _NewDayStarted -= value; }
	}

	public static void DailyRewardObtainedEvent(LiveOps.DailyBonus.RewardInfo dailyReward)
	{
		_DailyRewardObtained?.Invoke(dailyReward);
	}

	public static void SendNewDayStartedEvent(LiveOps.DailyBonus.RewardInfo dailyReward)
	{
		_NewDayStarted?.Invoke(dailyReward);
	}

	protected override void Init()
	{
		if (IsANewDay())
			ResetClaimedToday();
		StartCoroutine(ListenForNewDay());
	}

	private void CheckForNewDayReset()
	{
		if (IsANewDay())
		{
			ResetClaimedToday();
			var todayReward = GetTodaysReward();
			SendNewDayStartedEvent(todayReward);

			if (NotificationWidgetManager.Exist)
				NotificationWidgetManager.Instance.AddNotification(NOTIFICATION_WIDGET_ID);
		}
	}

	public void ShowDailyReward()
	{
		// Show the daily reward popup
		if (m_popUpDailyReward == null)
		{
			var prefab = Resources.Load<GameObject>("prefabs/popups/PopUp-WeeklyVIPRewards");
			if (prefab != null)
			{
				var go = Instantiate(prefab);
				m_popUpDailyReward = go.GetComponent<PopUpDailyReward>();
			}
		}
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
		var d = new _003CListenForNewDay_003Ed__17(0);
		d._003C_003E4__this = this;
		return d;
	}

	public long CalculateMSLeftUntilNextDay()
	{
		DateTime now = DateTime.UtcNow;
		DateTime nextDay = now.Date.AddDays(1);
		TimeSpan remaining = nextDay - now;
		return (long)remaining.TotalMilliseconds;
	}

	protected bool IsANewDay()
	{
		long today = GetToday();
		long lastClaim = PlayerPrefs.GetInt(LAST_CLAIM_DAY_KEY, 0);
		return today > lastClaim;
	}

	public long GetToday()
	{
		DateTime now = DateTime.UtcNow;
		return now.Year * 1000 + now.DayOfYear;
	}

	public (int, int) GetTargetDailyRewardWeekAndDayIndex()
	{
		int weekIndex = PlayerPrefs.GetInt(REWARD_WEEK_INDEX_KEY, 0);
		int dayIndex = GetNumRewardsClaimedToday();
		return (weekIndex, dayIndex);
	}

	public bool HasClaimedRewardToday()
	{
		return GetNumRewardsClaimedToday() > 0 && !IsANewDay();
	}

	public bool HasClaimedRewardForIndex(int index)
	{
		return GetNumRewardsClaimedToday() > index;
	}

	public int GetNumRewardsClaimedToday()
	{
		if (IsANewDay()) return 0;
		return PlayerPrefs.GetInt(REWARDS_CLAIMED_TODAY_KEY, 0);
	}

	protected void IncrementRewardsClaimed(int numClaimed)
	{
		int current = GetNumRewardsClaimedToday();
		PlayerPrefs.SetInt(REWARDS_CLAIMED_TODAY_KEY, current + numClaimed);
		PlayerPrefs.SetInt(LAST_CLAIM_DAY_KEY, (int)GetToday());
		PlayerPrefs.Save();
	}

	private void ResetClaimedToday()
	{
		PlayerPrefs.SetInt(REWARDS_CLAIMED_TODAY_KEY, 0);
		PlayerPrefs.Save();
	}

	protected void OnRewardObtained()
	{
		IncrementRewardsClaimed(1);

		if (NotificationWidgetManager.Exist)
			NotificationWidgetManager.Instance.SwallowNotification(NOTIFICATION_WIDGET_ID);

		// Advance week index if all 7 days claimed
		var (weekIndex, dayIndex) = GetTargetDailyRewardWeekAndDayIndex();
		if (dayIndex >= DAYS_IN_WEEK)
		{
			PlayerPrefs.SetInt(REWARD_WEEK_INDEX_KEY, weekIndex + 1);
			PlayerPrefs.Save();
		}
	}

	protected Reward GenerateMultipliedRewardForToday(int multiplier)
	{
		// Rewards handled via Balancy
		return null;
	}

	public virtual void ClaimDailyRewardForToday(int multiplier, Action onRewardFlowComplete, string rewardPopupPath, string rewardBoxPopupPath, bool rv)
	{
		var todayReward = GetTodaysReward();
		OnRewardObtained();
		DailyRewardObtainedEvent(todayReward);
		onRewardFlowComplete?.Invoke();
	}
}
