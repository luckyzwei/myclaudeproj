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
		// Cleanup
	}

	private void Update()
	{
		// Update logic
	}

	private void UpdateSuperStaff()
	{
		if (superStaffBtn == null) return;
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
		if (RichPointText != null)
			RichPointText.text = "0";
	}

	private void SetRichAchieve()
	{
		SetRichAchieveBtn();
		SubRichAchieveNoti();
	}

	private void SubRichAchieveNoti()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void SetRichAchieveBtn()
	{
		SetRichAchieveBtnState();
	}

	private void SetRichAchieveBtnState()
	{
		if (RichWayProgress == null) return;
		RichWayProgress.UpdateActive();
	}

	public void ShowRichAchieveGuide(float waitTime)
	{
		if (RichWayProgress == null) return;
	}

	public void RichAchieveHUDStartEffect()
	{
		if (RichWayProgress == null) return;
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
			RichWayProgress.UpdateActive();
		}
	}

	private void SetStageMovePackage()
	{
		if (StageMovePackageRoot == null) return;
		StageMovePackageRoot.SetActive(false);
	}

	private void OnClickOption()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void OnClickOffice()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.Main);
	}

	private void OnClickFactory()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.Factory);
	}

	private void OnClickHouse()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.House);
	}

	private void OnClickWorldMission()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupWorldMissionOpen>();
	}

	private void OnClickRichPointInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickRegionMove()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;
		var inGame = root.InGameSystem.CurInGame;
		if (inGame == null) return;
	}

	private void OnClickCarBook()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageCarMarket>();
	}

	private void OnClickStageMovePackage()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
