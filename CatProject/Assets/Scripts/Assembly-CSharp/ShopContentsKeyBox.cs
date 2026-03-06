using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopContentsKeyBox : IShopContents
{
	[SerializeField]
	private Config.ItemIdx KeyItemIdx;

	[SerializeField]
	private GameObject SaleRoot;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Text SalePrice;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private List<ItemArticle> listItems;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Image BannerBgImage;

	private int ShopGoodsIdx;

	private int ShopSpecialIdx;

	private bool IsSpecialPackage;

	private void Awake()
	{
		if (BuyBtn != null)
			BuyBtn.onClick.AddListener(OnClickBtn);
	}

	public override void Init()
	{
		base.Init();
		IsSpecialPackage = false;
		var result = GetShopGoodsIdx(KeyItemIdx);
		ShopGoodsIdx = result.Item1;
		ShopSpecialIdx = result.Item2;
		SetShopGoods(ShopGoodsIdx);
		SetBannerColor(KeyItemIdx);
	}

	public void SetSpecialPackage(int specialIdx)
	{
		IsSpecialPackage = true;
		ShopSpecialIdx = specialIdx;
	}

	private void SetShopGoods(int shopGoodsIdx)
	{
		ShopGoodsIdx = shopGoodsIdx;
		if (SaleRoot != null)
			SaleRoot.SetActive(false);
	}

	private void SetBannerColor(Config.ItemIdx itemIdx)
	{
		// Update display
	}

	public void OnClickBtn()
	{
		if (IsSpecialPackage)
			PurchasePackage();
		else
			PurchaseShopGoods();
	}

	private void PurchasePackage()
	{
		ProjectUtility.ShowPagePackage(InAppPurchaseLocation, ShopSpecialIdx);
	}

	private void PurchaseShopGoods()
	{
		// TODO
	}

	private (int, int) GetShopGoodsIdx(Config.ItemIdx itemIdx)
	{
		return ((int)itemIdx, 0);
	}
}
