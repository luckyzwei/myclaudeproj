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
	}

	public override void Init()
	{
	}

	public void SetSpecialPackage(int specialIdx)
	{
	}

	private void SetShopGoods(int shopGoodsIdx)
	{
	}

	private void SetBannerColor(Config.ItemIdx itemIdx)
	{
	}

	public void OnClickBtn()
	{
	}

	private void PurchasePackage()
	{
	}

	private void PurchaseShopGoods()
	{
	}

	private (int, int) GetShopGoodsIdx(Config.ItemIdx itemIdx)
	{
		return default((int, int));
	}
}
