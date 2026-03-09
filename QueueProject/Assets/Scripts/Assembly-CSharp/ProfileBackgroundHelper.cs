using Balancy.Models;
using UnityEngine;
using UnityEngine.UI;

public class ProfileBackgroundHelper : MonoBehaviour
{
	public const string NOTIFICATION_ID = "profile_backgrounds";

	public const string PROFILE_BACKGROUND_METADATA_KEY = "profileBackground";

	public const string DEFAULT_CLIENT_ID = "DEFAULT";

	public static void RegisterItems()
	{
	}

	public static void UnlockedBackground(string clientId)
	{
	}

	public static bool IsBackgroundUnlocked(string clientId)
	{
		return false;
	}

	public static bool IsBackgroundSelected(string clientId)
	{
		return false;
	}

	public static string GetSelectedBackground()
	{
		return null;
	}

	public static void SelectedBackground(string clientId)
	{
	}

	public static bool HasBeenSelected(string clientId)
	{
		return false;
	}

	public static void CheckForNotification()
	{
	}

	public static bool IsNew(string clientId)
	{
		return false;
	}

	public static bool IsFree(string clientID)
	{
		return false;
	}

	public static bool IsFree(KwaleePrice dataPrice)
	{
		return false;
	}

	public static void SetImage(string profileClientId, Image image)
	{
	}
}
