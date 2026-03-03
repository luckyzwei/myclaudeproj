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
	}

	public override void OnShowBefore()
	{
	}

	public void Set(int _keyIdx)
	{
	}

	private int ConvertShopSpecialIdx(int keyidx)
	{
		return 0;
	}

	private void OnClickPurchasePackage(int ShopSpecialIdx)
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickGem()
	{
	}
}
