using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[UIPath("UI/Page/PagePlayerLvPass", false, false)]
public class PagePlayerLvPass : UIBase
{
	[Header("[PagePlayerLvPass]")]
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private GameObject DecoObj;

	[Space(10f)]
	[SerializeField]
	private GameObject BtnAreaObj;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text SaleText;

	[Space(5f)]
	[SerializeField]
	private GameObject CurRewardGemFrame;

	[SerializeField]
	private Text TotalRewardGemText;

	[SerializeField]
	private Text CurRewardGemText;

	[Header("DoubleSale")]
	[SerializeField]
	private GameObject DoubleSaleAreaObj;

	[SerializeField]
	private Button DoubleSalePurchaseBtn;

	[Space(5f)]
	[SerializeField]
	private Text DoubleSaleText1;

	[SerializeField]
	private Text DoubleSaleText2;

	[SerializeField]
	private Text DoubleSalePrice;

	[SerializeField]
	private Text DoubleSalePrice1;

	[SerializeField]
	private Text DoubleSalePrice2;

	[SerializeField]
	private Text DoubleSaleRemainTime;

	[Space(10f)]
	[SerializeField]
	private GameObject ClaimAllBtnObj;

	[SerializeField]
	private Button ClaimAllBtn;

	[SerializeField]
	private Animator PurchaseAnim;

	private bool inPurchase;

	private CompositeDisposable disposables;

	[Header("Onetime")]
	[SerializeField]
	private GameObject oneTimeUIRoot;

	[SerializeField]
	private Image oneTimeCurrencyIcon;

	[SerializeField]
	private Text oneTimeCurrencyCount;

	private int GroupIdx;

	private bool IsNoAds;

	public Image OneTimeCurrencyIcon { get { return oneTimeCurrencyIcon; } }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (PurchaseBtn != null) PurchaseBtn.onClick.AddListener(OnClickPurchase);
		if (ClaimAllBtn != null) ClaimAllBtn.onClick.AddListener(OnClickClaimAllBtn);
		if (DoubleSalePurchaseBtn != null) DoubleSalePurchaseBtn.onClick.AddListener(OnClickPurchase);
	}

	public void Init(int groupIdx, UnityAction endCb = null)
	{
		GroupIdx = groupIdx;
		IsNoAds = false;
		inPurchase = false;

		RefreshPage();
		endCb?.Invoke();
	}

	public override void OnShowBefore()
	{
		RefreshPage();
	}

	public override void OnRefresh()
	{
		RefreshPage();
	}

	private void RefreshPage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		CheckAndUpdatePass();
		SetClaimAllButtonState();
		SetTotalRewardGem();
		SetOneTime();
	}

	private void CheckAndUpdatePass()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		// Check if pass is purchased
		bool isPurchased = false;
		if (BtnAreaObj != null) BtnAreaObj.SetActive(!isPurchased);
		if (DoubleSaleAreaObj != null) DoubleSaleAreaObj.SetActive(false);
		if (DecoObj != null) DecoObj.SetActive(isPurchased);

		SetCurRewardGem(isPurchased);
	}

	private void SetClaimAllButtonState()
	{
		// Show claim all button if there are unclaimed rewards
		bool hasClaimable = false;
		if (ClaimAllBtnObj != null) ClaimAllBtnObj.SetActive(hasClaimable);
	}

	private void OnClickPurchase()
	{
		if (inPurchase) return;
		inPurchase = true;
		// IAP purchase for player level pass
	}

	private void OnClickClaimAllBtn()
	{
		// Claim all available rewards
		RefreshPage();
	}

	private void SetTotalRewardGem()
	{
		if (TotalRewardGemText != null) TotalRewardGemText.text = "0";
	}

	private void SetCurRewardGem(bool isPass)
	{
		if (CurRewardGemFrame != null) CurRewardGemFrame.SetActive(isPass);
		if (CurRewardGemText != null) CurRewardGemText.text = "0";
	}

	private void SetOneTime()
	{
		if (oneTimeUIRoot != null) oneTimeUIRoot.SetActive(false);
		UpdateOneTimeCurrencyIcon();
		UpdateOneTimeCurrencyCount();
	}

	private void UpdateOneTimeCurrencyIcon()
	{
		// Set one-time currency icon from event data
	}

	public void UpdateOneTimeCurrencyCount()
	{
		// Update one-time currency count text
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
