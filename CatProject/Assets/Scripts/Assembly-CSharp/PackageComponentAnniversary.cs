using System;
using UnityEngine;
using UnityEngine.UI;

public class PackageComponentAnniversary : PackageComponent
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

	private DateTime NextResetTime;

	private DateTime ShopSaleEndTime;

	private int DailyResetHour;

	private bool isLastDay;

	public override void SetSaleList(int packageIdx)
	{
		base.SetSaleList(packageIdx);
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
		UpdateRemainTime();
	}

	private void UpdateRemainTime()
	{
	}

	public override void OnBuySuccess(int idx)
	{
		base.OnBuySuccess(idx);
	}
}
