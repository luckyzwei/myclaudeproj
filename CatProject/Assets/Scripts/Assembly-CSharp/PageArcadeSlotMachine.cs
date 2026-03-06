using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSeasonalSlotMachine", false, false)]
public class PageArcadeSlotMachine : UIBase
{
	[SerializeField]
	private Transform ContentsObjTransform;

	[SerializeField]
	private HUDTopInfo TopInfo;

	[Header("Effect")]
	[SerializeField]
	private Transform RewardEffectStartTr;

	[SerializeField]
	private Transform SkillBookEffectEndTr;

	[Header("Mission")]
	[SerializeField]
	private Button PopupMissionButton;

	[Header("Mission Buff")]
	[SerializeField]
	private GameObject MissionCoinBuffObj;

	[SerializeField]
	private Text MissionCoinBuffEndTimeText;

	[Header("CoinBank")]
	[SerializeField]
	private Button CoinBankBtn;

	[SerializeField]
	private Image CoinBankIcon;

	[SerializeField]
	private Text CoinBankValueText;

	[SerializeField]
	private GameObject CoinBankReddot;

	[SerializeField]
	private DoTweenScriptComponent CoinBankTween;

	[Header("Package")]
	[SerializeField]
	private HudPackageItem hudPackageItem;

	private ItemArcadeSlotMachine ItemArcadeSlotMachine;

	private bool bTryLoadComponent;

	public HUDTopInfo GetHUDTopInfo { get { return TopInfo; } }

	public Transform GetRewardEffectStartTr { get { return RewardEffectStartTr; } }

	public Transform GetSkillBookEffectEndTr { get { return SkillBookEffectEndTr; } }

	protected override void Awake()
	{
		base.Awake();
		if (PopupMissionButton != null) PopupMissionButton.onClick.AddListener(OnClickedPopupMissionBtn);
		if (CoinBankBtn != null) CoinBankBtn.onClick.AddListener(OnClickedCoinBankBtn);
	}

	private void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	public override void OnShowBefore()
	{
		InitPage();
	}

	public override void OnRefresh()
	{
		InitPage();
	}

	public override void Hide()
	{
		base.Hide();
	}

	public override void OnHideBefore()
	{
	}

	private void InitPage()
	{
		bTryLoadComponent = false;
		InitTopInfoCurrency();
		UpdateCoinBankValue();
		UpdatePackage();

		if (ContentsObjTransform != null && ItemArcadeSlotMachine == null)
		{
			ItemArcadeSlotMachine = ContentsObjTransform.GetComponentInChildren<ItemArcadeSlotMachine>();
		}
	}

	private void InitTopInfoCurrency()
	{
	}

	private void OnClickedPopupMissionBtn()
	{
	}

	private void OnClickedCoinBankBtn()
	{
	}

	private void OnPlayArcadeSlotMachine(int usedCoinValue)
	{
		AddCoinBankValue(usedCoinValue);
	}

	public void UpdateCoinBankValue()
	{
		if (CoinBankValueText != null) CoinBankValueText.text = "0";
		if (CoinBankReddot != null) CoinBankReddot.SetActive(false);
	}

	private void AddCoinBankValue(int value)
	{
		// Add coins to bank and update display
		UpdateCoinBankValue();
		if (CoinBankTween != null) CoinBankTween.gameObject.SetActive(true);
	}

	private void UpdatePackage()
	{
		if (hudPackageItem != null) hudPackageItem.gameObject.SetActive(false);
	}
}
