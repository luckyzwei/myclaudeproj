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
		base.Awake();
		if (GoShopBtn != null) GoShopBtn.onClick.AddListener(OnClickGotoShop);
	}

	public void Init(int need, ShopSystem.InAppPurchaseLocation _location = ShopSystem.InAppPurchaseLocation.popup)
	{
		location = _location;
	}

	private void OnClickGotoShop()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickRecommandPurchase(int itemIdx)
	{
		Hide();
	}
}
