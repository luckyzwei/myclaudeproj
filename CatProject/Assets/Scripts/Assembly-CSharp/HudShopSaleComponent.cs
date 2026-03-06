using System;
using UnityEngine;
using UnityEngine.UI;

public class HudShopSaleComponent : MonoBehaviour
{
	[Header("ShopSale")]
	[SerializeField]
	private Button ShopSaleBtn;

	[SerializeField]
	private Image ShopSaleIconImage;

	[SerializeField]
	private Text ShopSaleRemainText;

	private IDisposable RemainShopSaleTimeDisposable;

	private void Awake()
	{
		if (ShopSaleBtn != null) ShopSaleBtn.onClick.AddListener(OnClickShopSale);
	}

	public void Set()
	{
		SetShopSaleButton();
	}

	private void SetShopSaleButton()
	{
		if (ShopSaleBtn != null) ShopSaleBtn.gameObject.SetActive(false);
	}

	private void OnClickShopSale()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
