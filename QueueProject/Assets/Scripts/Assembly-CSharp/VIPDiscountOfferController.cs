using Balancy.Models.Store;
using UnityEngine.UI;
using UnityEngine;

public class VIPDiscountOfferController : MonoBehaviour
{
	private const string ITEM_CLIENT_ID = "queensmaster_subscription_week_1";

	[SerializeField]
	private Text m_discountPercentageText;

	[SerializeField]
	private PriceWidget m_priceWidget;

	private void Awake()
	{
	}

	public void ShowDiscountedPrice()
	{
	}

	private Subscription GetSubscription()
	{
		return null;
	}
}
