using KWUserInterface;

public static class ProjectScreenManager
{
	public enum ScreenID
	{
		NONE = 0,
		START = 1,
		GAME = 2,
		LEVEL_COMPLETE = 3,
		GAME_OVER = 4,
		LEVEL_COMPLETE_LEAGUE = 5,
		ROYAL_TOURNAMENT_FIND = 6,
		ROYAL_TOURNAMENT_RESULT = 7,
		PVP_RESULT = 8
	}

	public static string[] ScreenDir = new string[]
	{
		"",                                              // NONE
		"prefabs/screens/Screen-Home",                   // START
		"prefabs/screens/Screen-Game",                   // GAME
		"prefabs/screens/Screen-LevelComplete",          // LEVEL_COMPLETE
		"prefabs/screens/Screen-GameOver",               // GAME_OVER
		"prefabs/screens/Screen-LevelComplete",          // LEVEL_COMPLETE_LEAGUE (reuse)
		"prefabs/screens/Screen-RoyalTournamentFindPlayers", // ROYAL_TOURNAMENT_FIND
		"prefabs/screens/Screen-RoyalTournamentResult",  // ROYAL_TOURNAMENT_RESULT
		"prefabs/screens/Screen-PVP-Result"              // PVP_RESULT
	};

	public static Screen PushScreen(ScreenID screen, bool pushBehind = false, bool disablePrevious = true)
	{
		string dir = GetScreenDir(screen);
		if (string.IsNullOrEmpty(dir)) return null;
		return ScreenManager.Instance?.PushScreen(dir, pushBehind, disablePrevious);
	}

	public static Screen ReplaceScreen(ScreenID screen, bool pushBehind = false)
	{
		string dir = GetScreenDir(screen);
		UnityEngine.Debug.Log($"[ProjectScreenManager] ReplaceScreen({screen}) → dir='{dir}', ScreenManager.Instance={ScreenManager.Instance != null}");
		if (string.IsNullOrEmpty(dir)) return null;
		return ScreenManager.Instance?.ReplaceScreen(dir, pushBehind);
	}

	public static Screen PushScreen(string screen, bool pushBehind = false, bool disablePrevious = true)
	{
		if (string.IsNullOrEmpty(screen)) return null;
		return ScreenManager.Instance?.PushScreen(screen, pushBehind, disablePrevious);
	}

	public static Screen ReplaceScreen(string screen, bool pushBehind = false)
	{
		if (string.IsNullOrEmpty(screen)) return null;
		return ScreenManager.Instance?.ReplaceScreen(screen, pushBehind);
	}

	public static void PopScreen()
	{
		ScreenManager.Instance?.PopScreen();
	}

	private static string GetScreenDir(ScreenID screen)
	{
		int idx = (int)screen;
		if (idx < 0 || idx >= ScreenDir.Length) return null;
		return ScreenDir[idx];
	}
}
