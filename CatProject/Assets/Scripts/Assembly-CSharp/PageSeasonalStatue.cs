using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSeasonalStatue", false, false)]
public class PageSeasonalStatue : UIBase
{
	[Header("[PageSeasonalStatue]")]
	[SerializeField]
	private Image StatueImg;

	[SerializeField]
	private Text TitleText;

	[Space(5f)]
	[SerializeField]
	private Image AbilityMoneyIcon;

	[SerializeField]
	private Text AbilityMoneyText;

	[SerializeField]
	private Image AbilityHeartIcon;

	[SerializeField]
	private Text AbilityHeartText;

	[SerializeField]
	private Image AbilityBookIcon;

	[SerializeField]
	private Text AbilityBookText;

	[SerializeField]
	private List<ItemSeasonalStatueAbility> StatueAbilityList;

	[Header("Button")]
	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private GameObject PurchaseDoneObj;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Text BeforePriceText;

	[SerializeField]
	private Text AfterPriceText;

	[Header("Time")]
	[SerializeField]
	private Text SeasonEndRemainTimeText;

	private DateTime SeasonEndDateTime;

	private bool bEndSeasonTime;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
	}

	private void AddCatstaEventMissionValue()
	{
	}
}
