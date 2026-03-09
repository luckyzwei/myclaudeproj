using Balancy.Models.Store;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpExpertModeOffer : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-ExpertMode-Offer";

	private const string EXPERT_IAP_ID = "expert_mode";

	[SerializeField]
	private Button m_trialButton;

	[SerializeField]
	private Button m_closeButton;

	[SerializeField]
	private StorePurchaseButton m_storePurchaseButton;

	[SerializeField]
	private Button m_purchaseButton;

	[SerializeField]
	private GameObject m_waitForPurchaseBlocker;

	[SerializeField]
	private PriceWidget m_priceWidget;

	private Product m_product;

	private void Awake()
	{
	}

	private bool CompletedFTUE()
	{
		return false;
	}

	protected override void FinishedIntroAnimation()
	{
	}

	private void ClosePopUp()
	{
	}

	private void TrialButtonPressed()
	{
	}

	private void OnPurchasedCallback(bool successful)
	{
	}

	private void PurchaseButtonPressed()
	{
	}

	protected override void OnDestroy()
	{
	}
}
