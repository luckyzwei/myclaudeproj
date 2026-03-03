using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInAppPurchase : MonoBehaviour
{
	[SerializeField]
	private Text BuyPriceText;

	[SerializeField]
	private Button BuyBtn;

	[Header("Sale")]
	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text SalePercentText;

	[SerializeField]
	private Text OriginPriceText;

	public Action OnClickBuyEvent;

	public int TableIdx { get; private set; }

	public string ProductId { get; private set; }

	private void Awake()
	{
	}

	public void SetShopPackage(int shopPackageIdx)
	{
	}

	public void SetShopSpecial(int shopSpecialIdx)
	{
	}

	public void SetProduct(string productId)
	{
	}

	private void SetSaleInfo(int salePercent, ProductInfo productInfo)
	{
	}

	private ProductInfo GetProductInfo(string productId)
	{
		return default(ProductInfo);
	}

	private void OnClickBuyBtn()
	{
	}
}
