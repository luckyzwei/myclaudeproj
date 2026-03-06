using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupParkingGem", false, false)]
public class PopupParkingGem : UIBase
{
	[SerializeField]
	private Button GemBtn;

	[SerializeField]
	private Text GemText;

	[SerializeField]
	private Button IAPBtn;

	[SerializeField]
	private Text PriceText;

	private int TargetParkingZone;

	private int TargetParkingSpace;

	protected override void Awake()
	{
		base.Awake();
		if (GemBtn != null) GemBtn.onClick.AddListener(OnClickPurchase);
		if (IAPBtn != null) IAPBtn.onClick.AddListener(OnClickPurchase);
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickPurchase()
	{
		Hide();
	}
}
