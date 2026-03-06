using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupShopAdsGem", false, false)]
public class PopupShopAdsGem : UIBase
{
	[SerializeField]
	private ItemArticle item;

	[Header("ads box")]
	[SerializeField]
	private GameObject adsObj;

	[SerializeField]
	private GameObject adsTicketObj;

	[SerializeField]
	private Button adsBtn;

	[SerializeField]
	private Button adsTicketBtn;

	[SerializeField]
	private Text ticketCountText;

	private ShopCurrencyData curTarget;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		if (adsBtn != null) adsBtn.onClick.AddListener(OnClickBuy);
		if (adsTicketBtn != null) adsTicketBtn.onClick.AddListener(OnClickBuy);
	}

	public void Init(int shopIdx)
	{
		curTarget = null;
		RefreshBtn(true);
		Show();
	}

	private void RefreshBtn(bool on)
	{
		if (adsObj != null) adsObj.SetActive(on);
		if (adsTicketObj != null) adsTicketObj.SetActive(!on);
	}

	private void OnClickBuy()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		RewardAndReset();
	}

	private void RewardAndReset()
	{
		Hide();
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
