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
		base.Awake();
		if (FreeItemBuyButton != null) FreeItemBuyButton.onClick.AddListener(OnClickFreeItemBuyButton);
	}

	public void Init(int scheduleIdx, int eventIdx)
	{
		ScheduleIdx = scheduleIdx;
		EventIdx = eventIdx;
		FreeItemMaxCount = 0;

		if (FreeItemRoot != null) FreeItemRoot.SetActive(false);
		if (IAPItemRoot != null) IAPItemRoot.SetActive(false);

		Show();
	}

	private void SetFreeItem(MiniGameShopData shopTable)
	{
		if (shopTable == null || FreeItemRoot == null) return;
		FreeItemRoot.SetActive(true);
		UpdateFreeItemCount();
	}

	private void SetIAPItem(MiniGameShopData shopTable)
	{
		if (shopTable == null || IAPItemRoot == null) return;
		IAPItemRoot.SetActive(true);
	}

	private void UpdateFreeItemCount()
	{
		if (FreeItemBuyCountText != null)
			FreeItemBuyCountText.text = FreeItemMaxCount.ToString();
	}

	private void OnClickFreeItemBuyButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SetReward(FreeItemIdx);
		UpdateFreeItemCount();
	}

	private void OnClickIAPItem()
	{
	}

	private void SetReward(int itemIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
