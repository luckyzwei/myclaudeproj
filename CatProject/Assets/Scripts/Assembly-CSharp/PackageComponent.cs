using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;

public class PackageComponent : MonoBehaviour
{
	[Header("[PackageComponent]")]
	[SerializeField]
	protected Transform Root;

	[SerializeField]
	protected GameObject PackageItem;

	[SerializeField]
	protected itemPackageGroupAllPurchase PurchaseAllPackage;

	public bool IgnoreGroup;

	public Action HideCb;

	private ShopPackageData Info;

	protected List<ItemPackageGroup> ItemPackageGroups;

	protected List<GameObject> ItemPackageInstList;

	protected int PackageGroup;

	public int PackageIdx { get; protected set; }

	public virtual void Set(int packageIdx)
	{
		PackageIdx = packageIdx;
	}

	public virtual void SetSpecial(int packageIdx)
	{
		PackageIdx = packageIdx;
	}

	public virtual void SetSaleList(int shopSaleGroup)
	{
		PackageGroup = shopSaleGroup;
		if (ItemPackageGroups == null)
			ItemPackageGroups = new List<ItemPackageGroup>();
		if (ItemPackageInstList == null)
			ItemPackageInstList = new List<GameObject>();
	}

	private void OnDisable()
	{
		HideCb?.Invoke();
	}

	private void OnDestroy()
	{
		if (ItemPackageInstList != null)
		{
			for (int i = 0; i < ItemPackageInstList.Count; i++)
			{
				if (ItemPackageInstList[i] != null)
					Destroy(ItemPackageInstList[i]);
			}
			ItemPackageInstList.Clear();
		}
		ItemPackageGroups?.Clear();
	}

	public virtual void OnBuySuccess(int idx)
	{
		SetSaleList(PackageGroup);
	}

	public void SetClickCbs(Action<int> _clickCb)
	{
		if (ItemPackageGroups == null) return;
		for (int i = 0; i < ItemPackageGroups.Count; i++)
		{
			if (ItemPackageGroups[i] != null)
				ItemPackageGroups[i].ClickCb = _clickCb;
		}
	}

	public void SetHideCbs(Action hideCb)
	{
		HideCb = hideCb;
		if (ItemPackageGroups == null) return;
		for (int i = 0; i < ItemPackageGroups.Count; i++)
		{
			if (ItemPackageGroups[i] != null)
				ItemPackageGroups[i].HideCb = hideCb;
		}
	}
}
