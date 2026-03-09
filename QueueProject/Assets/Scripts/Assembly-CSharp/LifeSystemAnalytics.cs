using UnityEngine;

public class LifeSystemAnalytics : MonoBehaviour
{
	private const string LIFE_LOST = "life_lost";

	private const string LIFE_GAINED = "life_gained";

	private const string OUT_OF_LIVES = "out_of_lives";

	private static LifeSystemDataPacket s_lifeSystemDataPacket;

	public static void PopulateDataPacket()
	{
	}

	public static void SendLifeLost()
	{
	}

	public static void SendLifeGained()
	{
	}

	public static void SendOutOfLives()
	{
	}

	private static void SendProgressRewardEvent(string eventName)
	{
	}
}
