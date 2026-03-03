using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupPackageConfirm", false, false)]
public class PopupPackageConfirm : UIBase
{
	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private Button buyBtn;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text BeforePriceText;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Text descText;

	private int pid;

	private ShopSystem.InAppPurchaseLocation location;

	protected override void Awake()
	{
	}

	public void Show(ShopSystem.InAppPurchaseLocation location, int PackageIdx)
	{
	}

	private void OnClickBuy()
	{
	}
}
