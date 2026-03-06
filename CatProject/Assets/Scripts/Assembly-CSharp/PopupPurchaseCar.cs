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
		if (CarMarketItem != null)
		{
			// Set car market item display
		}
	}

	private void OnBuyCar(int carIdx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
