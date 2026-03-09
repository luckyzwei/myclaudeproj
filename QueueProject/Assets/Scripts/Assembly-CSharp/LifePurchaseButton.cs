using System;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifePurchaseButton : MonoBehaviour
{
	private const string LIFE_RV_LOC = "rv_life_gained";

	[SerializeField]
	[Autohook]
	private Button m_button;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[Header("Rewards")]
	[SerializeField]
	private Image m_heartImage;

	[SerializeField]
	private TextMeshProUGUI m_rewardAmount;

	[Header("Shop Popup")]
	[SerializeField]
	private bool m_shouldAlwaysTakeToShop;

	[SerializeField]
	private PopUpBase m_shopPopup;

	private Product m_referencedProduct;

	private ItemWithAmount[] m_softPrice;

	private Reward m_reward;

	private Action<bool> m_productPurchasedCallback;

	private void Start()
	{
	}

	public void Config(Product product, Action<bool> purchaseCallback)
	{
	}

	public void ConfigSoft(ItemWithAmount softAmount, Action<bool> purchaseCallback)
	{
	}

	private void SetReward(Reward reward)
	{
	}

	public void OnPurchasePressed()
	{
	}

	private void OnShopClosed()
	{
	}

	private bool CanAfford()
	{
		return false;
	}

	private void TryToBuy()
	{
	}

	private void OnPurchaseCallback(bool didPurchase)
	{
	}
}
