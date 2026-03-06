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
		Location = location;
		PackageIdx = idx;
		showLock = true;
		OnDirectionEnd = closeCb;
		// Load and show package contents
	}

	public void ShowSpecial(ShopSystem.InAppPurchaseLocation location, int Idx)
	{
		Location = location;
		PackageIdx = Idx;
		showLock = true;
		// Load and show special package
	}

	public void ShowManagedSaleList(ShopSystem.InAppPurchaseLocation location, bool skipLog = false)
	{
		Location = location;
		showLock = true;
		if (!skipLog) LogRepopupStarter();
	}

	public void ShowSaleList(int shopSaleIdx, ShopSystem.InAppPurchaseLocation location, bool skipLog = false)
	{
		Location = location;
		PackageIdx = shopSaleIdx;
		showLock = true;
		if (!skipLog) LogRepopupStarter();
	}

	private void BuyPackage(int idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		// Process package purchase via ShopSystem
	}

	private void BuySpecial(int idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		// Process special package purchase
	}

	private void BuySaleList(int idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		// Process sale list purchase
	}

	public override void OnShowBefore()
	{
		showLock = false;
	}

	public override void Hide()
	{
		showLock = false;
		OnDirectionEnd?.Invoke();
		OnDirectionEnd = null;
		base.Hide();
	}

	private void OnDestroy()
	{
		OnDirectionEnd = null;
	}

	private void LogRepopupStarter()
	{
		// Log re-popup analytics event
	}
}
