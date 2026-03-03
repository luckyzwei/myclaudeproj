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
	}

	public virtual void SetSpecial(int packageIdx)
	{
	}

	public virtual void SetSaleList(int shopSaleGroup)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void OnBuySuccess(int idx)
	{
	}

	public void SetClickCbs(Action<int> _clickCb)
	{
	}

	public void SetHideCbs(Action hideCb)
	{
	}
}
