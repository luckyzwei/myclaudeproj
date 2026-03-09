using Balancy.Models;

public static class DailyWinStreakHelper
{
	public const string DAILY_WIN_STREAK_BADGE = "DailyWinStreakBadge";

	public static void EnsureDailyHistoryEntryAtBoot()
	{
	}

	public static bool TryIncreaseWinStreak()
	{
		return false;
	}

	private static bool CanIncreaseWinStreak()
	{
		return false;
	}

	private static void IncreaseWinStreak()
	{
	}

	public static bool HasWinStreakExpired()
	{
		return false;
	}

	public static void ResetWinStreak()
	{
	}

	public static bool HasRepairedToday()
	{
		return false;
	}

	public static void MarkRepairedNow()
	{
	}

	public static void AddToWinStreakHistory(bool isWin)
	{
	}

	public static bool HasPlayerReachedNewMilestone()
	{
		return false;
	}

	public static int GetCurrentMilestone()
	{
		return 0;
	}

	public static float GetWinPercentage()
	{
		return 0f;
	}

	public static DailyWinStreakMilestone GetLastMilestone()
	{
		return null;
	}

	public static DailyWinStreakMilestone GetMilestoneFromLong(long milestoneMetadata)
	{
		return null;
	}
}
