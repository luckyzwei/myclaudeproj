using System.Runtime.CompilerServices;
using Balancy.Models.Store;

public static class StoreEvents
{
	public delegate void StringCategoryDelegate(string textString, Category category);

	public delegate void ProductDelegate(Product product);

	public delegate void PurchaseDelegate(Product product, bool wasSuccess);

	public static event StringCategoryDelegate ItemEquipped
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

	public static event PurchaseDelegate ItemPurchased
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

	public static event ProductDelegate StartedItemPurchase
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

	public static void SendItemEquippedEvent(string clientID, Category category)
	{
	}

	public static void SendItemPurchased(Product product, bool wasSuccess)
	{
	}

	public static void SendStartedItemPurchaseEvent(Product product)
	{
	}
}
