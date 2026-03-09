using System;
using UnityEngine;

public class AvatarsHelper : MonoBehaviour
{
	public const string NOTIFICATION_ID = "avatars";

	private static DateTime thresholdDate;

	public static bool HasAvatarInInventory(string clientId)
	{
		return false;
	}

	public static void SelectedAvatar(string clientId)
	{
	}

	public static bool HasAvatarBeenSelected(string clientId)
	{
		return false;
	}

	public static void CheckForNotification()
	{
	}

	public static bool IsNew(string clientId, DateTime? introduceDate = null)
	{
		return false;
	}

	public static bool IsFree(string clientID)
	{
		return false;
	}

	public static DateTime GetIntroduceDate(string clientID)
	{
		return default(DateTime);
	}
}
