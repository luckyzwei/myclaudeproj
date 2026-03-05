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
			// Update rich way no-ads state
		}
	}

	private void Update()
	{
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
		// Update rich point text
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
		// Open options popup
	}

	private void OnClickStatue()
	{
		// Open statue popup
	}

	private void OnClickCarBook()
	{
		// Open car book page
	}

	private void OnClickEditMode()
	{
		// Toggle edit mode
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
		// Navigate to office scene
	}

	private void OnClickRichPointInfo()
	{
		// Open rich point info popup
	}
}
