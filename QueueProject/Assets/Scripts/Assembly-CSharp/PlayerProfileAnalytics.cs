using UnityEngine;

public class PlayerProfileAnalytics : MonoBehaviour
{
	private const string PLAYER_PROFILE_OPENED = "player_profile_opened";

	private const string PLAYER_PROFILE_CHANGED = "player_profile_changed";

	public static void SendPlayerProfileOpened(string source)
	{
	}

	public static void SendPlayerProfileChanged(string source, string whatChanged)
	{
	}

	private static void SendPlayerProfileEvent(string eventName, string source, string whatChanged)
	{
	}
}
