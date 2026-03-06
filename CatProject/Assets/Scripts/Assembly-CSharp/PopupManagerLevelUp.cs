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
		base.Awake();
		Disposables = new CompositeDisposable();
		isLeveledUp = false;
		bEnoughCost = false;
		bMaxLevel = false;

		if (LvUpBtnPressed != null) LvUpBtnPressed.OnPressed = OnClickedManagerLevelUpBtn;
	}

	public override void OnShowBefore()
	{
		InitTopCurrencyInfo();
		SetPackageBanner();
	}

	public override void OnHideAfter()
	{
		if (LvUpParticle != null) LvUpParticle.SetActive(false);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void SetWorkShopManager(int workShopIdx)
	{
		WorkshopIdx = workShopIdx;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateLevelData();
	}

	private void InitTopCurrencyInfo()
	{
		if (TopInfo != null) TopInfo.UpdateCurrencyInfos();
	}

	private void SetManagerViewInfo(string imgPath, string nameKey)
	{
		if (ManagerNameText != null) ManagerNameText.text = nameKey;
	}

	private void SetLvUpCostExpIconImage(string iconKey)
	{
	}

	private void SetManagerLevelText(int curLevel, int maxLevel)
	{
		ManagerCurLv = curLevel;
		ManagerMaxLv = maxLevel;
		bMaxLevel = curLevel >= maxLevel;

		if (ManagerLevelText != null)
			ManagerLevelText.SetText(bMaxLevel ? "MAX" : "Lv." + curLevel);

		if (MaxLevelAbilityObj != null) MaxLevelAbilityObj.SetActive(bMaxLevel);
		if (NextLevelAbilityObj != null) NextLevelAbilityObj.SetActive(!bMaxLevel);
	}

	private void SetManagerAbility(string abilityIconKey, BigInteger abilityValue_PerMile)
	{
		if (AbilityObj != null) AbilityObj.SetActive(true);
		SetManagerAbilityValueText(abilityValue_PerMile);
	}

	private void SetManagerAbilityValueText(BigInteger abilityValue_PerMile)
	{
		if (AbilityValueText != null)
			AbilityValueText.text = ProjectUtility.GetThousandCommaText(abilityValue_PerMile);
	}

	private void SetManagerNextLevelAbilityValueText(BigInteger abilityValue_PerMile)
	{
		if (NextLevelAbilityValueText != null)
			NextLevelAbilityValueText.text = ProjectUtility.GetThousandCommaText(abilityValue_PerMile);
	}

	private void SetManagerLevelUpExpInfo(BigInteger needCost, BigInteger hasValue_PerMile)
	{
		bEnoughCost = hasValue_PerMile >= needCost;
		if (LvUpCostExpText != null)
			LvUpCostExpText.SetText(ProjectUtility.GetThousandCommaText(needCost));
		SetLevelBtnInteractable(bEnoughCost && !bMaxLevel);
	}

	private void SetLevelBtnInteractable(bool bInteractable)
	{
		if (LvUpBtnPressed != null)
			LvUpBtnPressed.gameObject.SetActive(bInteractable || !bMaxLevel);
	}

	private void UpdateLevelData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void SubscribeEvents(SeasonalWorkshopManagerData managerData)
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
		if (managerData == null) return;
	}

	private void OnClickedManagerLevelUpBtn()
	{
		if (bMaxLevel) return;
		if (!bEnoughCost) return;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		isLeveledUp = true;
		if (LvUpParticle != null) LvUpParticle.SetActive(true);
		UpdateLevelData();
	}

	private void ShowLevelUpPackage()
	{
	}

	private void SetPackageBanner()
	{
		if (PackageBanner == null) return;
		PackageBanner.gameObject.SetActive(false);
	}
}
