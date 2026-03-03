using System;
using System.Collections.Generic;
using System.Numerics;
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

	public int CurOfficeIdx => 0;

	private void Awake()
	{
	}

	public void UpdateAll(int officeIdx, int regionIdx = -1)
	{
	}

	public void UpdateSelected(bool value)
	{
	}

	private void UpdateOffice(int stageIdx, OfficeData officeData, int regionIdx = -1)
	{
	}

	private void UpdateCompanyExp(BigInteger exp)
	{
	}

	private void UpdateCompanyLevel(int companyLevel)
	{
	}

	private void UpdateManagerDesk(OfficeItemData data)
	{
	}

	private void UpdateManager(int managerIdx)
	{
	}

	private void OnClickManager()
	{
	}

	private void UpdateArrow()
	{
	}

	public void ShowUpgradeArrow()
	{
	}

	private void UpdateLevelWarning()
	{
	}

	private void LevelUpByCashItem()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickHire()
	{
	}

	private void OnClickChange()
	{
	}

	private void OnClickLevelWarning()
	{
	}

	private void Reset()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
