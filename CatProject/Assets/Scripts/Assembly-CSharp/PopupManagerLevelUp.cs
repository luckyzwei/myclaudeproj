using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalManager", false, false)]
public class PopupManagerLevelUp : UIBase
{
	[SerializeField]
	private HUDTopInfo TopInfo;

	[SerializeField]
	private Text ManagerNameText;

	[SerializeField]
	private ProgressText ManagerLevelText;

	[SerializeField]
	private Image ManagerPortraitImage;

	[SerializeField]
	private GameObject AbilityObj;

	[SerializeField]
	private GameObject NextLevelAbilityObj;

	[SerializeField]
	private GameObject MaxLevelAbilityObj;

	[SerializeField]
	private Image AbilityIconImage;

	[SerializeField]
	private Text AbilityValueText;

	[SerializeField]
	private Image NextLevelAbilityIconImage;

	[SerializeField]
	private Text NextLevelAbilityValueText;

	[SerializeField]
	private Image LvUpCostExpIconImage;

	[SerializeField]
	private ProgressText LvUpCostExpText;

	[SerializeField]
	private ButtonPressed LvUpBtnPressed;

	[SerializeField]
	private GameObject LvUpParticle;

	[Header("PackageBanner")]
	[SerializeField]
	private ItemSeasonalPackageBanner PackageBanner;

	private int WorkshopIdx;

	private int ManagerIdx;

	private int ManagerCurLv;

	private int ManagerMaxLv;

	private bool isLeveledUp;

	private bool bEnoughCost;

	private bool bMaxLevel;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetWorkShopManager(int workShopIdx)
	{
	}

	private void InitTopCurrencyInfo()
	{
	}

	private void SetManagerViewInfo(string imgPath, string nameKey)
	{
	}

	private void SetLvUpCostExpIconImage(string iconKey)
	{
	}

	private void SetManagerLevelText(int curLevel, int maxLevel)
	{
	}

	private void SetManagerAbility(string abilityIconKey, BigInteger abilityValue_PerMile)
	{
	}

	private void SetManagerAbilityValueText(BigInteger abilityValue_PerMile)
	{
	}

	private void SetManagerNextLevelAbilityValueText(BigInteger abilityValue_PerMile)
	{
	}

	private void SetManagerLevelUpExpInfo(BigInteger needCost, BigInteger hasValue_PerMile)
	{
	}

	private void SetLevelBtnInteractable(bool bInteractable)
	{
	}

	private void UpdateLevelData()
	{
	}

	private void SubscribeEvents(SeasonalWorkshopManagerData managerData)
	{
	}

	private void OnClickedManagerLevelUpBtn()
	{
	}

	private void ShowLevelUpPackage()
	{
	}

	private void SetPackageBanner()
	{
	}
}
