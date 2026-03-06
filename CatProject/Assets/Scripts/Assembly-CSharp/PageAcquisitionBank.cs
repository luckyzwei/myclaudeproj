using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionBank", false, false)]
public class PageAcquisitionBank : UIBase, IHUDTopInfo
{
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private GameObject JewelryBoxRoot;

	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private SliderTextComponent SliderComp;

	[SerializeField]
	private Text CurCountText;

	[SerializeField]
	private Text MaxCountText;

	[Header("Purchase")]
	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text SaleText;

	[Header("LevelInfo")]
	[SerializeField]
	private Text CurLevelText;

	[SerializeField]
	private GameObject NextLevelRoot;

	[SerializeField]
	private Text CurMaxFullCountText;

	[SerializeField]
	private Text NextMaxFullCountText;

	[SerializeField]
	private Button LevelInfoBtn;

	private BigInteger CurMaxCount;

	private bool IsEnablePurchase;

	private int ShopSpecialIdx;

	private GameObject LoadedJewelryBoxObj;

	private int LoadedStageStep;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (LevelInfoBtn != null) LevelInfoBtn.onClick.AddListener(OnClickLevelInfo);
		if (PurchaseBtn != null) PurchaseBtn.onClick.AddListener(OnClickPurchase);
	}

	public override void OnShowBefore()
	{
		Init();
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return HUDTopInfo;
	}

	private void Init()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		IsEnablePurchase = false;
		CheckAndOpenStepUpPage();
	}

	private void LoadJewelryBoxPrefab(int stageStep, bool isFull)
	{
		if (JewelryBoxRoot == null) return;
		LoadedStageStep = stageStep;
	}

	private void PlayJewelryBoxAnimation(bool isFull)
	{
		if (LoadedJewelryBoxObj == null) return;
		var animator = LoadedJewelryBoxObj.GetComponent<Animator>();
		if (animator != null)
			animator.SetBool("IsFull", isFull);
	}

	private void CheckAndOpenStepUpPage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void SetPurchaseInfo(int shopSpecialIdx)
	{
		ShopSpecialIdx = shopSpecialIdx;
		if (PriceText != null) PriceText.text = "0";
		if (SaleObj != null) SaleObj.SetActive(false);
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickLevelInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickPurchase()
	{
		if (!IsEnablePurchase) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
