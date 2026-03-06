using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/HouseCarInfo", true)]
[FloatingDepth(14)]
public class InGameHouseCarInfo : InGameFloatingUI
{
	[SerializeField]
	private Text CarName;

	[SerializeField]
	private Text CarDesc;

	[SerializeField]
	private Image CarLogo;

	[SerializeField]
	private Text CarPoint;

	[SerializeField]
	private Button EquipBtn;

	[SerializeField]
	private GameObject EquipCompObj;

	[SerializeField]
	private Button SaleBtn;

	private Action SellCarAction;

	private int CarIdx;

	private void Awake()
	{
		if (EquipBtn != null) EquipBtn.onClick.AddListener(OnClickEquip);
		if (SaleBtn != null) SaleBtn.onClick.AddListener(OnClickSale);
	}

	public override void Init(Transform parent, GameType type = GameType.House)
	{
		base.Init(parent, type);
	}

	public void Set(int caridx, Action sellCarAction)
	{
		CarIdx = caridx;
		SellCarAction = sellCarAction;
		if (EquipCompObj != null) EquipCompObj.SetActive(false);
	}

	private void OnClickEquip()
	{
		if (EquipCompObj != null) EquipCompObj.SetActive(true);
	}

	private void OnClickSale()
	{
		SellCarAction?.Invoke();
	}

	public override void Hide()
	{
		base.Hide();
	}
}
