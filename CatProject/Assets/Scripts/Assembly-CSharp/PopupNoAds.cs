using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupNoAds", false, false)]
public class PopupNoAds : UIBase
{
	[SerializeField]
	private Text OfflineDescText;

	[SerializeField]
	private Text MissionDescText;

	[Space(5f)]
	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject PurchaseDone;

	protected override void Awake()
	{
		base.Awake();
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickPurchase);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		bool noAds = root.ShopSystem.NoAds;
		if (PurchaseDone != null) PurchaseDone.SetActive(noAds);
		if (BuyBtn != null) BuyBtn.gameObject.SetActive(!noAds);
	}

	private void OnClickPurchase()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
	}
}
