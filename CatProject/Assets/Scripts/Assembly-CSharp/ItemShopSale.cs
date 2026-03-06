using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopSale : ItemPackageGroup
{
	[Header("[ItemShopSale]")]
	[SerializeField]
	private GameObject TomorrowRootObj;

	[SerializeField]
	private GameObject TomorrowTimeObj;

	[SerializeField]
	private GameObject TomorrowLastObj;

	[SerializeField]
	private Text RemainBuyCountText;

	[SerializeField]
	private List<GameObject> SoldOutDectiveObjList;

	private Config.E_ShopSaleListType ShopSaleListType;

	private Config.E_ShopSaleItemResetType SaleResetType;

	private bool isLock;

	private bool isLastDay;

	private bool isRedDot;

	private DateTime SaleStartTime;

	private DateTime NextResetTime;

	public override void Set(int packageIdx)
	{
		base.Set(packageIdx);
		UpdateBuyInfo();
	}

	private void Update()
	{
		// Update logic
	}

	public void UpdateBuyInfo()
	{
		UpdateRedDot();
	}

	private void UpdateRedDot()
	{
		isRedDot = false;
	}

	public bool CheckCompanyExp()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	protected override void OnClickBuy()
	{
		base.OnClickBuy();
	}

	public override void OnBuySuccess()
	{
		UpdateBuyInfo();
	}
}
