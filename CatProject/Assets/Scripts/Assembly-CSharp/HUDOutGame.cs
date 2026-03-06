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
		base.Awake();
		car_disposables = new CompositeDisposable();
		if (OfficeBtn != null) OfficeBtn.onClick.AddListener(OnClickOffice);
		if (OptionBtn != null) OptionBtn.onClick.AddListener(OnClickOption);
		if (StatueBtn != null) StatueBtn.onClick.AddListener(OnClickStatue);
		if (CarBookBtn != null) CarBookBtn.onClick.AddListener(OnClickCarBook);
		if (EditModeBtn != null) EditModeBtn.onClick.AddListener(OnClickEditMode);
		if (RichPointInfoBtn != null) RichPointInfoBtn.onClick.AddListener(OnClickRichPointInfo);
	}

	public override void OnShowBefore()
	{
		SetRichPoint();
		SetParkingSet();
		SetEditMode();
	}

	public void UpdateRichWayNoAds()
	{
		if (RichWayProgress != null)
		{
			RichWayProgress.UpdateActive();
		}
	}

	private void Update()
	{
		// Update logic
	}

	private void OnDestroy()
	{
		if (car_disposables != null)
		{
			car_disposables.Dispose();
			car_disposables = null;
		}
	}

	private void OnDisable()
	{
		if (car_disposables != null)
		{
			car_disposables.Dispose();
			car_disposables = new CompositeDisposable();
		}
	}

	private void SetRichPoint()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (RichPointText != null)
			RichPointText.text = "0";
	}

	public void SetParkingSet()
	{
		if (RevenueBuffObj != null) RevenueBuffObj.SetActive(false);
		if (RevenueSetObj != null) RevenueSetObj.SetActive(false);
		if (ExpUpBuffObj != null) ExpUpBuffObj.SetActive(false);
		if (ExpUpSetObj != null) ExpUpSetObj.SetActive(false);
	}

	public void SetEditMode()
	{
		if (EditModeBtn == null) return;
		EditModeBtn.gameObject.SetActive(true);
	}

	private void OnClickOption()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void OnClickStatue()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupStatueGallery>();
	}

	private void OnClickCarBook()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageCarMarket>();
	}

	private void OnClickEditMode()
	{
		if (EditModeUnActiveObjs != null)
		{
			for (int i = 0; i < EditModeUnActiveObjs.Count; i++)
			{
				if (EditModeUnActiveObjs[i] != null)
					EditModeUnActiveObjs[i].SetActive(!EditModeUnActiveObjs[i].activeSelf);
			}
		}
	}

	private void OnClickOffice()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.Main);
	}

	private void OnClickRichPointInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
