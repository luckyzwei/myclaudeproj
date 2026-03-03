using System;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupSkillstoneShop", false, false)]
public class PopupSkillstoneShop : UIBase
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private GameObject SkillStoneShopRootObj;

	[SerializeField]
	private ShopContentsSkillStoneBox ShopContentsSkillStone;

	[SerializeField]
	private IShopContents ShopContentsPremiumSkillStone;

	[Header("ETC")]
	[SerializeField]
	private ItemRewardGetGuideList RewardGetGuideList;

	private int ManagerIdx;

	private int SkillUpItemIdx;

	private int MoneyRegionIdx;

	private IDisposable Disposable;

	public Config.E_ShopInsufficientPlaceType InsufficientPlaceType { get; private set; }

	public void Set(int managerIdx, Config.E_ShopInsufficientPlaceType insufficientPlaceType)
	{
	}

	private void InitHudTopInfo()
	{
	}

	private void UpdateHudTopInfo()
	{
	}

	private void OnPurchaseFailed(RewardItemData cost)
	{
	}

	public override void OnHideBefore()
	{
	}
}
