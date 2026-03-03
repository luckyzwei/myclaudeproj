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
	}

	public void SetCar(int idx)
	{
	}

	private void OnClickSale()
	{
	}

	private void OnClickRichPointInfo()
	{
	}

	private void SetRichPoint()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
