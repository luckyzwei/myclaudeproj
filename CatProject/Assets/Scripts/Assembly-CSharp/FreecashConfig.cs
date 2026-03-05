using UnityEngine;

public class FreecashConfig
{
	private static bool IsAOS => Application.platform == RuntimePlatform.Android;

	private static bool IsIOS => Application.platform == RuntimePlatform.IPhonePlayer;

	public static string GetSub()
	{
		if (IsAOS) return "android";
		if (IsIOS) return "ios";
		return "unknown";
	}

	public static string GetCampaign()
	{
		if (IsAOS) return "aos_campaign";
		if (IsIOS) return "ios_campaign";
		return "default_campaign";
	}

	public static string GetSource()
	{
		if (IsAOS) return "aos_source";
		if (IsIOS) return "ios_source";
		return "default_source";
	}

	public static string GetUrlIsLinked()
	{
		return "https://api.freecash.com/v1/isLinked";
	}
}
