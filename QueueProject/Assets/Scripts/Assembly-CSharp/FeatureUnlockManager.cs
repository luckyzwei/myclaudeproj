public static class FeatureUnlockManager
{
	public enum UnlockableFeature
	{
		DAILY_CHALLENGE = 1,
		LEADERBOARD = 2,
		STORE = 3,
		SPIN_WHEEL = 4,
		QUEENS_EVENT = 5,
		JIGSAW_PUZZLE = 6,
		PIGGY_BANK = 7,
		DECORAMA = 8,
		DAILY_REWARD = 9,
		WIN_STREAK = 10,
		PVP_CHALLENGE_BUTTON = 11
	}

	private static BitwiseFlag s_unlockedFeaturesBits;

	private static BitwiseFlag s_forcedHomeFeaturesBits;

	private static bool s_isLoaded;

	public static bool IsStoreUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsLeaderboardUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsQueensEventUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsDecoramaUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsSpinWheelUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsDailyRewardUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsDailyChallengeUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsPiggyBankUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsWinStreakUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsPVPChallengeButtonUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static bool GetBit(int index)
	{
		return false;
	}

	private static void SetBitAndSave(int index, bool value)
	{
	}

	private static void LoadBits()
	{
	}

	private static void SaveBits()
	{
	}

	public static bool IsAlreadyForcedToHomeForFeature(UnlockableFeature feature)
	{
		return false;
	}

	public static void ForcedToHomeForFeature(UnlockableFeature feature)
	{
	}

	public static void TryMigrate()
	{
	}
}
