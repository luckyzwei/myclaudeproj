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

	public HUDTopInfo GetHUDTopInfo => null;

	public Transform GetRewardEffectStartTr => null;

	public Transform GetSkillBookEffectEndTr => null;

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	public override void Hide()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void InitPage()
	{
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
	}

	public void UpdateCoinBankValue()
	{
	}

	private void AddCoinBankValue(int value)
	{
	}

	private void UpdatePackage()
	{
	}
}
