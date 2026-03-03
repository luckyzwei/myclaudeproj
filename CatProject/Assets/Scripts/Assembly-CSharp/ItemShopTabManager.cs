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
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}

	public void FocusOnItemCoroutine(PageShop.ShopContentsType focusContents)
	{
	}

	public void ShowArrow(PageShop.ShopContentsType type)
	{
	}

	public void HideArrows()
	{
	}

	private void SetHudTopInfo()
	{
	}

	private void OnPurchaseFailed(RewardItemData costData)
	{
	}

	private void OnPurchaseFailedSkillStone(RewardItemData costData)
	{
	}
}
