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

	public int BuildingIdx { get { return buildingIdx; } }

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
		if (RevenueBtn != null) RevenueBtn.onClick.AddListener(OnClickGetRevenue);
		prev_open = false;
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
		base.Init(parent, type);
	}

	public override void Show()
	{
		base.Show();
	}

	public void Set(int idx)
	{
		buildingIdx = idx;
		SetReddot();
		UpdateRevenue();
	}

	private void SetReddot()
	{
	}

	public void UpdateRevenue()
	{
		if (RevenueRoot != null)
		{
			// Show/hide revenue UI based on building state
		}
	}

	public void ShowOpenState()
	{
		prev_open = true;
		if (SignAni != null) SignAni.Play("Open");
	}

	private void OnClickBtn()
	{
		clickAction?.Invoke(buildingIdx);
	}

	public void OnClickGetRevenue()
	{
	}

	public void SetArrowNoti()
	{
		if (ArrowNoti != null)
		{
			ArrowNoti.SetActive(true);
			// Auto-hide after ArrowNotiShowTime
		}
	}
}
