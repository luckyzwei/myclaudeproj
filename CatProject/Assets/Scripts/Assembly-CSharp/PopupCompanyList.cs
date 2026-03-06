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
		base.Awake();
		disposables = new CompositeDisposable();

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (InfoDimBtn != null) InfoDimBtn.onClick.AddListener(OnClickInfoClose);
		if (RefreshBtn != null) RefreshBtn.onClick.AddListener(OnClickRefreshCompany);
		if (RefreshAdBtn != null) RefreshAdBtn.onClick.AddListener(OnClickAdRefreshCompany);
		if (RefreshCashBtn != null) RefreshCashBtn.onClick.AddListener(OnClickCashRefreshCompany);
		if (NoAdsRefreshBtn != null) NoAdsRefreshBtn.onClick.AddListener(OnClickRefreshCompany);
		if (FreeRefreshBtn != null) FreeRefreshBtn.onClick.AddListener(OnClickRefreshCompany);
		if (AdsRefreshBtn != null) AdsRefreshBtn.onClick.AddListener(OnClickAdsRefreshCountChargeBtn);
	}

	public void Show(int officeIdx, Action contractCompanyCb = null)
	{
		OfficeIdx = officeIdx;
		ContractCompanyCb = contractCompanyCb;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SetABTestLayout();
		DrawList();
		UpdateRefreshBtn();
	}

	private void SetABTestLayout()
	{
		if (ABTestObj_A != null) ABTestObj_A.SetActive(ABType_CompanyListAdTest == 0);
		if (ABTestObj_B != null) ABTestObj_B.SetActive(ABType_CompanyListAdTest == 1);
	}

	public void DrawList()
	{
		// Populate company list slots from company data
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (MaxGradeText != null) MaxGradeText.text = curMaxGrade.ToString();
	}

	public void UpdateRefreshBtn()
	{
	}

	private void OnClickContracts(int company)
	{
		// Contract with selected company
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		ContractCompanyCb?.Invoke();
	}

	private void OnClickAdRefreshCompany()
	{
		// Watch ad to refresh company list
		RefreshCompanyList();
	}

	private void OnClickAdsRefreshCountChargeBtn()
	{
	}

	private void OnClickCashRefreshCompany()
	{
		// Pay cash to refresh company list
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		RefreshCompanyList();
	}

	private void OnClickRefreshCompany()
	{
		// Free refresh company list
		RefreshCompanyList();
	}

	private void RefreshCompanyList()
	{
		DrawList();
		UpdateRefreshBtn();
	}

	private void OnClickInfo()
	{
		if (InfoObj != null) InfoObj.SetActive(true);
	}

	private void OnClickInfoClose()
	{
		if (InfoObj != null) InfoObj.SetActive(false);
	}

	public void RefreshText()
	{
		DrawList();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
