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

	public DCDate SelectedDate => null;

	public DCDate CompletedDate => null;

	protected override void Init()
	{
	}

	public void OpenDailyChallenge(string dailyChallengeID, bool firstShow = true)
	{
	}

	public int TotalDatesPlayedInMonthCount(string dailyChallengeID, bool includeNewOnes = true)
	{
		return 0;
	}

	public int TotalDatesPlayedInMonthCount(string dailyChallengeID, DCDate date, bool includeNewOnes = true)
	{
		return 0;
	}

	public int LastUnPlayedDate()
	{
		return 0;
	}

	public bool HasMonthlyIapForDate(DCDate dcDate)
	{
		return false;
	}

	public bool IsDatePlayed(DCDate dcDate, string dailyChallengeID, bool includeNew = true)
	{
		return false;
	}

	public bool IsNewDatePlayed(DCDate dcDate, string dailyChallengeID, bool markAsOld)
	{
		return false;
	}

	public bool IsDateFailed(DCDate dcDate, string dailyChallengeID)
	{
		return false;
	}

	protected DailyChallenge GetSelectedDailyChallenge()
	{
		return null;
	}

	public bool IsUnlocked(string id)
	{
		return false;
	}

	public void StartDailyChallenge()
	{
	}

	public void CompleteDailyChallenge()
	{
	}

	private void TrySwallowNotification()
	{
	}

	public void FailDailyChallenge()
	{
	}

	public void SelectDate(DCDate dcDate)
	{
	}

	public void PreviousMonthDate()
	{
	}

	public void NextMonthDate()
	{
	}

	public List<int> GetNewlyCompletedDaysInMonth(string dailyChallengeId, DCDate date, bool markAsOld = true)
	{
		return null;
	}

	public bool IsNewTrophyAvailable(string dailyChallengeId, DCDate dcDate)
	{
		return false;
	}

	public void GetMinMaxForTrophy(string dailyChallengeId, DCDate dcDate, int index, out int min, out int max)
	{
		min = default(int);
		max = default(int);
	}

	public int GetCurrentTrophyIndex(string dailyChallengeId, int daysCompleted, DCDate dcDate, bool clamp = true)
	{
		return 0;
	}

	public bool HasFreeChance(string clientId, bool checkSelectedDate = false)
	{
		return false;
	}

	private bool IsSameDate(DCDate dcDate, DateTime dateTime)
	{
		return false;
	}

	public void ConsumeFreeChance()
	{
	}

	public bool IsThereAnyChallengeLeft(string dailyChallengeID)
	{
		return false;
	}

	public void PurchasedNoAdsForDC()
	{
	}
}
