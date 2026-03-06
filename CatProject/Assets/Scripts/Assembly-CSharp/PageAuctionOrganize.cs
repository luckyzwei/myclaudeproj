using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAuctionOrganize", false, false)]
public class PageAuctionOrganize : UIBase
{
	[Header("LevelInfo")]
	[SerializeField]
	private Text RoundCountText;

	[SerializeField]
	private Text TotalCoinText;

	[Header("EquipInfo")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject AddManagerItem;

	[Header("Btn")]
	[SerializeField]
	private Button PlayBtn;

	[SerializeField]
	private Text UseStamina;

	[SerializeField]
	private Button ResetBtn;

	[SerializeField]
	private Button AutoOrganizeBtn;

	[Header("HUD")]
	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text StaminaRemainTime;

	[SerializeField]
	private GameObject StaminaTimeRoot;

	[SerializeField]
	private Button StanimaShopBtn;

	[SerializeField]
	private Text GemText;

	[SerializeField]
	private Button GemShopBtn;

	[SerializeField]
	private GameObject Point2xTrialNotiObj;

	[SerializeField]
	private Button Point2xTrialBtn;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (PlayBtn != null) PlayBtn.onClick.AddListener(OnClickStartAuction);
		if (ResetBtn != null) ResetBtn.onClick.AddListener(OnClickReset);
		if (AutoOrganizeBtn != null) AutoOrganizeBtn.onClick.AddListener(OnClickAuto);
		if (StanimaShopBtn != null) StanimaShopBtn.onClick.AddListener(OnClickStaminaShop);
		if (GemShopBtn != null) GemShopBtn.onClick.AddListener(OnClickGemShop);
		if (Point2xTrialBtn != null) Point2xTrialBtn.onClick.AddListener(OnClickPoint2xTrial);
	}

	public override void OnShowBefore()
	{
		UpdateRoundSlot();
		if (Point2xTrialNotiObj != null) Point2xTrialNotiObj.SetActive(false);
	}

	public void UpdateRoundSlot()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Update round and coin info
		if (RoundCountText != null) RoundCountText.text = "";
		if (TotalCoinText != null) TotalCoinText.text = "0";
	}

	private void OnClickAuto()
	{
		// Auto organize auction managers
		UpdateRoundSlot();
	}

	private void OnClickSpy()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickStartAuction()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AuctionSystem == null) return;
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageAuction>();
	}

	private void OnClickReset()
	{
		// Reset auction team
		UpdateRoundSlot();
	}

	private void OnClickStaminaShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickGemShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickPoint2xTrial()
	{
		if (Point2xTrialNotiObj != null) Point2xTrialNotiObj.SetActive(false);
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
