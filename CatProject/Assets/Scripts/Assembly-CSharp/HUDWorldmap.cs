using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUDWorldmap", true, false)]
public class HUDWorldmap : HUDBase
{
	[Header("[HUDWorldmap]")]
	[SerializeField]
	private Button OfficeBtn;

	[SerializeField]
	private Button FactoryBtn;

	[SerializeField]
	private Button HouseBtn;

	[SerializeField]
	private Button CarBookBtn;

	[SerializeField]
	private GameNotificationMultiRegister FactoryReddot;

	[SerializeField]
	private Button RegionMoveBtn;

	[SerializeField]
	private SuperStaffStatBtn superStaffBtn;

	[SerializeField]
	private Button WorldMissionBtn;

	[SerializeField]
	private GameObject HouseArrowNoti;

	[Header("Package")]
	[SerializeField]
	private GameObject StageMovePackageRoot;

	[SerializeField]
	private Button StageMovePackageBtn;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[Header("RichPoint")]
	[SerializeField]
	private Text RichPointText;

	[SerializeField]
	private Button RichPointInfoBtn;

	[Header("RichWay")]
	[SerializeField]
	private RichWayProgress RichWayProgress;

	private int FactoryIdx;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void Refresh(E_RefreshType refreshType)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateSuperStaff()
	{
	}

	public void SetFactory()
	{
	}

	public void SetFactoryReddot()
	{
	}

	private void SetHouse()
	{
	}

	public void ShowHouseArrowNoti()
	{
	}

	private void SetRichPoint()
	{
	}

	private void SetRichAchieve()
	{
	}

	private void SubRichAchieveNoti()
	{
	}

	private void SetRichAchieveBtn()
	{
	}

	private void SetRichAchieveBtnState()
	{
	}

	public void ShowRichAchieveGuide(float waitTime)
	{
	}

	public void RichAchieveHUDStartEffect()
	{
	}

	private Vector3 GetRichAchievePos()
	{
		return default(Vector3);
	}

	public void UpdateRichWayNoAds()
	{
	}

	private void SetStageMovePackage()
	{
	}

	private void OnClickOption()
	{
	}

	private void OnClickOffice()
	{
	}

	private void OnClickFactory()
	{
	}

	private void OnClickHouse()
	{
	}

	private void OnClickWorldMission()
	{
	}

	private void OnClickRichPointInfo()
	{
	}

	private void OnClickRegionMove()
	{
	}

	private void OnClickCarBook()
	{
	}

	private void OnClickStageMovePackage()
	{
	}
}
