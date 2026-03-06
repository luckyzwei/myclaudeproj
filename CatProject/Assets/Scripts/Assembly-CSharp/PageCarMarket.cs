using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageCarMarket", false, false)]
public class PageCarMarket : UIBase, ILocalizeRefresh
{
	[Serializable]
	private class MoneyHUD
	{
		public GameObject Root;

		public Image Icon;

		public Text Count;
	}

	[Header("Day")]
	[SerializeField]
	private Image TimeIcon;

	[SerializeField]
	private Text TimeText;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[Header("RichPoint")]
	[SerializeField]
	private Text RichPointText;

	[SerializeField]
	private Button RichPointInfoBtn;

	[Header("MoneyHUD")]
	[SerializeField]
	private List<MoneyHUD> MoneyHud;

	[Header("Level")]
	[SerializeField]
	private Text LevelText;

	[SerializeField]
	private Button LevelBtn;

	[Header("CarMarket")]
	[SerializeField]
	private Text MarketName;

	[Header("List")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject CarItem;

	[Header("MoveBtns")]
	[SerializeField]
	private Button PrevBtn;

	[SerializeField]
	private Button NextBtn;

	private int BuildingIdx;

	private int ParkingZone;

	private int ParkingSpace;

	private CompositeDisposable disposables;

	public int GetParkingZone { get { return ParkingZone; } }

	public int GetParkingSpace { get { return ParkingSpace; } }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (OptionBtn != null) OptionBtn.onClick.AddListener(OnClickOption);
		if (RichPointInfoBtn != null) RichPointInfoBtn.onClick.AddListener(OnClickRichPointInfo);
		if (LevelBtn != null) LevelBtn.onClick.AddListener(OnClickLevelInfo);
		if (PrevBtn != null) PrevBtn.onClick.AddListener(OnClickPrev);
		if (NextBtn != null) NextBtn.onClick.AddListener(OnClickNext);
	}

	public override void OnShowBefore()
	{
		SetDayTime();
		SetMoneyHud();
		SetRichPoint();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	public void RefreshText()
	{
		SetRichPoint();
		SetMoneyHud();
	}

	public void SetBuilding(int building, int parkingZone = -1, int parkingSpace = -1, bool showConversation = true)
	{
		BuildingIdx = building;
		ParkingZone = parkingZone;
		ParkingSpace = parkingSpace;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (MarketName != null) MarketName.text = "";
		if (LevelText != null) LevelText.text = "";

		if (PrevBtn != null) PrevBtn.gameObject.SetActive(BuildingIdx > 0);
		if (NextBtn != null) NextBtn.gameObject.SetActive(true);
	}

	private void Update()
	{
		UpdateDayTime();
	}

	private void SetDayTime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
		UpdateDayStatus(root.DaySystem.CurTimeStatus.Value);
		UpdateDayTime();
	}

	private void UpdateDayStatus(DaySystem.DayStatus status)
	{
		// Update display
	}

	private void UpdateDayTime()
	{
		if (TimeText == null) return;
		var now = DateTime.Now;
		TimeText.text = now.ToString("HH:mm");
	}

	private void SetMoneyHud()
	{
		if (MoneyHud == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		for (int i = 0; i < MoneyHud.Count; i++)
		{
			if (MoneyHud[i] == null || MoneyHud[i].Root == null) continue;
			MoneyHud[i].Root.SetActive(true);
			if (MoneyHud[i].Count != null) MoneyHud[i].Count.text = "0";
		}
	}

	private void SetRichPoint()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (RichPointText != null) RichPointText.text = "0";
	}

	private void OnClickOption()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void OnClickRichPointInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickLevelInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickPrev()
	{
		if (BuildingIdx > 0)
			SetBuilding(BuildingIdx - 1, ParkingZone, ParkingSpace);
	}

	private void OnClickNext()
	{
		SetBuilding(BuildingIdx + 1, ParkingZone, ParkingSpace);
	}
}
