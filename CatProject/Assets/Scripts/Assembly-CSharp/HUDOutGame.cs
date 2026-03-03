using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HudOutGame", true, false)]
public class HUDOutGame : HUDBase
{
	[Header("[HUDOutGame]")]
	[SerializeField]
	private Button OfficeBtn;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[Header("RichPoint")]
	[SerializeField]
	private Text RichPointText;

	[SerializeField]
	private Button RichPointInfoBtn;

	[Header("EditMode")]
	[SerializeField]
	private Button EditModeBtn;

	[SerializeField]
	private List<GameObject> EditModeUnActiveObjs;

	[Header("Statue")]
	[SerializeField]
	private Button StatueBtn;

	[Header("CarBook")]
	[SerializeField]
	private Button CarBookBtn;

	[Header("ParkingSet")]
	[SerializeField]
	private GameObject RevenueBuffObj;

	[SerializeField]
	private GameObject RevenueSetObj;

	[SerializeField]
	private Image RevenueBuffIcon;

	[SerializeField]
	private Text RevenueBuffText;

	[SerializeField]
	private GameObject ExpUpBuffObj;

	[SerializeField]
	private GameObject ExpUpSetObj;

	[SerializeField]
	private Text ExpUpBuffText;

	[Header("RichWay")]
	[SerializeField]
	private RichWayProgress RichWayProgress;

	private CompositeDisposable car_disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void UpdateRichWayNoAds()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void SetRichPoint()
	{
	}

	public void SetParkingSet()
	{
	}

	public void SetEditMode()
	{
	}

	private void OnClickOption()
	{
	}

	private void OnClickStatue()
	{
	}

	private void OnClickCarBook()
	{
	}

	private void OnClickEditMode()
	{
	}

	private void OnClickOffice()
	{
	}

	private void OnClickRichPointInfo()
	{
	}
}
