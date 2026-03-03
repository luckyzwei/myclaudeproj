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
	}

	public void Init(int shopIdx)
	{
	}

	private void RefreshBtn(bool on)
	{
	}

	private void OnClickBuy()
	{
	}

	private void RewardAndReset()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
