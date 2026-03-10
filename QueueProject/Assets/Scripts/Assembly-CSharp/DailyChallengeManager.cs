using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;

public class DailyChallengeManager : MonoSingleton<DailyChallengeManager>
{
	public const string NOTIFICATION_WIDGET_ID = "DailyChallenge";

	[SerializeField]
	private DailyChallenge[] m_dailyChallenges;

	private DCDate m_selectedDcDate;

	private DCDate m_completedDcDate;

	private string m_selectedDcID;

	private List<int> m_newlyPlayedDays;

	public DCDate SelectedDate => m_selectedDcDate;

	public DCDate CompletedDate => m_completedDcDate;

	protected override void Init()
	{
		m_selectedDcDate = DCDate.LatestDate();
		m_newlyPlayedDays = new List<int>();
	}

	public void OpenDailyChallenge(string dailyChallengeID, bool firstShow = true)
	{
		m_selectedDcID = dailyChallengeID;
		var dc = GetDailyChallengeByID(dailyChallengeID);
		if (dc != null)
			dc.ShowDailyChallengePopup(firstShow);
	}

	public int TotalDatesPlayedInMonthCount(string dailyChallengeID, bool includeNewOnes = true)
	{
		return TotalDatesPlayedInMonthCount(dailyChallengeID, m_selectedDcDate, includeNewOnes);
	}

	public int TotalDatesPlayedInMonthCount(string dailyChallengeID, DCDate date, bool includeNewOnes = true)
	{
		int count = 0;
		int daysInMonth = date.DaysInMonth();
		for (int day = 1; day <= daysInMonth; day++)
		{
			var checkDate = new DCDate(date.year, date.month, day);
			if (IsDatePlayed(checkDate, dailyChallengeID, includeNewOnes))
				count++;
		}
		return count;
	}

	public int LastUnPlayedDate()
	{
		if (m_selectedDcDate == null) return 1;
		var today = DCDate.LatestDate();
		int daysInMonth = m_selectedDcDate.DaysInMonth();
		int maxDay = m_selectedDcDate.IsLatestMonth() ? today.day : daysInMonth;

		for (int day = maxDay; day >= 1; day--)
		{
			var checkDate = new DCDate(m_selectedDcDate.year, m_selectedDcDate.month, day);
			if (!DailyChallengeDataManager.IsDayCompleted(checkDate, m_selectedDcID))
				return day;
		}
		return 1;
	}

	public bool HasMonthlyIapForDate(DCDate dcDate)
	{
		// Check if there's a monthly IAP offer for this date's month
		return false;
	}

	public bool IsDatePlayed(DCDate dcDate, string dailyChallengeID, bool includeNew = true)
	{
		bool completed = DailyChallengeDataManager.IsDayCompleted(dcDate, dailyChallengeID);
		if (!completed) return false;
		if (!includeNew && DailyChallengeDataManager.IsDayNew(dcDate, dailyChallengeID))
			return false;
		return true;
	}

	public bool IsNewDatePlayed(DCDate dcDate, string dailyChallengeID, bool markAsOld)
	{
		bool isNew = DailyChallengeDataManager.IsDayNew(dcDate, dailyChallengeID);
		if (isNew && markAsOld)
			DailyChallengeDataManager.MarkDayOld(dcDate, dailyChallengeID);
		return isNew;
	}

	public bool IsDateFailed(DCDate dcDate, string dailyChallengeID)
	{
		return DailyChallengeDataManager.IsDayFailed(dcDate, dailyChallengeID);
	}

	protected DailyChallenge GetSelectedDailyChallenge()
	{
		return GetDailyChallengeByID(m_selectedDcID);
	}

	private DailyChallenge GetDailyChallengeByID(string id)
	{
		if (m_dailyChallenges == null) return null;
		foreach (var dc in m_dailyChallenges)
		{
			if (dc != null && dc.DailyChallengeID == id)
				return dc;
		}
		return m_dailyChallenges.Length > 0 ? m_dailyChallenges[0] : null;
	}

	public bool IsUnlocked(string id)
	{
		return FeatureUnlockManager.IsDailyChallengeUnlocked;
	}

	public void StartDailyChallenge()
	{
		var dc = GetSelectedDailyChallenge();
		if (dc != null)
			dc.OnChallengeStarted();
	}

	public void CompleteDailyChallenge()
	{
		if (m_selectedDcDate != null && m_selectedDcID != null)
		{
			m_completedDcDate = new DCDate(m_selectedDcDate);
			DailyChallengeDataManager.SetDayCompleted(m_selectedDcDate, m_selectedDcID, true);

			if (m_newlyPlayedDays == null) m_newlyPlayedDays = new List<int>();
			m_newlyPlayedDays.Add(m_selectedDcDate.day);

			var dc = GetSelectedDailyChallenge();
			if (dc != null)
				dc.OnChallengeComplete();

			GameplayEvents.SendDailyChallengeCompleted();
		}
		TrySwallowNotification();
	}

	private void TrySwallowNotification()
	{
		if (NotificationWidgetManager.Exist)
			NotificationWidgetManager.Instance.SwallowNotification(NOTIFICATION_WIDGET_ID);
	}

	public void FailDailyChallenge()
	{
		if (m_selectedDcDate != null && m_selectedDcID != null)
		{
			DailyChallengeDataManager.SetDayFailed(m_selectedDcDate, m_selectedDcID);
			var dc = GetSelectedDailyChallenge();
			if (dc != null)
				dc.OnChallengeFailed();
			GameplayEvents.SendDailyChallengeFailed();
		}
	}

	public void SelectDate(DCDate dcDate)
	{
		m_selectedDcDate = dcDate != null ? new DCDate(dcDate) : DCDate.LatestDate();
		var dc = GetSelectedDailyChallenge();
		if (dc != null)
			dc.OnDailyChallengeWidgetUpdated(m_selectedDcDate);
	}

	public void PreviousMonthDate()
	{
		if (m_selectedDcDate == null) return;
		int newMonth = m_selectedDcDate.month - 1;
		int newYear = m_selectedDcDate.year;
		if (newMonth < 1) { newMonth = 12; newYear--; }
		m_selectedDcDate = new DCDate(newYear, newMonth, 1);
		GameplayEvents.SendDailyChallengeMonthChanged(m_selectedDcDate.month);
	}

	public void NextMonthDate()
	{
		if (m_selectedDcDate == null) return;
		int newMonth = m_selectedDcDate.month + 1;
		int newYear = m_selectedDcDate.year;
		if (newMonth > 12) { newMonth = 1; newYear++; }
		m_selectedDcDate = new DCDate(newYear, newMonth, 1);
		GameplayEvents.SendDailyChallengeMonthChanged(m_selectedDcDate.month);
	}

	public List<int> GetNewlyCompletedDaysInMonth(string dailyChallengeId, DCDate date, bool markAsOld = true)
	{
		var result = new List<int>();
		int daysInMonth = date.DaysInMonth();
		for (int day = 1; day <= daysInMonth; day++)
		{
			var checkDate = new DCDate(date.year, date.month, day);
			if (DailyChallengeDataManager.IsDayNew(checkDate, dailyChallengeId))
			{
				result.Add(day);
				if (markAsOld)
					DailyChallengeDataManager.MarkDayOld(checkDate, dailyChallengeId);
			}
		}
		return result;
	}

	public bool IsNewTrophyAvailable(string dailyChallengeId, DCDate dcDate)
	{
		int daysPlayed = TotalDatesPlayedInMonthCount(dailyChallengeId, dcDate, true);
		int currentTrophy = GetCurrentTrophyIndex(dailyChallengeId, daysPlayed, dcDate);
		int prevTrophy = GetCurrentTrophyIndex(dailyChallengeId, daysPlayed - 1, dcDate);
		return currentTrophy > prevTrophy;
	}

	public void GetMinMaxForTrophy(string dailyChallengeId, DCDate dcDate, int index, out int min, out int max)
	{
		// Trophy tiers: Bronze (5), Silver (15), Gold (25+)
		switch (index)
		{
			case 0: min = 0; max = 5; break;
			case 1: min = 5; max = 15; break;
			case 2: min = 15; max = 25; break;
			default: min = 0; max = dcDate.DaysInMonth(); break;
		}
	}

	public int GetCurrentTrophyIndex(string dailyChallengeId, int daysCompleted, DCDate dcDate, bool clamp = true)
	{
		// Trophy tiers: 0=none, 1=bronze, 2=silver, 3=gold
		if (daysCompleted >= 25) return 3;
		if (daysCompleted >= 15) return 2;
		if (daysCompleted >= 5) return 1;
		return 0;
	}

	public bool HasFreeChance(string clientId, bool checkSelectedDate = false)
	{
		int freeChances = DailyChallengeDataManager.GetFreeChances(clientId);
		if (freeChances > 0)
		{
			// Check if we need to reset for a new day
			int today = DateTime.UtcNow.DayOfYear;
			int lastDay = DailyChallengeDataManager.GetLastFreeChanceDay(clientId);
			if (lastDay != today)
			{
				// New day - reset free chances
				DailyChallengeDataManager.SetFreeChances(clientId, 1);
				DailyChallengeDataManager.SetLastFreeChanceDay(clientId, today);
				return true;
			}
			return freeChances > 0;
		}

		// Check if this is first play of the day
		int todayDOY = DateTime.UtcNow.DayOfYear;
		int lastFreeDOY = DailyChallengeDataManager.GetLastFreeChanceDay(clientId);
		if (lastFreeDOY != todayDOY)
		{
			DailyChallengeDataManager.SetFreeChances(clientId, 1);
			DailyChallengeDataManager.SetLastFreeChanceDay(clientId, todayDOY);
			return true;
		}
		return false;
	}

	private bool IsSameDate(DCDate dcDate, DateTime dateTime)
	{
		return dcDate.year == dateTime.Year && dcDate.month == dateTime.Month && dcDate.day == dateTime.Day;
	}

	public void ConsumeFreeChance()
	{
		if (m_selectedDcID != null)
		{
			int current = DailyChallengeDataManager.GetFreeChances(m_selectedDcID);
			if (current > 0)
				DailyChallengeDataManager.SetFreeChances(m_selectedDcID, current - 1);
		}
	}

	public bool IsThereAnyChallengeLeft(string dailyChallengeID)
	{
		if (m_selectedDcDate == null) return false;
		var today = DCDate.LatestDate();
		if (!m_selectedDcDate.IsLatestMonth()) return false;

		for (int day = 1; day <= today.day; day++)
		{
			var checkDate = new DCDate(today.year, today.month, day);
			if (!DailyChallengeDataManager.IsDayCompleted(checkDate, dailyChallengeID))
				return true;
		}
		return false;
	}

	public void PurchasedNoAdsForDC()
	{
		// No-ads purchased for daily challenge - mark all free
		KWCore.SaveData.BucketDailyChallenge.SetIsAllFree(true);
	}
}
