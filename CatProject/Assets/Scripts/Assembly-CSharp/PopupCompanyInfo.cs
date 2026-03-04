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
	}

	public void Show(int office, int company, Action cb)
	{
	}

	private void OnClickContract()
	{
	}

	private void OnClickContractAds()
	{
	}

	public void RefreshText()
	{
	}

	private void SetStrike(int office, int company)
	{
	}

	private void OnDestroy()
	{
	}

	public override void OnHideBefore()
	{
	}
}
