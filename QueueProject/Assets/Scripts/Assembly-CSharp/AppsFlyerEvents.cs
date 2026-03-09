using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KWAttribution.Attribution;

public class AppsFlyerEvents
{
	public static event Action<string, Dictionary<string, string>> AppsFlyerRegisteredEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<KWAttribution.Attribution.ProductData> OnPurchaseValidated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> OnPurchaseFailedValidation
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void SendAppsFlyerRegisteredEvent(string eventName, Dictionary<string, string> parameters)
	{
	}

	public static void SendOnPurchaseValidated(KWAttribution.Attribution.ProductData data)
	{
	}

	public static void SendOnPurchaseFailedValidation(string error)
	{
	}
}
