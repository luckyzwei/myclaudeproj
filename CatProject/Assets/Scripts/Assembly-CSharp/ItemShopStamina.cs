using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopStamina : MonoBehaviour
{
	public enum PriceType
	{
		Purchase = 1,
		Cash = 2,
		Free = 3,
		Ad = 4,
		NormalKey = 5,
		PremiumKey = 6
	}

	[Header("Info")]
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image ShopImg;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text RewardCnt;

	[Header("Free")]
	[SerializeField]
	private Button FreeBtn;

	[SerializeField]
	private GameObject FreeCoolTimeObj;

	[SerializeField]
	private Text FreeCooltimeText;

	[Header("Ads Purchase")]
	[SerializeField]
	private Button AdsBtn;

	[SerializeField]
	private Text AdsCountText;

	[SerializeField]
	private GameObject AdsCooltimeObj;

	[SerializeField]
	private Text AdsCooltimeText;

	[Header("Gem Purchase")]
	[SerializeField]
	private Button GemBtn;

	[SerializeField]
	private Text GemPrice;

	private CompositeDisposable disposables;

	private ShopAuctionStaminaData shopTd;

	private Transform hudTrans;

	private void Awake()
	{
	}

	public void Set(int idx, Transform _hudTrans)
	{
	}

	private void OnClickFree()
	{
	}

	private void OnClickAds()
	{
	}

	private void OnClickCash()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
