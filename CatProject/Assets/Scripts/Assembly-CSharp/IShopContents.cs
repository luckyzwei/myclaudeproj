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
		// Arrow UI controlled by subclass
	}

	public void HideArrow()
	{
		// Arrow UI controlled by subclass
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
		// Subclass-specific params handling
	}

	public void SetIsAutoReset(bool isAutoReset)
	{
		this.isAutoReset = isAutoReset;
	}

	public void UpdatePurchaseLocation()
	{
		// Purchase location update handled by shop system
	}
}
