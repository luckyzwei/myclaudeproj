using System;
using Treeplla;
using UnityEngine;

[UIPath("UI/Page/PagePackage", false, false)]
public class PagePackage : FullScreenUI
{
	[SerializeField]
	private Transform Root;

	private int PackageIdx;

	private ShopSystem.InAppPurchaseLocation Location;

	public static bool showLock;

	public Action OnDirectionEnd;

	public PackageComponent Package { get; private set; }

	public void Show(ShopSystem.InAppPurchaseLocation location, int idx, Action closeCb = null, bool ignoreGroup = false)
	{
	}

	public void ShowSpecial(ShopSystem.InAppPurchaseLocation location, int Idx)
	{
	}

	public void ShowManagedSaleList(ShopSystem.InAppPurchaseLocation location, bool skipLog = false)
	{
	}

	public void ShowSaleList(int shopSaleIdx, ShopSystem.InAppPurchaseLocation location, bool skipLog = false)
	{
	}

	private void BuyPackage(int idx)
	{
	}

	private void BuySpecial(int idx)
	{
	}

	private void BuySaleList(int idx)
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void Hide()
	{
	}

	private void OnDestroy()
	{
	}

	private void LogRepopupStarter()
	{
	}
}
