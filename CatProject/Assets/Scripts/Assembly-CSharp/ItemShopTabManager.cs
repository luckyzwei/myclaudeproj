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
		// Scroll to focused contents type
	}

	public void ShowArrow(PageShop.ShopContentsType type)
	{
		if (ShopContents == null) return;
		// Show arrow indicator for specific shop contents
	}

	public void HideArrows()
	{
		if (ShopContents == null) return;
		// Hide all arrow indicators
	}

	private void SetHudTopInfo()
	{
		if (HudTopInfo == null) return;
		HudTopInfo.gameObject.SetActive(true);
	}

	private void OnPurchaseFailed(RewardItemData costData)
	{
	}

	private void OnPurchaseFailedSkillStone(RewardItemData costData)
	{
	}
}
