using System;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyList", false, false)]
public class PopupCompanyList : UIBase, ILocalizeRefresh
{
	[SerializeField]
	private Transform SlotParentsObj;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private GameObject InfoObj;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button InfoDimBtn;

	[SerializeField]
	private Text MaxGradeText;

	[SerializeField]
	private ItemSlotRecommend NoAdsUserCompanySlot;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("ABTest - A")]
	[SerializeField]
	private GameObject ABTestObj_A;

	[SerializeField]
	private Button RefreshBtn;

	[SerializeField]
	private Text RefreshRemainTime;

	[SerializeField]
	private Button RefreshAdBtn;

	[SerializeField]
	private Button RefreshCashBtn;

	[SerializeField]
	private Text RefreshCashValueText;

	[Header("ABTest - B")]
	[SerializeField]
	private GameObject ABTestObj_B;

	[SerializeField]
	private Button NoAdsRefreshBtn;

	[SerializeField]
	private Button FreeRefreshBtn;

	[SerializeField]
	private Button AdsRefreshBtn;

	[SerializeField]
	private Text FreeRefreshRemainCountText;

	[SerializeField]
	private TimeComponent FreeRefreshChargeRemainTime;

	[SerializeField]
	private Text AdsRefreshChargeCountText;

	private int DeskCount;

	private int curMaxGrade;

	private CompositeDisposable disposables;

	public Action ContractCompanyCb;

	public int OfficeIdx { get; private set; }

	private int ABType_CompanyListAdTest { get; set; }

	protected override void Awake()
	{
	}

	public void Show(int officeIdx, Action contractCompanyCb = null)
	{
	}

	private void SetABTestLayout()
	{
	}

	public void DrawList()
	{
	}

	public void UpdateRefreshBtn()
	{
	}

	private void OnClickContracts(int company)
	{
	}

	private void OnClickAdRefreshCompany()
	{
	}

	private void OnClickAdsRefreshCountChargeBtn()
	{
	}

	private void OnClickCashRefreshCompany()
	{
	}

	private void OnClickRefreshCompany()
	{
	}

	private void RefreshCompanyList()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickInfoClose()
	{
	}

	public void RefreshText()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
