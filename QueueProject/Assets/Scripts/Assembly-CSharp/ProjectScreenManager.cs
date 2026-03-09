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

	public static string[] ScreenDir;

	public static Screen PushScreen(ScreenID screen, bool pushBehind = false, bool disablePrevious = true)
	{
		return null;
	}

	public static Screen ReplaceScreen(ScreenID screen, bool pushBehind = false)
	{
		return null;
	}

	public static Screen PushScreen(string screen, bool pushBehind = false, bool disablePrevious = true)
	{
		return null;
	}

	public static Screen ReplaceScreen(string screen, bool pushBehind = false)
	{
		return null;
	}

	public static void PopScreen()
	{
	}

	private static string GetScreenDir(ScreenID screen)
	{
		return null;
	}
}
