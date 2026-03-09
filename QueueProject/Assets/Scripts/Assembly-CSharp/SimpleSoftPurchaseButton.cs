using System;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.UI;

public class SimpleSoftPurchaseButton : MonoBehaviour
{
	[SerializeField]
	[Autohook]
	private Button m_button;

	[SerializeField]
	private Image m_itemImage;

	[SerializeField]
	private TextWrapper m_itemAmountText;

	[Header("Shop")]
	[SerializeField]
	private bool m_openShopWhenCantAfford;

	[SerializeField]
	private PopUpBase m_shopPopUp;

	private ItemWithAmount m_itemWithAmount;

	private Action<bool> m_onItemPurchased;

	public void Config(ItemWithAmount itemWithAmount, Action<bool> onItemPurchased)
	{
	}

	private void OnButtonPressed()
	{
	}

	private bool CanAfford()
	{
		return false;
	}
}
