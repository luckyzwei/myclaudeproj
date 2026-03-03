using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class IShopContents : MonoBehaviour
{
	[Header("IShopContents")]
	[SerializeField]
	protected List<ItemShopProduct> items;

	[SerializeField]
	protected bool CheckContentsOpenType;

	[SerializeField]
	protected Config.ContentsOpenType ContentsOpenType;

	[SerializeField]
	protected ShopSystem.InAppPurchaseLocation InAppPurchaseLocation;

	public virtual void Init()
	{
	}

	public virtual void Reset()
	{
	}

	public void ShowArrow()
	{
	}

	public void HideArrow()
	{
	}

	public void SetPurchaseCb(Action cb)
	{
	}

	public void SetPurchaseFailedCb(Action<RewardItemData> cb)
	{
	}

	public void SetParams(params object[] a_params)
	{
	}

	public void SetIsAutoReset(bool isAutoReset)
	{
	}

	public void UpdatePurchaseLocation()
	{
	}
}
