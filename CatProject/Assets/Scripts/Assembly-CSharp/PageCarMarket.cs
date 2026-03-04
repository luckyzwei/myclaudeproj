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

	public int GetParkingZone { get { return 0; } }

	public int GetParkingSpace { get { return 0; } }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshText()
	{
	}

	public void SetBuilding(int building, int parkingZone = -1, int parkingSpace = -1, bool showConversation = true)
	{
	}

	private void Update()
	{
	}

	private void SetDayTime()
	{
	}

	private void UpdateDayStatus(DaySystem.DayStatus status)
	{
	}

	private void UpdateDayTime()
	{
	}

	private void SetMoneyHud()
	{
	}

	private void SetRichPoint()
	{
	}

	private void OnClickOption()
	{
	}

	private void OnClickRichPointInfo()
	{
	}

	private void OnClickLevelInfo()
	{
	}

	private void OnClickPrev()
	{
	}

	private void OnClickNext()
	{
	}
}
