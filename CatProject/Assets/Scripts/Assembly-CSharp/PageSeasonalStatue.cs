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
		base.Awake();
		if (PurchaseBtn != null) PurchaseBtn.onClick.AddListener(OnClickPurchase);
	}

	private void Update()
	{
		if (bEndSeasonTime) return;
		if (SeasonEndDateTime > DateTime.Now)
		{
			int remainSec = (int)(SeasonEndDateTime - DateTime.Now).TotalSeconds;
			SetSeasonRemainTimeText(remainSec);
		}
		else
		{
			bEndSeasonTime = true;
			SetSeasonRemainTimeText(0);
		}
	}

	public override void OnShowBefore()
	{
		bEndSeasonTime = false;
		SeasonEndDateTime = DateTime.MaxValue;
		if (PurchaseDoneObj != null) PurchaseDoneObj.SetActive(false);
	}

	public override void OnHideAfter()
	{
		base.OnHideAfter();
	}

	private void OnClickPurchase()
	{
		AddCatstaEventMissionValue();
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
		if (SeasonEndRemainTimeText != null)
			SeasonEndRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}

	private void AddCatstaEventMissionValue()
	{
		// Track event mission progress
	}
}
