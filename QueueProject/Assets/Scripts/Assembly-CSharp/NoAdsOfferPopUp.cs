using System;
using Balancy;
using Balancy.Models.Store;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class NoAdsOfferPopUp : PopUpBase, INoAdsOfferInterface
{
	private const string ORIGINAL_PRICE_FALLBACK = "FREE";

	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-NoAdsOffer";

	[SerializeField]
	private StorePurchaseButton m_storePurchaseButton24H;

	[SerializeField]
	private PriceWidget m_priceWidget24H;

	[Space]
	[SerializeField]
	private StorePurchaseButton m_storePurchaseButtonForEver;

	[SerializeField]
	private PriceWidget m_priceWidgetForever;

	[Header("Optional")]
	[SerializeField]
	private TextMeshProUGUI m_originalPriceText24H;

	[SerializeField]
	private TextMeshProUGUI m_originalPriceTextForEver;

	public string GetPrefabPath()
	{
		return null;
	}

	public void Config(UnnyProduct originalProduct, Product discountedProduct, Action callback)
	{
	}

	public void Config(UnnyProduct originalProduct24H, Product discountedProduct24H, UnnyProduct originalProductForEver, Product discountedProductForEver)
	{
	}

	private void PurchaseComplete24H(bool purchased)
	{
	}

	private void PurchaseCompleteForEver(bool purchased)
	{
	}

	public void OKWithAdsClicked()
	{
	}
}
