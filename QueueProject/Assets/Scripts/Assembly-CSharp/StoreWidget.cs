using Balancy.Models.Store;
using KWAnalytics.Analytics;
using UnityEngine;
using UnityEngine.Serialization;

public class StoreWidget : MonoBehaviour
{
	[FormerlySerializedAs("m_shopBuilder")]
	[SerializeField]
	private StoreBuilder m_storeBuilder;

	[SerializeField]
	private Category m_category;

	[Header("Optional")]
	[SerializeField]
	private GameObject m_loadingSpinner;

	private ShopScreenDataPacket m_shopScreenDataPacket;

	private ShopPurchaseDataPacket m_shopPurchaseDataPacket;

	private void Awake()
	{
	}

	private void BalancyMarketEvents_ProductsFetched()
	{
	}

	private void OnDestroy()
	{
	}

	private void StoreEventsOnStartedItemPurchase(Product product)
	{
	}

	private void StoreEventsOnItemPurchased(Product product, bool wasSuccess)
	{
	}

	private void Update()
	{
	}
}
