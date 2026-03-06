using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupReinstoneShop", false, false)]
public class PopupReinstoneShop : UIBase
{
	[SerializeField]
	private GameObject ShopContentsRoot;

	[SerializeField]
	private GameObject WeeklyShopShotCutRoot;

	[SerializeField]
	private HUDTopInfo HudTopInfo;

	[SerializeField]
	private IShopContents ShopContents;

	private int ManagerIdx;

	private Config.E_ShopInsufficientPlaceType InsufficientPlaceType;

	public override void OnShowBefore()
	{
		if (HudTopInfo != null) HudTopInfo.UpdateCurrencyInfos();
		if (ShopContents != null) ShopContents.Init();
	}

	public override void OnHideBefore()
	{
		if (ShopContents != null) ShopContents.Reset();
	}

	public void SetInsufficientInfo(int managerIdx, Config.E_ShopInsufficientPlaceType insufficientPlaceType)
	{
		ManagerIdx = managerIdx;
		InsufficientPlaceType = insufficientPlaceType;
	}

	private void OnPurchaseFailed(RewardItemData cost)
	{
		// TODO
	}
}
