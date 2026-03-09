using UnityEngine;

public class KPFGenericAnalytics : MonoBehaviour
{
	public const string KPF_GAME_START = "kpf_game_start";

	public const string KPF_GAME_RESUME = "kpf_game_resume";

	public const string KPF_GAME_LOST = "kpf_game_lost";

	public const string KPF_GAME_WON = "kpf_game_won";

	public static void SendGenericAnalytic(string analyticName, string context = null)
	{
	}

	public static void SendGameResumedAnalytics(string context, string options)
	{
	}

	public static void SendGameLossAnalytics(string context, string options)
	{
	}

	public static string GetGameModeString()
	{
		return null;
	}
}
