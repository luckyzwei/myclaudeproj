using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupPurchaseKeys", false, false)]
public class PopupPurchaseKeys : UIBase
{
	[Header("PopupPurchaseKeys")]
	[SerializeField]
	private Image[] icons;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Text rewardValueText;

	[SerializeField]
	private Text bonusValueText;

	[Space(5f)]
	[SerializeField]
	private Text purchasePriceText;

	[SerializeField]
	private Button purchaseBtn;

	[SerializeField]
	private Text gemPriceText;

	[SerializeField]
	private Button gemBtn;

	[Space(5f)]
	[SerializeField]
	private ItemShopSpecialBanner banner;

	[SerializeField]
	private Image bannerColor;

	private int keyIdx;

	private readonly int keyBaseAmount;

	private int gemPriceValue;

	protected override void Awake()
	{
		base.Awake();
		if (purchaseBtn != null) purchaseBtn.onClick.AddListener(OnClickPurchase);
		if (gemBtn != null) gemBtn.onClick.AddListener(OnClickGem);
	}

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}

	public void Set(int _keyIdx)
	{
		keyIdx = _keyIdx;
	}

	private int ConvertShopSpecialIdx(int keyidx)
	{
		return keyidx;
	}

	private void OnClickPurchasePackage(int ShopSpecialIdx)
	{
		Hide();
	}

	private void OnClickPurchase()
	{
		OnClickPurchasePackage(ConvertShopSpecialIdx(keyIdx));
	}

	private void OnClickGem()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
