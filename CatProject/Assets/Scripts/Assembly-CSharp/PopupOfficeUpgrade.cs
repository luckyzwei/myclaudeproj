using System.Collections.Generic;
using System.Numerics;
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

	public OnetimeCurrencyComponent OneTimeComponent => null;

	public int selectItem { get; private set; }

	public int OfficeIdx { get; private set; }

	public int SavedPiggyCount { get; set; }

	public int SavedOneTimeCount { get; set; }

	protected override void Awake()
	{
	}

	public void Set(int officeIdx, int naviOfficeIdx = -1)
	{
	}

	public void SetGuide(int type, int level, int count = 1)
	{
	}

	public void ShowCompanyLevelupPopup()
	{
	}

	private void Update()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	private bool CheckAndPlayCompanyExpTicket()
	{
		return false;
	}

	private void SetUpdateTab()
	{
	}

	private void SetMoodTab()
	{
	}

	private void UpdateCompanyContractButton()
	{
	}

	private void UpdateCompanyLevelUpButton()
	{
	}

	private void UpdateOfficeExp()
	{
	}

	public void LevelUpByCashItem()
	{
	}

	private void UpdatePower()
	{
	}

	private void SetPowerInfo(bool isInit = false)
	{
	}

	private void UpdateCompany()
	{
	}

	private void UpdateExpGauge()
	{
	}

	private void UpdateExpGaugeColor()
	{
	}

	private void OnUpdateCompanyExp()
	{
	}

	private void SetCompanyExp(BigInteger exp)
	{
	}

	private void UpdateCompanyLevel(int level)
	{
	}

	private void UpdateRentalFee()
	{
	}

	private void UpdateSelectItem()
	{
	}

	private void UpdateLevelUpAllButton()
	{
	}

	private void UpdateLevelUpAllButton_LowPower()
	{
	}

	private void ShowIngamePreview(int itemType, int itemIdx)
	{
	}

	private void FocusItem(int itemType, int itemIdx)
	{
	}

	private void ScreenTraceItem(int itemType, int itemIdx, bool bForceUpdate)
	{
	}

	public ItemOfficeItem GetScrollItem(int idx)
	{
		return null;
	}

	public void SelectUnActiveDesk(int needDeskCount)
	{
	}

	public void SelectItem(int itemIdx, int itemType)
	{
	}

	private void SetManager()
	{
	}

	private void UpdateItemScroll(Vector2 pos)
	{
	}

	private void OnClickChangeTab(Tab tab)
	{
	}

	public void OnClickItem(int idx, int type)
	{
	}

	private void OnClickBuy()
	{
	}

	private void OnClickLevelUpAllItems()
	{
	}

	private void OnClickPiggyBank()
	{
	}

	private void OnClickGotoPowerRoom()
	{
	}

	private void OnClickRentalFeeInfo()
	{
	}

	private void OnClickExpInfo()
	{
	}

	private void OnClickOfficeGuide()
	{
	}

	private void OnClickCompanyList()
	{
	}

	private void OnClickCompanyOut()
	{
	}

	private void OnClickCompanyOutMax()
	{
	}

	private void OnClickManagerPreOpen()
	{
	}

	private void OnClickManagerAbility()
	{
	}

	private void OnClickMoodRequireItem(int itemType)
	{
	}

	private void OnClickCompanyCashLevelUpBtn()
	{
	}

	private void OnClickCompanyLevelUpBtn()
	{
	}

	private object GetContractParam()
	{
		return null;
	}

	private void UpdateStrike()
	{
	}

	private void SetStrike()
	{
	}

	private void SetTapReddotObj()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void Hide()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private ItemOfficeItem FindNextSequentialItem()
	{
		return null;
	}

	private ItemOfficeItem FindLowestLevelItem()
	{
		return null;
	}

	private void GoToOffice(int officeIdx)
	{
	}

	private bool IsEnableCompanyLevelUp(int companyIdx)
	{
		return false;
	}
}
