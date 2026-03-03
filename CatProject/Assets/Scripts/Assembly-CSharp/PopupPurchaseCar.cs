using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupPurchaseCar", false, false)]
public class PopupPurchaseCar : UIBase
{
	[SerializeField]
	private ItemCarMarket CarMarketItem;

	[SerializeField]
	private HudTopComponent Hud;

	public void SetCar(int carIdx)
	{
	}

	private void OnBuyCar(int carIdx)
	{
	}
}
