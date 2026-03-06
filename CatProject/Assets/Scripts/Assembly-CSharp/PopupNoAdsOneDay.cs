using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupNoAdsOneDay", false, false)]
public class PopupNoAdsOneDay : UIBase
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
	private Text BeforeBeforePrice;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private Text Sale;

	[SerializeField]
	private Text DoubleSale;

	[SerializeField]
	private GameObject PurchaseDone;

	[SerializeField]
	private Text RemainTime;

	[SerializeField]
	private GameObject AgainObj;

	[SerializeField]
	private Text AgainText;

	private bool inPurchase;

	private CompositeDisposable disposables;

	private int AgainSale;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickPurchase);
	}

	public override void OnShowBefore()
	{
		inPurchase = false;
	}

	private void OnClickPurchase()
	{
		if (inPurchase) return;
		inPurchase = true;
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
