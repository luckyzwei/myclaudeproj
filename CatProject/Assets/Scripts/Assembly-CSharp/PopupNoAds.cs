using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupNoAds", false, false)]
public class PopupNoAds : UIBase
{
	[SerializeField]
	private Text OfflineDescText;

	[SerializeField]
	private Text MissionDescText;

	[Space(5f)]
	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject PurchaseDone;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickPurchase()
	{
	}
}
