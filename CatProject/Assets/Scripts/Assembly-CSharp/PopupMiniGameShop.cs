using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMiniGameShop", false, false)]
public class PopupMiniGameShop : UIBase
{
	[Header("Free")]
	[SerializeField]
	private GameObject FreeItemRoot;

	[SerializeField]
	private ItemArticle FreeItemArticle;

	[SerializeField]
	private Text FreeItemBuyCountText;

	[SerializeField]
	private Button FreeItemBuyButton;

	[Header("IAP")]
	[SerializeField]
	private GameObject IAPItemRoot;

	[SerializeField]
	private List<ItemArticle> IAPItemArticles;

	[SerializeField]
	private ButtonInAppPurchase IAPItemButton;

	private int ScheduleIdx;

	private int EventIdx;

	private int FreeItemIdx;

	private int FreeItemMaxCount;

	private int IAPItemIdx;

	protected override void Awake()
	{
	}

	public void Init(int scheduleIdx, int eventIdx)
	{
	}

	private void SetFreeItem(MiniGameShopData shopTable)
	{
	}

	private void SetIAPItem(MiniGameShopData shopTable)
	{
	}

	private void UpdateFreeItemCount()
	{
	}

	private void OnClickFreeItemBuyButton()
	{
	}

	private void OnClickIAPItem()
	{
	}

	private void SetReward(int itemIdx)
	{
	}
}
