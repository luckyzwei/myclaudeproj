using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPiggyBank : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWPiggyBank/PopUp-PiggyBank";

	[Header("IAP")]
	[SerializeField]
	private Button m_iapButton;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[SerializeField]
	private GameObject m_popUpContent;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	private PrefabReference m_piggyRewardPopUp;

	private Price m_price;

	private void Start()
	{
	}

	private void ConfigureButtons()
	{
	}

	private void ConfigurePrice()
	{
	}

	private void OnPurchasePressed()
	{
	}

	private void OnPaymentComplete(bool success)
	{
	}

	private void Reward()
	{
	}

	private void OnRewardGiven()
	{
	}

	private void TogglePurchasedElements(bool purchaseComplete)
	{
	}
}
