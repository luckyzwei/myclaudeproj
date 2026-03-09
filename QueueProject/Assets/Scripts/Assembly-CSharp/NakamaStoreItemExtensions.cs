using System;
using Hiro;

public static class NakamaStoreItemExtensions
{
	private const string PROPERTY_OFFER = "offer";

	private const string OFFER_VALUE_ONE_TIME = "one_time";

	private const string PROPERTY_CONSUMABLE = "consumable";

	private const string CONSUMABLE_VALUE_TRUE = "true";

	private const string PROPERTY_ANY_OWN = "not_show_if_any_own";

	public static bool IsIAP(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool IsSoft(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool CanAfford(this IEconomyListStoreItem storeItem, string currencyId)
	{
		return false;
	}

	public static long GetSoftPrice(this IEconomyListStoreItem storeItem, string currencyId)
	{
		return 0L;
	}

	public static bool CanDisplayInShop(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool IsOneTimePurchase(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool IsConsumable(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool IsProductPurchased(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static bool IsIAPOwned(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	private static bool IsAnyDependencyOwned(this IEconomyListStoreItem storeItem)
	{
		return false;
	}

	public static void Purchase(this IEconomyListStoreItem storeItem, Action<bool> purchasedCallback)
	{
	}
}
