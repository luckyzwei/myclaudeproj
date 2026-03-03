using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/BuildingUI", true)]
[FloatingDepth(13)]
public class InGameWorldBuildingUI : InGameFloatingUI
{
	[SerializeField]
	private Animator SignAni;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image Bg;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private GameNotificationRegister Reddot;

	[SerializeField]
	private GameNotificationRegister ArrowReddot;

	[SerializeField]
	private GameObject ArrowNoti;

	[Header("Revenue")]
	[SerializeField]
	private Button RevenueBtn;

	[SerializeField]
	private GameObject RevenueRoot;

	[SerializeField]
	private Image RevenueImg;

	[SerializeField]
	private Text RevenueValue;

	[SerializeField]
	private Slider RevenueTimeProgress;

	[SerializeField]
	private GameNotificationRegister RevenueMaxReddot;

	[SerializeField]
	private Transform RevenueTweenRoot;

	[SerializeField]
	private GameNotificationRegister FirstRevenueReddot;

	[SerializeField]
	private float ArrowNotiShowTime;

	private int buildingIdx;

	public Action<int> clickAction;

	private bool prev_open;

	public int BuildingIdx => 0;

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
	}

	public override void Show()
	{
	}

	public void Set(int idx)
	{
	}

	private void SetReddot()
	{
	}

	public void UpdateRevenue()
	{
	}

	public void ShowOpenState()
	{
	}

	private void OnClickBtn()
	{
	}

	public void OnClickGetRevenue()
	{
	}

	public void SetArrowNoti()
	{
	}
}
