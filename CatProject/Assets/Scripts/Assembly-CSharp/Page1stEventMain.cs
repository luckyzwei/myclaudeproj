using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/Page1stEventMain", false, false)]
public class Page1stEventMain : UIBase, ITabToggleGroup
{
	[Header("Template")]
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private TabToggleGroup MainTabToggleGroup;

	[Header("Event")]
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button EventInfoBtn;

	[Header("Roulette Play")]
	[SerializeField]
	private SquareRouletteComponent SquareRouletteComponent;

	[SerializeField]
	private Button RoulettePlayButton;

	[SerializeField]
	private Image NeedCurrencyIcon;

	[SerializeField]
	private Text NeedCurrencyValueText;

	[SerializeField]
	private GameObject BlockObject;

	[SerializeField]
	private GameObject PlayDimObject;

	[SerializeField]
	private Button RouletteRatioBtn;

	[SerializeField]
	private GameObject MatchFxObj;

	[SerializeField]
	private List<DoTweenScriptComponent> MatchDoTweenList;

	[Header("Roulette Multiple")]
	[SerializeField]
	private Button RouletteMultipleBtn;

	[SerializeField]
	private Text RouletteMultipleText;

	[SerializeField]
	private UIParticle RouletteMultipleFxObj;

	[SerializeField]
	private Text RoulettePlayCountText;

	[SerializeField]
	private Slider RoulettePlayCountSlider;

	[Header("Roulette Bonus")]
	[SerializeField]
	private Button RouletteBonusBtn;

	[Header("Shop")]
	[SerializeField]
	private Item1stEventShopTab EventShopTab;

	[Header("Attendance")]
	[SerializeField]
	private Button AttendanceBtn;

	[Header("Package")]
	[SerializeField]
	private GameObject PackageObj;

	[SerializeField]
	private Button PackageBtn;

	[SerializeField]
	private Text PackageRemainTime;

	[Header("Mission")]
	[SerializeField]
	private Button MissionBtn;

	[Header("RedDot")]
	[SerializeField]
	private List<GameObject> TabRedDots;

	private int RouletteMultipleIndex;

	private List<int> RouletteMultipleList;

	private List<SpecialDayRouletteData> RouletteList;

	private CurrencyHUDComponent AnniversaryTicketHUDComponent;

	private CompositeDisposable Disposables;

	private IDisposable PackageRemainTimeDisposable;

	public static Dictionary<int, (int startWeight, int endWeight)> RouletteProbabilityMap { get; private set; }

	protected override void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	protected void OnDisable()
	{
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return null;
	}

	public void OnTabChanged(int index)
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SetRouletteInfo()
	{
	}

	private void UpdateRouletteMultipleText()
	{
	}

	private void UpdateRouletteCurrencyValueText(int hasValue, int needValue)
	{
	}

	private void UpdateRoulettePlayCountProgress()
	{
	}

	private void UpdateRoulettePlayButtonInteractable()
	{
	}

	private void OnClickRoulettePlayButton()
	{
	}

	private void OnClickRouletteMultipleButton()
	{
	}

	private void OnClickRouletteBonusButton()
	{
	}

	private void OnClickRouletteRatioButton()
	{
	}

	private void OnClickEventInfoButton()
	{
	}

	private void OnClickAttendanceButton()
	{
	}

	private void OnClickPackageButton()
	{
	}

	private void OnClickMissionButton()
	{
	}

	private void OnStartSpin()
	{
	}

	private void SetPlayDimmed(bool bShow)
	{
	}

	private void OnCompleteSpin(int winningIndex)
	{
	}

	private void GetMultipleReward(int multipleCount)
	{
	}

	private int GetRandomWinningIndex()
	{
		return 0;
	}

	private bool IsEnabledPackage()
	{
		return false;
	}
}
