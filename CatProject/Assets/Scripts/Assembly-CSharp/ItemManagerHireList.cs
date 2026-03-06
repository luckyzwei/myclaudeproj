using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerHireList : MonoBehaviour
{
	[Header("ItemManagerHireList")]
	[Header("Office")]
	[SerializeField]
	private Text OfficeNameText;

	[SerializeField]
	private GameObject CompanyNullObj;

	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompanyNameText;

	[SerializeField]
	private Image CompanyGradeFrame;

	[SerializeField]
	private Text CompanyGradeText;

	[Space(5f)]
	[SerializeField]
	private List<Image> CompanyLevels;

	[SerializeField]
	private Slider LevelProgress;

	[SerializeField]
	private Image LevelProgressFill;

	[SerializeField]
	private Text ExpPerText;

	[Header("Office Ability")]
	[SerializeField]
	private GameObject OfficeAbilityNullObj;

	[SerializeField]
	private Image OfficeAbilityIcon;

	[SerializeField]
	private Text OfficeAbilityTitle;

	[SerializeField]
	private Text OfficeAbilityText;

	[SerializeField]
	private Text OfficeAbilityTotalText;

	[SerializeField]
	private Text OfficeAbilityAddText;

	[SerializeField]
	private ItemManagerSkill OfficeSkillInfo;

	[Space(5f)]
	[SerializeField]
	private GameObject SelectObj;

	[Header("ManagerDesk")]
	[SerializeField]
	private Image ManagerDeskIcon;

	[SerializeField]
	private Text ManagerDeskNameText;

	[SerializeField]
	private Text ManagerDeskLevelText;

	[SerializeField]
	private Button ManagerDeskPurchaseBtn;

	[SerializeField]
	private Image ManagerDeskPurchaseIcon;

	[SerializeField]
	private Text ManagerDeskPurchaseText;

	[Space(5f)]
	[SerializeField]
	private GameObject ManagerDeskNullObj;

	[SerializeField]
	private GameObject ManagerDeskLevelUpObj;

	[SerializeField]
	private Text ManagerDeskAbilityLevelText;

	[SerializeField]
	private Text ManagerDeskLevelUpText;

	[Header("Manager")]
	[SerializeField]
	private GameObject ManagerHireRootObj;

	[SerializeField]
	private GameObject ManagerFireRootObj;

	[Space(5f)]
	[SerializeField]
	private ItemManagerCardMin CurItemManagerCardMin;

	[SerializeField]
	private Button ManagerHireBtn;

	[SerializeField]
	private Button ManagerChangeBtn;

	[Header("Arrow")]
	[SerializeField]
	private GameObject ArrowHire;

	[SerializeField]
	private GameObject ArrowUpgrade;

	[Header("LevelWarning")]
	[SerializeField]
	private Button LevelWarningBtn;

	[SerializeField]
	private GameObject BadObj;

	[Space(10f)]
	[SerializeField]
	private GameObject LevelUpNoti;

	private CompositeDisposable company_exp_disposables;

	private CompositeDisposable company_lv_disposables;

	private bool onTuto;

	private bool doneTuto;

	private int curManagerIdx;

	private int curOfficeIdx;

	private int companyNeedExp;

	private BigInteger curCompanyReward;

	private BigInteger beforeCompanyReward;

	private int curCompanyIncreaseExp;

	private bool isZeroDesk;

	public Action<int> UpgradeCb;

	public int CurOfficeIdx { get { return curOfficeIdx; } }

	private void Awake()
	{
		company_exp_disposables = new CompositeDisposable();
		company_lv_disposables = new CompositeDisposable();
		onTuto = false;
		doneTuto = false;
		isZeroDesk = false;

		if (ManagerHireBtn != null) ManagerHireBtn.onClick.AddListener(OnClickHire);
		if (ManagerChangeBtn != null) ManagerChangeBtn.onClick.AddListener(OnClickChange);
		if (ManagerDeskPurchaseBtn != null) ManagerDeskPurchaseBtn.onClick.AddListener(OnClickPurchase);
		if (LevelWarningBtn != null) LevelWarningBtn.onClick.AddListener(OnClickLevelWarning);
	}

	public void UpdateAll(int officeIdx, int regionIdx = -1)
	{
		curOfficeIdx = officeIdx;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Get office and company data
		UpdateArrow();
		UpdateLevelWarning();
	}

	public void UpdateSelected(bool value)
	{
		if (SelectObj != null) SelectObj.SetActive(value);
	}

	private void UpdateOffice(int stageIdx, OfficeData officeData, int regionIdx = -1)
	{
		if (officeData == null) return;
		if (OfficeNameText != null) OfficeNameText.text = "";

		// Set company info
		bool hasCompany = false;
		if (CompanyNullObj != null) CompanyNullObj.SetActive(!hasCompany);
		if (CompanyNameText != null) CompanyNameText.text = "";

		// Set exp gauge
		if (LevelProgress != null) LevelProgress.value = 0f;
	}

	private void UpdateCompanyExp(BigInteger exp)
	{
		if (company_exp_disposables != null)
		{
			company_exp_disposables.Dispose();
			company_exp_disposables = new CompositeDisposable();
		}
		// Update exp display
		if (ExpPerText != null) ExpPerText.text = ProjectUtility.GetThousandCommaText(exp);
	}

	private void UpdateCompanyLevel(int companyLevel)
	{
		if (CompanyLevels != null)
		{
			for (int i = 0; i < CompanyLevels.Count; i++)
			{
				if (CompanyLevels[i] != null)
					CompanyLevels[i].gameObject.SetActive(i < companyLevel);
			}
		}
	}

	private void UpdateManagerDesk(OfficeItemData data)
	{
		if (data == null)
		{
			if (ManagerDeskNullObj != null) ManagerDeskNullObj.SetActive(true);
			if (ManagerDeskLevelUpObj != null) ManagerDeskLevelUpObj.SetActive(false);
			isZeroDesk = true;
			return;
		}
		isZeroDesk = false;
		if (ManagerDeskNullObj != null) ManagerDeskNullObj.SetActive(false);
		if (ManagerDeskLevelUpObj != null) ManagerDeskLevelUpObj.SetActive(true);
	}

	private void UpdateManager(int managerIdx)
	{
		curManagerIdx = managerIdx;
		bool hasManager = managerIdx > 0;
		if (ManagerHireRootObj != null) ManagerHireRootObj.SetActive(!hasManager);
		if (ManagerFireRootObj != null) ManagerFireRootObj.SetActive(hasManager);
	}

	private void OnClickManager()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void UpdateArrow()
	{
		if (ArrowHire != null) ArrowHire.SetActive(false);
		if (ArrowUpgrade != null) ArrowUpgrade.SetActive(false);
	}

	public void ShowUpgradeArrow()
	{
		if (ArrowUpgrade != null) ArrowUpgrade.SetActive(true);
	}

	private void UpdateLevelWarning()
	{
		if (BadObj != null) BadObj.SetActive(false);
		if (LevelUpNoti != null) LevelUpNoti.SetActive(false);
		// Check if office has level warnings
	}

	private void LevelUpByCashItem()
	{
		// Level up using cash item
		UpgradeCb?.Invoke(curOfficeIdx);
	}

	private void OnClickPurchase()
	{
		// Purchase manager desk
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpgradeCb?.Invoke(curOfficeIdx);
	}

	private void OnClickHire()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void OnClickChange()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void OnClickLevelWarning()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void Reset()
	{
		if (company_exp_disposables != null)
		{
			company_exp_disposables.Dispose();
			company_exp_disposables = new CompositeDisposable();
		}
		if (company_lv_disposables != null)
		{
			company_lv_disposables.Dispose();
			company_lv_disposables = new CompositeDisposable();
		}
	}

	private void OnDisable()
	{
		Reset();
	}

	private void OnDestroy()
	{
		if (company_exp_disposables != null) { company_exp_disposables.Dispose(); company_exp_disposables = null; }
		if (company_lv_disposables != null) { company_lv_disposables.Dispose(); company_lv_disposables = null; }
	}
}
