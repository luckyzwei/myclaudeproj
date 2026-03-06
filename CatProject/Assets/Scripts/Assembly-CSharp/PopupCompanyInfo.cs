using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyInfo", false, false)]
public class PopupCompanyInfo : UIBase, ILocalizeRefresh
{
	[SerializeField]
	private ItemCompany ItemCompany;

	[SerializeField]
	private Text RentalFeeText;

	[SerializeField]
	private Text RentalTime;

	[SerializeField]
	private Text RentalTimeDesc;

	[SerializeField]
	private Button ContractBtn;

	[SerializeField]
	private Button ContractAdsBtn;

	[SerializeField]
	private Text ContractPriceText;

	[SerializeField]
	private GameObject ContractCompleteObj;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("IAP")]
	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	[Header("Strike")]
	[SerializeField]
	private GameObject StrikeRoot;

	[SerializeField]
	private Text StrikeDesc;

	private Action ContractAction;

	private BigInteger ContractPrice;

	protected override void Awake()
	{
		base.Awake();
		if (ContractBtn != null) ContractBtn.onClick.AddListener(OnClickContract);
		if (ContractAdsBtn != null) ContractAdsBtn.onClick.AddListener(OnClickContractAds);
	}

	public void Show(int office, int company, Action cb)
	{
		ContractAction = cb;
		ContractPrice = BigInteger.Zero;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (ItemCompany != null) ItemCompany.gameObject.SetActive(true);
		if (ContractCompleteObj != null) ContractCompleteObj.SetActive(false);

		SetStrike(office, company);
		RefreshText();

		base.Show();
	}

	private void OnClickContract()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		ContractAction?.Invoke();
		Hide();
	}

	private void OnClickContractAds()
	{
		ContractAction?.Invoke();
		Hide();
	}

	public void RefreshText()
	{
		if (RentalFeeText != null)
			RentalFeeText.text = ProjectUtility.GetThousandCommaText(ContractPrice);
	}

	private void SetStrike(int office, int company)
	{
		if (StrikeRoot != null) StrikeRoot.SetActive(false);
	}

	private void OnDestroy()
	{
		// Cleanup
	}

	public override void OnHideBefore()
	{
		ContractAction = null;
	}
}
