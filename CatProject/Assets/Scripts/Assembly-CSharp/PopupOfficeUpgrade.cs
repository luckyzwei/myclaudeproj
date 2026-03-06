using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOfficeUpgrade", false, false)]
public class PopupOfficeUpgrade : UIBase
{
	private enum Tab
	{
		None = 0,
		Upgrade = 1,
		Mood = 2
	}

	[Header("Tab")]
	[SerializeField]
	private GameObject TabRoot;

	[SerializeField]
	private Toggle UpgradeTab;

	[SerializeField]
	private Toggle MoodTab;

	[SerializeField]
	private GameObject UpgradeRoot;

	[SerializeField]
	private GameObject MoodRoot;

	[Header("Power")]
	[SerializeField]
	private GameObject PowerInfoRoot;

	[SerializeField]
	private Text PowerValue;

	[SerializeField]
	private Text PowerLoadRatio;

	[SerializeField]
	private GameObject LeakPowerObj;

	[SerializeField]
	private Transform PowerArrowTrans;

	[SerializeField]
	private List<GameObject> PowerLoadStepObjs;

	private CompositeDisposable power_disposables;

	[Header("Level")]
	[SerializeField]
	private GameObject LevelRoot;

	[SerializeField]
	private Text ExpRatioText;

	[SerializeField]
	private Image ExpProgressFill;

	private CompositeDisposable exp_disposables;

	[Header("Company")]
	[SerializeField]
	private GameObject CompanyInfoRoot;

	[SerializeField]
	private GameObject NoneCompanyRoot;

	[SerializeField]
	private Button CompanyListBtn;

	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private Text CompanyDesc;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private GameObject CompanySpecialObj;

	[SerializeField]
	private Text CompanyRentalFeeText;

	[SerializeField]
	private Button CompanyOutBtn;

	[SerializeField]
	private Button CompanyOutMaxLvBtn;

	[SerializeField]
	private Text CompanyBtnText;

	[SerializeField]
	private Text NeedDeskCountText;

	[SerializeField]
	private List<Image> LevelObjs;

	[SerializeField]
	private Slider LevelProgress;

	[SerializeField]
	private Image LevelProgressFill;

	[SerializeField]
	private Text ExpPerText;

	[SerializeField]
	private Text ExpDesckText;

	[SerializeField]
	private Button ExpInfoBtn;

	[SerializeField]
	private Button RentalFeeInfoBtn;

	[SerializeField]
	private Image RentalFeeIcon;

	[SerializeField]
	private GameObject RentalFeeDebuffObj;

	[SerializeField]
	private GameObject CompanyLevelUpCashObj;

	[SerializeField]
	private Button CompanyLevelUpCashBtn;

	[SerializeField]
	private Button CompanyLevelUpBtn;

	[SerializeField]
	private GameObject CompanyLvUpNotiObj;

	[Header("LevelUpAllItems")]
	[SerializeField]
	private Button LevelUpAllItemsBtn;

	[SerializeField]
	private GameObject LevelUpAllFxObj;

	private CompositeDisposable company_disposables;

	private CompositeDisposable company_lv_disposables;

	private CompositeDisposable daystatus_disposables;

	private CompositeDisposable company_increase_exp_disposables;

	private CompositeDisposable strike_disposables;

	private BigInteger CompanyNeedExp;

	[Header("Selectitem")]
	[SerializeField]
	private Image ItemIcon;

	[SerializeField]
	private Text ItemName;

	[SerializeField]
	private Text ItemDesc;

	[SerializeField]
	private Text ItemLevel;

	[SerializeField]
	private ButtonPressed PurchaseBtnPressed;

	[SerializeField]
	private Button GotoPowerRoomBtn;

	[SerializeField]
	private Image NeedCurrencyIcon;

	[SerializeField]
	private Text NeedCurrencyText;

	[SerializeField]
	private Text NeedLevelText;

	[SerializeField]
	private Text NeedPowerText;

	[SerializeField]
	private Text UsePowerText;

	[SerializeField]
	private GameObject UsePowerInfoRoot;

	[SerializeField]
	private GameObject NeedLevelObj;

	[SerializeField]
	private GameObject MoodBuffObj;

	[SerializeField]
	private Text MoodBuffText;

	[SerializeField]
	private Text MoodBuffAddText;

	[SerializeField]
	private Text HireManagerText;

	[SerializeField]
	private GameObject HireManagerRoot;

	[SerializeField]
	private Image AbilityTypeIcon;

	[SerializeField]
	private Text AbilityValueText;

	[SerializeField]
	private Text IncreaseAbilityValueText;

	[SerializeField]
	private GameObject AbilityRoot;

	[Space(5f)]
	[SerializeField]
	private GameObject PlayerExpObj;

	[SerializeField]
	private Text PlayerExpValueText;

	[SerializeField]
	private GameObject PlayerLevelObj;

	[SerializeField]
	private Text PlayerLevelValueText;

	[SerializeField]
	private GameObject GaugeParticleObj;

	[SerializeField]
	private DoTweenScriptComponent PercentDotween;

	[Header("ItemList")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject ScrollItem;

	[SerializeField]
	private GameObject GuideArrow;

	[Header("RequreItem")]
	[SerializeField]
	private GameObject RequireLeakObj;

	[SerializeField]
	private GameObject RequireLeakBuffObj;

	[SerializeField]
	private GameObject RequireItem_NoCompanyObj;

	[SerializeField]
	private ScrollRect RequireItem_Scroll;

	[SerializeField]
	private GameObject RequireItemObj;

	[Header("Mood")]
	[SerializeField]
	private GameObject EmployeeMood_NoCompanyObj;

	[SerializeField]
	private ScrollRect EmployeeMood_Scroll;

	[SerializeField]
	private GameObject EmployeeMoodObj;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("ManagerPreOpen")]
	[SerializeField]
	private GameObject ManagerPreOpenObj;

	[SerializeField]
	private Button ManagerPreOpenBtn;

	[Header("Manager")]
	[SerializeField]
	private GameObject ManagerRootObj;

	[SerializeField]
	private Button ManagerAbilityBtn;

	[SerializeField]
	private GameObject ManagerAbilityBtnManagerObj;

	[SerializeField]
	private GameObject ManagerAbilityBtnHireCeoObj;

	[Space(5f)]
	[SerializeField]
	private Image ManagerFrame;

	[SerializeField]
	private Image ManagerIcon;

	[SerializeField]
	private Image ManagerAbilityIcon;

	[SerializeField]
	private GameObject ManagerBadObj;

	[SerializeField]
	private Text ManagerAbilityValueText;

	[Space(5f)]
	[SerializeField]
	private GameObject ManagerFindObj;

	[SerializeField]
	private GameObject ManagerHireObj;

	[Space(10f)]
	[SerializeField]
	private GameObject ManagerRewardAbilityArrow;

	[SerializeField]
	private GameObject ManagerExpAbilityArrow;

	[SerializeField]
	private GameObject ManagerExpProgressObj;

	[Space(10f)]
	[SerializeField]
	private ItemOfficeManagerSkill OfficeManagerSkill;

	[Header("Etc")]
	[SerializeField]
	private Text OfficeName;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button moveLeftBtn;

	[SerializeField]
	private Button moveRightBtn;

	[SerializeField]
	private GameObject LongPressNotiObj;

	[SerializeField]
	private GameObject StrikeReddotObj;

	[SerializeField]
	private GameObject ManagerBuffInfoCloseBtn;

	private List<ItemOfficeItem> OfficeItemList;

	private int selectItemType;

	private int beforeOfficeIdx;

	private int afterOfficeIdx;

	private int CompanyIdx;

	private bool IsRemainContractTime;

	private int CurLevel;

	private Tab CurTab;

	private int GuideLevel;

	private int GuideCount;

	private ItemOfficeItem GuideItem;

	private GameObject GuideObj;

	private string[] powercolorkey;

	private bool IsLongPressed;

	private bool IsFirstLongPressed;

	private int BuyBtnClickCount;

	private int NaviOfficeIdx;

	private bool CachedActiveLevelUpAllBtn;

	public OnetimeCurrencyComponent OneTimeComponent { get { return oneTimeComponent; } }

	public int selectItem { get; private set; }

	public int OfficeIdx { get; private set; }

	public int SavedPiggyCount { get; set; }

	public int SavedOneTimeCount { get; set; }

	protected override void Awake()
	{
		base.Awake();
		power_disposables = new CompositeDisposable();
		exp_disposables = new CompositeDisposable();
		company_disposables = new CompositeDisposable();
		company_lv_disposables = new CompositeDisposable();
		daystatus_disposables = new CompositeDisposable();
		company_increase_exp_disposables = new CompositeDisposable();
		strike_disposables = new CompositeDisposable();
		OfficeItemList = new List<ItemOfficeItem>();
		CurTab = Tab.Upgrade;
		IsLongPressed = false;
		IsFirstLongPressed = false;
		BuyBtnClickCount = 0;
		SavedPiggyCount = 0;
		SavedOneTimeCount = 0;
		powercolorkey = new string[] { "green", "yellow", "red" };

		if (UpgradeTab != null) UpgradeTab.onValueChanged.AddListener((on) => { if (on) OnClickChangeTab(Tab.Upgrade); });
		if (MoodTab != null) MoodTab.onValueChanged.AddListener((on) => { if (on) OnClickChangeTab(Tab.Mood); });
		if (PurchaseBtnPressed != null) PurchaseBtnPressed.OnPressed = OnClickBuy;
		if (GotoPowerRoomBtn != null) GotoPowerRoomBtn.onClick.AddListener(OnClickGotoPowerRoom);
		if (CompanyListBtn != null) CompanyListBtn.onClick.AddListener(OnClickCompanyList);
		if (CompanyOutBtn != null) CompanyOutBtn.onClick.AddListener(OnClickCompanyOut);
		if (CompanyOutMaxLvBtn != null) CompanyOutMaxLvBtn.onClick.AddListener(OnClickCompanyOutMax);
		if (CompanyLevelUpCashBtn != null) CompanyLevelUpCashBtn.onClick.AddListener(OnClickCompanyCashLevelUpBtn);
		if (CompanyLevelUpBtn != null) CompanyLevelUpBtn.onClick.AddListener(OnClickCompanyLevelUpBtn);
		if (LevelUpAllItemsBtn != null) LevelUpAllItemsBtn.onClick.AddListener(OnClickLevelUpAllItems);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickOfficeGuide);
		if (ExpInfoBtn != null) ExpInfoBtn.onClick.AddListener(OnClickExpInfo);
		if (RentalFeeInfoBtn != null) RentalFeeInfoBtn.onClick.AddListener(OnClickRentalFeeInfo);
		if (ManagerPreOpenBtn != null) ManagerPreOpenBtn.onClick.AddListener(OnClickManagerPreOpen);
		if (ManagerAbilityBtn != null) ManagerAbilityBtn.onClick.AddListener(OnClickManagerAbility);
		if (moveLeftBtn != null) moveLeftBtn.onClick.AddListener(() => GoToOffice(beforeOfficeIdx));
		if (moveRightBtn != null) moveRightBtn.onClick.AddListener(() => GoToOffice(afterOfficeIdx));
		if (Scroll != null) Scroll.onValueChanged.AddListener(UpdateItemScroll);
	}

	public void Set(int officeIdx, int naviOfficeIdx = -1)
	{
		OfficeIdx = officeIdx;
		NaviOfficeIdx = naviOfficeIdx;
		selectItem = 0;
		selectItemType = 0;
		BuyBtnClickCount = 0;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SetUpdateTab();
		UpdateCompany();
		SetPowerInfo(true);
		SetManager();
		UpdateSelectItem();
		UpdateStrike();

		if (OfficeName != null) OfficeName.text = "";

		beforeOfficeIdx = officeIdx - 1;
		afterOfficeIdx = officeIdx + 1;
		if (moveLeftBtn != null) moveLeftBtn.gameObject.SetActive(beforeOfficeIdx >= 0);
		if (moveRightBtn != null) moveRightBtn.gameObject.SetActive(true);
	}

	public void SetGuide(int type, int level, int count = 1)
	{
		GuideLevel = level;
		GuideCount = count;
		if (GuideArrow != null) GuideArrow.SetActive(true);
	}

	public void ShowCompanyLevelupPopup()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void Update()
	{
		if (IsLongPressed)
		{
			OnClickBuy();
		}
	}

	public override void OnShowBefore()
	{
		UpdateOfficeExp();
		UpdatePower();
		UpdateLevelUpAllButton();
		SetTapReddotObj();
	}

	public override void OnRefresh()
	{
		UpdateSelectItem();
		UpdateCompany();
		UpdatePower();
		UpdateLevelUpAllButton();
		UpdateNoti();
	}

	private void UpdateNoti()
	{
		SetTapReddotObj();
	}

	private bool CheckAndPlayCompanyExpTicket()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	private void SetUpdateTab()
	{
		if (UpgradeRoot != null) UpgradeRoot.SetActive(CurTab == Tab.Upgrade);
		if (MoodRoot != null) MoodRoot.SetActive(CurTab == Tab.Mood);
	}

	private void SetMoodTab()
	{
		if (EmployeeMood_NoCompanyObj != null) EmployeeMood_NoCompanyObj.SetActive(CompanyIdx <= 0);
		if (RequireItem_NoCompanyObj != null) RequireItem_NoCompanyObj.SetActive(CompanyIdx <= 0);
	}

	private void UpdateCompanyContractButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CompanyOutBtn != null) CompanyOutBtn.gameObject.SetActive(CompanyIdx > 0);
		if (CompanyOutMaxLvBtn != null) CompanyOutMaxLvBtn.gameObject.SetActive(false);
	}

	private void UpdateCompanyLevelUpButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		bool canLevelUp = IsEnableCompanyLevelUp(CompanyIdx);
		if (CompanyLvUpNotiObj != null) CompanyLvUpNotiObj.SetActive(canLevelUp);
	}

	private void UpdateOfficeExp()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (exp_disposables != null)
		{
			exp_disposables.Dispose();
			exp_disposables = new CompositeDisposable();
		}
	}

	public void LevelUpByCashItem()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCompany();
	}

	private void UpdatePower()
	{
		if (power_disposables != null)
		{
			power_disposables.Dispose();
			power_disposables = new CompositeDisposable();
		}
		SetPowerInfo();
	}

	private void SetPowerInfo(bool isInit = false)
	{
		if (PowerInfoRoot == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (PowerValue != null) PowerValue.text = "0";
		if (PowerLoadRatio != null) PowerLoadRatio.text = "0%";
		if (LeakPowerObj != null) LeakPowerObj.SetActive(false);

		if (PowerLoadStepObjs != null)
		{
			for (int i = 0; i < PowerLoadStepObjs.Count; i++)
			{
				if (PowerLoadStepObjs[i] != null)
					PowerLoadStepObjs[i].SetActive(false);
			}
		}
	}

	private void UpdateCompany()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (CompanyInfoRoot != null) CompanyInfoRoot.SetActive(CompanyIdx > 0);
		if (NoneCompanyRoot != null) NoneCompanyRoot.SetActive(CompanyIdx <= 0);

		if (CompanyIdx > 0)
		{
			UpdateExpGauge();
			UpdateCompanyContractButton();
			UpdateCompanyLevelUpButton();
			UpdateRentalFee();
		}

		if (CompanyLevelUpCashObj != null) CompanyLevelUpCashObj.SetActive(CompanyIdx > 0);
	}

	private void UpdateExpGauge()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (LevelProgress != null) LevelProgress.value = 0f;
		UpdateExpGaugeColor();
	}

	private void UpdateExpGaugeColor()
	{
		if (GaugeParticleObj != null) GaugeParticleObj.SetActive(false);
	}

	private void OnUpdateCompanyExp()
	{
		UpdateExpGauge();
		UpdateCompanyLevelUpButton();
	}

	private void SetCompanyExp(BigInteger exp)
	{
		if (ExpRatioText != null)
		{
			if (CompanyNeedExp > 0)
				ExpRatioText.text = ProjectUtility.GetThousandCommaText(exp) + "/" + ProjectUtility.GetThousandCommaText(CompanyNeedExp);
		}
		if (ExpProgressFill != null && CompanyNeedExp > 0)
		{
			float ratio = (float)((double)exp / (double)CompanyNeedExp);
			ExpProgressFill.fillAmount = Mathf.Clamp01(ratio);
		}
	}

	private void UpdateCompanyLevel(int level)
	{
		CurLevel = level;
		if (LevelObjs != null)
		{
			for (int i = 0; i < LevelObjs.Count; i++)
			{
				if (LevelObjs[i] != null)
					LevelObjs[i].gameObject.SetActive(i < level);
			}
		}
		UpdateExpGauge();
		UpdateRentalFee();
	}

	private void UpdateRentalFee()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (RentalFeeDebuffObj != null) RentalFeeDebuffObj.SetActive(false);
	}

	private void UpdateSelectItem()
	{
		if (OfficeItemList == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (ItemName != null) ItemName.text = "";
		if (ItemDesc != null) ItemDesc.text = "";
		if (ItemLevel != null) ItemLevel.text = "";

		if (NeedLevelObj != null) NeedLevelObj.SetActive(false);
		if (UsePowerInfoRoot != null) UsePowerInfoRoot.SetActive(false);

		if (MoodBuffObj != null) MoodBuffObj.SetActive(false);

		if (HireManagerRoot != null) HireManagerRoot.SetActive(false);

		if (AbilityRoot != null) AbilityRoot.SetActive(false);

		if (PlayerExpObj != null) PlayerExpObj.SetActive(false);
		if (PlayerLevelObj != null) PlayerLevelObj.SetActive(false);
	}

	private void UpdateLevelUpAllButton()
	{
		if (LevelUpAllItemsBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		bool canBulkLevelUp = false;
		CachedActiveLevelUpAllBtn = canBulkLevelUp;
		LevelUpAllItemsBtn.gameObject.SetActive(canBulkLevelUp);
		if (LevelUpAllFxObj != null) LevelUpAllFxObj.SetActive(false);
	}

	private void UpdateLevelUpAllButton_LowPower()
	{
		if (LevelUpAllItemsBtn != null) LevelUpAllItemsBtn.interactable = false;
	}

	private void ShowIngamePreview(int itemType, int itemIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;
	}

	private void FocusItem(int itemType, int itemIdx)
	{
		if (OfficeItemList == null) return;
		for (int i = 0; i < OfficeItemList.Count; i++)
		{
			if (OfficeItemList[i] != null && OfficeItemList[i].ItemType == itemType && OfficeItemList[i].ItemIdx == itemIdx)
			{
				GuideItem = OfficeItemList[i];
				break;
			}
		}
	}

	private void ScreenTraceItem(int itemType, int itemIdx, bool bForceUpdate)
	{
		FocusItem(itemType, itemIdx);
	}

	public ItemOfficeItem GetScrollItem(int idx)
	{
		if (OfficeItemList == null || idx < 0 || idx >= OfficeItemList.Count) return null;
		return OfficeItemList[idx];
	}

	public void SelectUnActiveDesk(int needDeskCount)
	{
		if (NeedDeskCountText != null)
			NeedDeskCountText.text = needDeskCount.ToString();
	}

	public void SelectItem(int itemIdx, int itemType)
	{
		selectItem = itemIdx;
		selectItemType = itemType;
		UpdateSelectItem();
		ShowIngamePreview(itemType, itemIdx);
	}

	private void SetManager()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		bool hasManager = false;
		if (ManagerRootObj != null) ManagerRootObj.SetActive(hasManager);
		if (ManagerPreOpenObj != null) ManagerPreOpenObj.SetActive(!hasManager);
		if (ManagerFindObj != null) ManagerFindObj.SetActive(false);
		if (ManagerHireObj != null) ManagerHireObj.SetActive(false);
		if (ManagerBadObj != null) ManagerBadObj.SetActive(false);
	}

	private void UpdateItemScroll(Vector2 pos)
	{
	}

	private void OnClickChangeTab(Tab tab)
	{
		CurTab = tab;
		SetUpdateTab();
		if (tab == Tab.Mood)
			SetMoodTab();
	}

	public void OnClickItem(int idx, int type)
	{
		SelectItem(idx, type);
	}

	private void OnClickBuy()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		BuyBtnClickCount++;
		UpdateSelectItem();
		UpdatePower();
		UpdateLevelUpAllButton();
	}

	private void OnClickLevelUpAllItems()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (LevelUpAllFxObj != null) LevelUpAllFxObj.SetActive(true);
		UpdateSelectItem();
		UpdatePower();
	}

	private void OnClickPiggyBank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupPiggyBank>();
	}

	private void OnClickGotoPowerRoom()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickRentalFeeInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickExpInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickOfficeGuide()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickCompanyList()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupCompanyList>();
	}

	private void OnClickCompanyOut()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCompany();
	}

	private void OnClickCompanyOutMax()
	{
		OnClickCompanyOut();
	}

	private void OnClickManagerPreOpen()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void OnClickManagerAbility()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickMoodRequireItem(int itemType)
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickCompanyCashLevelUpBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCompany();
	}

	private void OnClickCompanyLevelUpBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCompany();
	}

	private object GetContractParam()
	{
		return new { officeIdx = OfficeIdx, companyIdx = CompanyIdx };
	}

	private void UpdateStrike()
	{
		if (StrikeReddotObj != null) StrikeReddotObj.SetActive(false);
		SetStrike();
	}

	private void SetStrike()
	{
		if (strike_disposables != null)
		{
			strike_disposables.Dispose();
			strike_disposables = new CompositeDisposable();
		}
	}

	private void SetTapReddotObj()
	{
	}

	public override void OnHideBefore()
	{
		if (GuideArrow != null) GuideArrow.SetActive(false);
		if (LongPressNotiObj != null) LongPressNotiObj.SetActive(false);
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void OnDisable()
	{
		DisposeAll();
	}

	private void OnDestroy()
	{
		DisposeAll();
		power_disposables = null;
		exp_disposables = null;
		company_disposables = null;
		company_lv_disposables = null;
		daystatus_disposables = null;
		company_increase_exp_disposables = null;
		strike_disposables = null;
	}

	private void DisposeAll()
	{
		if (power_disposables != null) { power_disposables.Dispose(); power_disposables = new CompositeDisposable(); }
		if (exp_disposables != null) { exp_disposables.Dispose(); exp_disposables = new CompositeDisposable(); }
		if (company_disposables != null) { company_disposables.Dispose(); company_disposables = new CompositeDisposable(); }
		if (company_lv_disposables != null) { company_lv_disposables.Dispose(); company_lv_disposables = new CompositeDisposable(); }
		if (daystatus_disposables != null) { daystatus_disposables.Dispose(); daystatus_disposables = new CompositeDisposable(); }
		if (company_increase_exp_disposables != null) { company_increase_exp_disposables.Dispose(); company_increase_exp_disposables = new CompositeDisposable(); }
		if (strike_disposables != null) { strike_disposables.Dispose(); strike_disposables = new CompositeDisposable(); }
	}

	private ItemOfficeItem FindNextSequentialItem()
	{
		if (OfficeItemList == null || OfficeItemList.Count == 0) return null;
		for (int i = 0; i < OfficeItemList.Count; i++)
		{
			if (OfficeItemList[i] != null)
				return OfficeItemList[i];
		}
		return null;
	}

	private ItemOfficeItem FindLowestLevelItem()
	{
		if (OfficeItemList == null || OfficeItemList.Count == 0) return null;
		ItemOfficeItem lowest = null;
		for (int i = 0; i < OfficeItemList.Count; i++)
		{
			if (OfficeItemList[i] == null) continue;
			if (lowest == null)
				lowest = OfficeItemList[i];
		}
		return lowest;
	}

	private void GoToOffice(int officeIdx)
	{
		if (officeIdx < 0) return;
		Set(officeIdx, NaviOfficeIdx);
	}

	private bool IsEnableCompanyLevelUp(int companyIdx)
	{
		if (companyIdx <= 0) return false;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}
}
