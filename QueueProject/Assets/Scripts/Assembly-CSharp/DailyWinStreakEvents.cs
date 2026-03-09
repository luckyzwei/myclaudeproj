using System;
using System.Runtime.CompilerServices;

public static class DailyWinStreakEvents
{
	public delegate void WinStreakIncreasedDelegate(int days, bool isNewRecord);

	public static event WinStreakIncreasedDelegate WinStreakIncreasedEvent
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

	public static event Action<int> WinStreakIncreaseRepaired
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

	public static event Action<int> WinStreakLost
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

	public static event Action WinStreakReset
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

	public static void SendWinStreakIncreasedEvent(int days, bool isNewRecord)
	{
	}

	public static void SendWinStreakIncreaseRepaired(int days)
	{
	}

	public static void SendWinStreakLost(int days)
	{
	}

	public static void SendWinStreakResetEvent()
	{
	}
}
