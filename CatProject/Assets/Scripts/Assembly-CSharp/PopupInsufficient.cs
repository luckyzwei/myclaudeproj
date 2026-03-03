using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupInsufficient", false, false)]
public class PopupInsufficient : UIBase
{
	[SerializeField]
	private Button GoShopBtn;

	[Header("recommand")]
	[SerializeField]
	private ItemShopProduct recommandItem;

	private ShopSystem.InAppPurchaseLocation location;

	protected override void Awake()
	{
	}

	public void Init(int need, ShopSystem.InAppPurchaseLocation _location = ShopSystem.InAppPurchaseLocation.popup)
	{
	}

	private void OnClickGotoShop()
	{
	}

	private void OnClickRecommandPurchase(int itemIdx)
	{
	}
}
