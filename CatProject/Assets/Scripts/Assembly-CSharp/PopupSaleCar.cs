using System;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupSaleCar", false, false)]
public class PopupSaleCar : UIBase
{
	[SerializeField]
	private Image SalePriceImg;

	[SerializeField]
	private Text SalePrice;

	[SerializeField]
	private Text SaleRichPoint;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Button SaleBtn;

	[SerializeField]
	private Button CancelBtn;

	[SerializeField]
	private GameObject MoneyLimitObj;

	[SerializeField]
	private HudTopComponent hud;

	[Header("RichPoint")]
	[SerializeField]
	private Text RichPointText;

	[SerializeField]
	private Button RichPointInfoBtn;

	public Action SaleCallback;

	private int CarIdx;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		if (SaleBtn != null) SaleBtn.onClick.AddListener(OnClickSale);
		if (CancelBtn != null) CancelBtn.onClick.AddListener(() => Hide());
		if (RichPointInfoBtn != null) RichPointInfoBtn.onClick.AddListener(OnClickRichPointInfo);
	}

	public void SetCar(int idx)
	{
		CarIdx = idx;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (MoneyLimitObj != null) MoneyLimitObj.SetActive(false);
		SetRichPoint();

		Show();
	}

	private void OnClickSale()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SaleCallback?.Invoke();
		Hide();
	}

	private void OnClickRichPointInfo()
	{
		// Show rich point info popup
	}

	private void SetRichPoint()
	{
		if (RichPointText != null) RichPointText.text = "0";
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
