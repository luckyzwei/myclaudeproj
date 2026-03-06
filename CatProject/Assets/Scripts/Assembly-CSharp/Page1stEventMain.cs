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
		base.Awake();
		Disposables = new CompositeDisposable();
		RouletteMultipleIndex = 0;
		RouletteMultipleList = new List<int> { 1, 3, 5 };
		RouletteList = new List<SpecialDayRouletteData>();
		RouletteProbabilityMap = new Dictionary<int, (int startWeight, int endWeight)>();

		if (RoulettePlayButton != null) RoulettePlayButton.onClick.AddListener(OnClickRoulettePlayButton);
		if (RouletteMultipleBtn != null) RouletteMultipleBtn.onClick.AddListener(OnClickRouletteMultipleButton);
		if (RouletteBonusBtn != null) RouletteBonusBtn.onClick.AddListener(OnClickRouletteBonusButton);
		if (RouletteRatioBtn != null) RouletteRatioBtn.onClick.AddListener(OnClickRouletteRatioButton);
		if (EventInfoBtn != null) EventInfoBtn.onClick.AddListener(OnClickEventInfoButton);
		if (AttendanceBtn != null) AttendanceBtn.onClick.AddListener(OnClickAttendanceButton);
		if (PackageBtn != null) PackageBtn.onClick.AddListener(OnClickPackageButton);
		if (MissionBtn != null) MissionBtn.onClick.AddListener(OnClickMissionButton);
	}

	protected void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
		if (PackageRemainTimeDisposable != null) { PackageRemainTimeDisposable.Dispose(); PackageRemainTimeDisposable = null; }
	}

	protected void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return MainTabToggleGroup;
	}

	public void OnTabChanged(int index)
	{
	}

	public override void OnShowBefore()
	{
		SetRouletteInfo();
		UpdateRoulettePlayCountProgress();
		UpdateRoulettePlayButtonInteractable();
		SetPlayDimmed(false);

		if (PackageObj != null) PackageObj.SetActive(IsEnabledPackage());
	}

	public void SetRouletteInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateRouletteMultipleText();
		UpdateRoulettePlayCountProgress();
	}

	private void UpdateRouletteMultipleText()
	{
		if (RouletteMultipleText == null) return;
		int multiple = RouletteMultipleList != null && RouletteMultipleIndex < RouletteMultipleList.Count
			? RouletteMultipleList[RouletteMultipleIndex] : 1;
		RouletteMultipleText.text = "x" + multiple;
	}

	private void UpdateRouletteCurrencyValueText(int hasValue, int needValue)
	{
		if (NeedCurrencyValueText != null)
			NeedCurrencyValueText.text = needValue.ToString();
	}

	private void UpdateRoulettePlayCountProgress()
	{
		if (RoulettePlayCountSlider == null) return;
		RoulettePlayCountSlider.value = 0f;
		if (RoulettePlayCountText != null) RoulettePlayCountText.text = "0";
	}

	private void UpdateRoulettePlayButtonInteractable()
	{
		if (RoulettePlayButton != null)
			RoulettePlayButton.interactable = true;
	}

	private void OnClickRoulettePlayButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		int winIdx = GetRandomWinningIndex();
		OnStartSpin();
		if (SquareRouletteComponent != null)
		{
			// Start spin animation with winning index
		}
	}

	private void OnClickRouletteMultipleButton()
	{
		if (RouletteMultipleList == null || RouletteMultipleList.Count == 0) return;
		RouletteMultipleIndex = (RouletteMultipleIndex + 1) % RouletteMultipleList.Count;
		UpdateRouletteMultipleText();
	}

	private void OnClickRouletteBonusButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickRouletteRatioButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickEventInfoButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickAttendanceButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupEventAttendance>();
	}

	private void OnClickPackageButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickMissionButton()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupEventMission>();
	}

	private void OnStartSpin()
	{
		SetPlayDimmed(true);
		if (BlockObject != null) BlockObject.SetActive(true);
	}

	private void SetPlayDimmed(bool bShow)
	{
		if (PlayDimObject != null) PlayDimObject.SetActive(bShow);
	}

	private void OnCompleteSpin(int winningIndex)
	{
		SetPlayDimmed(false);
		if (BlockObject != null) BlockObject.SetActive(false);

		int multiple = RouletteMultipleList != null && RouletteMultipleIndex < RouletteMultipleList.Count
			? RouletteMultipleList[RouletteMultipleIndex] : 1;
		GetMultipleReward(multiple);

		UpdateRoulettePlayCountProgress();
		UpdateRoulettePlayButtonInteractable();
	}

	private void GetMultipleReward(int multipleCount)
	{
		if (MatchFxObj != null) MatchFxObj.SetActive(true);
	}

	private int GetRandomWinningIndex()
	{
		if (RouletteProbabilityMap == null || RouletteProbabilityMap.Count == 0) return 0;
		int totalWeight = 0;
		foreach (var kv in RouletteProbabilityMap)
			totalWeight = Mathf.Max(totalWeight, kv.Value.endWeight);
		int rand = UnityEngine.Random.Range(0, totalWeight);
		foreach (var kv in RouletteProbabilityMap)
		{
			if (rand >= kv.Value.startWeight && rand < kv.Value.endWeight)
				return kv.Key;
		}
		return 0;
	}

	private bool IsEnabledPackage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}
}
