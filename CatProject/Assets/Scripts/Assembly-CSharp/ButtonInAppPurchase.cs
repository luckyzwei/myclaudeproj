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
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBuyBtn);
	}

	public void SetShopPackage(int shopPackageIdx)
	{
		TableIdx = shopPackageIdx;
	}

	public void SetShopSpecial(int shopSpecialIdx)
	{
		TableIdx = shopSpecialIdx;
	}

	public void SetProduct(string productId)
	{
		ProductId = productId;
		var info = GetProductInfo(productId);
		if (BuyPriceText != null && info.Price != null)
			BuyPriceText.text = info.Price;
	}

	private void SetSaleInfo(int salePercent, ProductInfo productInfo)
	{
		if (SaleObj != null) SaleObj.SetActive(salePercent > 0);
		if (SalePercentText != null) SalePercentText.text = salePercent + "%";
	}

	private ProductInfo GetProductInfo(string productId)
	{
		return default(ProductInfo);
	}

	private void OnClickBuyBtn()
	{
		OnClickBuyEvent?.Invoke();
	}
}
