using System;
using Balancy.Models;
using Balancy.Models.SmartObjects;

public static class StoreItemExtensions
{
	[Obsolete("FirstItem is deprecated, please use FirstItem<T> instead.")]
	public static KwaleeItem FirstItem(this Price price)
	{
		return null;
	}

	public static T FirstItem<T>(this Price price) where T : Item
	{
		return null;
	}

	public static int FirstValue(this Price price)
	{
		return 0;
	}

	public static bool CanAfford(this Price price)
	{
		return false;
	}

	public static bool CanAfford(this StoreItem product)
	{
		return false;
	}

	public static void Purchase(this StoreItem product, Action<bool> onComplete = null, string adContext = "undefined", string analyticInfo = null)
	{
	}

	public static void Pay(this Price price, Action<bool> onComplete = null, string adContext = "undefined", StoreItem associatedProduct = null, string analyticInfo = null)
	{
	}
}
