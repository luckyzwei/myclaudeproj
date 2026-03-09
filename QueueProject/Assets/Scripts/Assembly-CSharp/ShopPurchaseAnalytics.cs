using Balancy.Models.Store;
using UnityEngine;

public class ShopPurchaseAnalytics : MonoBehaviour
{
	private const string PURCHASE_EVENT_NAME = "purchase";

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void StoreEventsOnItemPurchased(Product product, bool wasSuccess)
	{
	}

	public void SendPurchaseEvent(Product product, bool fromStore)
	{
	}
}
