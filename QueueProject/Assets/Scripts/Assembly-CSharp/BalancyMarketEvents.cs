using System;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;

public static class BalancyMarketEvents
{
	public enum PurchaseType
	{
		NONE = 0,
		FREE = 1,
		IAP = 2,
		SOFT = 3,
		AD = 4
	}

	public static event Action<StoreItem, PurchaseType, string> OnProductPurchased
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

	public static event Action<Price, PurchaseType, string> OnPricePaid
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

	public static event Action<string> PurchaseAttempted
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

	public static event Action ProductsFetched
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

	public static void SendProductPurchased(StoreItem product, PurchaseType type, string analyticInfo)
	{
	}

	public static void SendPricePaid(Price price, PurchaseType type, string analyticInfo)
	{
	}

	public static void SendPurchaseAttempted(string analyticInfo)
	{
	}

	public static void SendProductsFetched()
	{
	}
}
