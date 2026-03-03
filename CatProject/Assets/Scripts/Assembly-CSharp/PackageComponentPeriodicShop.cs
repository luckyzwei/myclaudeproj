using System;
using UnityEngine;
using UnityEngine.UI;

public class PackageComponentPeriodicShop : PackageComponent
{
	private readonly string RemainTimeTextKey;

	private readonly string RemainTimeTextKeyLastDay;

	[SerializeField]
	private ScrollRect ScrollRect;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text DailyResetTimeText;

	[SerializeField]
	private TimeComponent SaleEndTimeComponent;

	[SerializeField]
	private bool JustShowRemainTime;

	private DateTime ShopSaleStartTime;

	private DateTime ShopSaleEndTime;

	private DateTime NextResetTime;

	private Config.E_ShopSaleItemResetType PurchaseResetType;

	private bool isLastDay;

	public override void SetSaleList(int shopSaleListIdx)
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateRemainTime()
	{
	}

	public override void OnBuySuccess(int idx)
	{
	}
}
