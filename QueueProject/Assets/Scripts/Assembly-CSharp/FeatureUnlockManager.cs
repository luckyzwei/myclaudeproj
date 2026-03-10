using UnityEngine;

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

	private const string UNLOCKED_KEY = "feature_unlocked_bits";
	private const string FORCED_HOME_KEY = "feature_forced_home_bits";

	private static BitwiseFlag s_unlockedFeaturesBits;

	private static BitwiseFlag s_forcedHomeFeaturesBits;

	private static bool s_isLoaded;

	public static bool IsStoreUnlocked
	{
		get { return GetBit((int)UnlockableFeature.STORE); }
		set { SetBitAndSave((int)UnlockableFeature.STORE, value); }
	}

	public static bool IsLeaderboardUnlocked
	{
		get { return GetBit((int)UnlockableFeature.LEADERBOARD); }
		set { SetBitAndSave((int)UnlockableFeature.LEADERBOARD, value); }
	}

	public static bool IsQueensEventUnlocked
	{
		get { return GetBit((int)UnlockableFeature.QUEENS_EVENT); }
		set { SetBitAndSave((int)UnlockableFeature.QUEENS_EVENT, value); }
	}

	public static bool IsDecoramaUnlocked
	{
		get { return GetBit((int)UnlockableFeature.DECORAMA); }
		set { SetBitAndSave((int)UnlockableFeature.DECORAMA, value); }
	}

	public static bool IsSpinWheelUnlocked
	{
		get { return GetBit((int)UnlockableFeature.SPIN_WHEEL); }
		set { SetBitAndSave((int)UnlockableFeature.SPIN_WHEEL, value); }
	}

	public static bool IsDailyRewardUnlocked
	{
		get { return GetBit((int)UnlockableFeature.DAILY_REWARD); }
		set { SetBitAndSave((int)UnlockableFeature.DAILY_REWARD, value); }
	}

	public static bool IsDailyChallengeUnlocked
	{
		get { return GetBit((int)UnlockableFeature.DAILY_CHALLENGE); }
		set { SetBitAndSave((int)UnlockableFeature.DAILY_CHALLENGE, value); }
	}

	public static bool IsPiggyBankUnlocked
	{
		get { return GetBit((int)UnlockableFeature.PIGGY_BANK); }
		set { SetBitAndSave((int)UnlockableFeature.PIGGY_BANK, value); }
	}

	public static bool IsWinStreakUnlocked
	{
		get { return GetBit((int)UnlockableFeature.WIN_STREAK); }
		set { SetBitAndSave((int)UnlockableFeature.WIN_STREAK, value); }
	}

	public static bool IsPVPChallengeButtonUnlocked
	{
		get { return GetBit((int)UnlockableFeature.PVP_CHALLENGE_BUTTON); }
		set { SetBitAndSave((int)UnlockableFeature.PVP_CHALLENGE_BUTTON, value); }
	}

	private static bool GetBit(int index)
	{
		LoadBits();
		return s_unlockedFeaturesBits[index];
	}

	private static void SetBitAndSave(int index, bool value)
	{
		LoadBits();
		s_unlockedFeaturesBits[index] = value;
		SaveBits();
	}

	private static void LoadBits()
	{
		if (s_isLoaded) return;
		s_isLoaded = true;
		int unlocked = PlayerPrefs.GetInt(UNLOCKED_KEY, 0);
		int forced = PlayerPrefs.GetInt(FORCED_HOME_KEY, 0);
		s_unlockedFeaturesBits = new BitwiseFlag(unlocked);
		s_forcedHomeFeaturesBits = new BitwiseFlag(forced);
	}

	private static void SaveBits()
	{
		PlayerPrefs.SetInt(UNLOCKED_KEY, s_unlockedFeaturesBits.ToInt());
		PlayerPrefs.SetInt(FORCED_HOME_KEY, s_forcedHomeFeaturesBits.ToInt());
		PlayerPrefs.Save();
	}

	public static bool IsAlreadyForcedToHomeForFeature(UnlockableFeature feature)
	{
		LoadBits();
		return s_forcedHomeFeaturesBits[(int)feature];
	}

	public static void ForcedToHomeForFeature(UnlockableFeature feature)
	{
		LoadBits();
		s_forcedHomeFeaturesBits[(int)feature] = true;
		SaveBits();
	}

	public static void TryMigrate()
	{
		// Migration from old save format - no-op for fresh installs
	}
}
