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
		base.Awake();
		if (OfficeBtn != null) OfficeBtn.onClick.AddListener(OnClickOffice);
		if (FactoryBtn != null) FactoryBtn.onClick.AddListener(OnClickFactory);
		if (HouseBtn != null) HouseBtn.onClick.AddListener(OnClickHouse);
		if (CarBookBtn != null) CarBookBtn.onClick.AddListener(OnClickCarBook);
		if (RegionMoveBtn != null) RegionMoveBtn.onClick.AddListener(OnClickRegionMove);
		if (WorldMissionBtn != null) WorldMissionBtn.onClick.AddListener(OnClickWorldMission);
		if (OptionBtn != null) OptionBtn.onClick.AddListener(OnClickOption);
		if (RichPointInfoBtn != null) RichPointInfoBtn.onClick.AddListener(OnClickRichPointInfo);
		if (StageMovePackageBtn != null) StageMovePackageBtn.onClick.AddListener(OnClickStageMovePackage);
	}

	public override void OnShowBefore()
	{
		SetFactory();
		SetHouse();
		SetRichPoint();
		SetRichAchieve();
		SetStageMovePackage();
		UpdateSuperStaff();
	}

	public override void Refresh(E_RefreshType refreshType)
	{
		SetRichPoint();
		SetFactory();
		UpdateSuperStaff();
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateSuperStaff()
	{
		if (superStaffBtn == null) return;
		// Update super staff button state
	}

	public void SetFactory()
	{
		if (FactoryBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		FactoryBtn.gameObject.SetActive(FactoryIdx > 0);
		SetFactoryReddot();
	}

	public void SetFactoryReddot()
	{
		if (FactoryReddot != null)
			FactoryReddot.gameObject.SetActive(false);
	}

	private void SetHouse()
	{
		if (HouseBtn == null) return;
		bool hasHouse = ProjectUtility.HasAnyHouse();
		HouseBtn.gameObject.SetActive(hasHouse);
	}

	public void ShowHouseArrowNoti()
	{
		if (HouseArrowNoti != null) HouseArrowNoti.SetActive(true);
	}

	private void SetRichPoint()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Update rich point text
	}

	private void SetRichAchieve()
	{
		SetRichAchieveBtn();
		SubRichAchieveNoti();
	}

	private void SubRichAchieveNoti()
	{
		// Subscribe to rich achieve notifications
	}

	private void SetRichAchieveBtn()
	{
		SetRichAchieveBtnState();
	}

	private void SetRichAchieveBtnState()
	{
		// Update rich achieve button visual state
	}

	public void ShowRichAchieveGuide(float waitTime)
	{
		// Show rich achieve guide after delay
	}

	public void RichAchieveHUDStartEffect()
	{
		// Play rich achieve effect animation
	}

	private Vector3 GetRichAchievePos()
	{
		if (RichPointInfoBtn != null) return RichPointInfoBtn.transform.position;
		return default(Vector3);
	}

	public void UpdateRichWayNoAds()
	{
		if (RichWayProgress != null)
		{
			// Update rich way no-ads state
		}
	}

	private void SetStageMovePackage()
	{
		if (StageMovePackageRoot == null) return;
		StageMovePackageRoot.SetActive(false);
	}

	private void OnClickOption()
	{
		// Open options popup
	}

	private void OnClickOffice()
	{
		// Navigate to office scene
	}

	private void OnClickFactory()
	{
		// Navigate to factory scene
	}

	private void OnClickHouse()
	{
		// Navigate to house
	}

	private void OnClickWorldMission()
	{
		// Open world mission popup
	}

	private void OnClickRichPointInfo()
	{
		// Open rich point info popup
	}

	private void OnClickRegionMove()
	{
		// Open region move UI
	}

	private void OnClickCarBook()
	{
		// Open car book page
	}

	private void OnClickStageMovePackage()
	{
		// Open stage move package
	}
}
