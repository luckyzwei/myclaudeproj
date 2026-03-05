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

	private Action purchaseCb;

	private Action<RewardItemData> purchaseFailedCb;

	private bool isAutoReset;

	public virtual void Init()
	{
		if (items != null)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i] != null)
					items[i].gameObject.SetActive(true);
			}
		}
	}

	public virtual void Reset()
	{
		if (isAutoReset)
			Init();
	}

	public void ShowArrow()
	{
		// Show navigation arrow pointing to this shop section
	}

	public void HideArrow()
	{
		// Hide navigation arrow
	}

	public void SetPurchaseCb(Action cb)
	{
		purchaseCb = cb;
	}

	public void SetPurchaseFailedCb(Action<RewardItemData> cb)
	{
		purchaseFailedCb = cb;
	}

	public void SetParams(params object[] a_params)
	{
		// Store additional parameters for shop contents
	}

	public void SetIsAutoReset(bool isAutoReset)
	{
		this.isAutoReset = isAutoReset;
	}

	public void UpdatePurchaseLocation()
	{
		// Update purchase location for all items in this shop section
	}
}
