using System;
using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.UI;

public class SimpleCoinPurchaseButton : MonoBehaviour
{
	[SerializeField]
	[Autohook]
	private Button m_button;

	[SerializeField]
	private TextWrapper m_itemAmountText;

	[Header("Shop")]
	[SerializeField]
	private bool m_openShopWhenCantAfford;

	[SerializeField]
	private PopUpBase m_shopPopUp;

	[SerializeField]
	private bool m_recheckAfterClosingShop;

	private int m_coinPrice;

	private Action<bool> m_onItemPurchased;

	public void Config(int coinPrice, Action<bool> onItemPurchased)
	{
	}

	private void OnButtonPressed()
	{
	}

	private void OnStoreClosed()
	{
	}

	private bool CanAfford()
	{
		return false;
	}
}
