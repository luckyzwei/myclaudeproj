using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopTabManager : MonoBehaviour, ITabToggleTab
{
	[SerializeField]
	private ScrollRect ShopScroll;

	[SerializeField]
	private List<IShopContents> ShopContents;

	private HUDTopInfo HudTopInfo;

	private ShopContentsSkillStoneBox ShopContentsSkillStoneBox;

	private CompositeDisposable Disposables;

	public void Init(HUDTopInfo hudTopInfo)
	{
		HudTopInfo = hudTopInfo;
		Disposables = new CompositeDisposable();

		if (ShopContents != null)
		{
			for (int i = 0; i < ShopContents.Count; i++)
			{
				if (ShopContents[i] != null)
					ShopContents[i].Init();
			}
		}

		SetHudTopInfo();
	}

	public void Refresh()
	{
		if (ShopContents == null) return;
		for (int i = 0; i < ShopContents.Count; i++)
		{
			if (ShopContents[i] != null)
				ShopContents[i].Init();
		}
	}

	public void Reset()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void FocusOnItemCoroutine(PageShop.ShopContentsType focusContents)
	{
		if (ShopScroll == null || ShopContents == null) return;
	}

	public void ShowArrow(PageShop.ShopContentsType type)
	{
		if (ShopContents == null) return;
	}

	public void HideArrows()
	{
		if (ShopContents == null) return;
	}

	private void SetHudTopInfo()
	{
		if (HudTopInfo == null) return;
		HudTopInfo.gameObject.SetActive(true);
	}

	private void OnPurchaseFailed(RewardItemData costData)
	{
		// Show popup indicating insufficient currency for purchase
		if (costData == null) return;
	}

	private void OnPurchaseFailedSkillStone(RewardItemData costData)
	{
		// Show popup indicating insufficient skill stones
		if (costData == null) return;
	}
}
