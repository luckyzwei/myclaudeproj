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
	}

	public override void Init(Transform parent, GameType type = GameType.House)
	{
	}

	public void Set(int caridx, Action sellCarAction)
	{
	}

	private void OnClickEquip()
	{
	}

	private void OnClickSale()
	{
	}

	public override void Hide()
	{
	}
}
