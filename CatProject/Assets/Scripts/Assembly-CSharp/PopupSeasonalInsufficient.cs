using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalInsufficient", false, false)]
public class PopupSeasonalInsufficient : UIBase
{
	[SerializeField]
	private HUDTopInfo TopInfo;

	[SerializeField]
	private ItemArticle ItemArticle;

	[SerializeField]
	private Button GotoMachineBtn;

	[SerializeField]
	private Button GotoShopBtn;

	[SerializeField]
	private Button GemPurchaseBtn;

	[SerializeField]
	private Text GemPurchaseAmountText;

	[Header("PackageBanner")]
	[SerializeField]
	private ItemSeasonalPackageBanner PackageBanner;

	private E_CurrencyType CurCurrencyType;

	private int WorkshopIdx;

	private BigInteger NeedCount_PerMile;

	private BigInteger GemPurchaseAmount;

	private ShopSystem.InAppPurchaseLocation beforeLocation;

	private WeakReference<UIBase> Owner;

	private Action<bool> CustomResultCallBack;

	protected override void Awake()
	{
		base.Awake();
		if (GotoMachineBtn != null) GotoMachineBtn.onClick.AddListener(OnClickGotoMachine);
		if (GotoShopBtn != null) GotoShopBtn.onClick.AddListener(OnClickGotoShop);
		if (GemPurchaseBtn != null) GemPurchaseBtn.onClick.AddListener(OnClickGemPurchase);
	}

	public override void OnShowBefore()
	{
		if (TopInfo != null) TopInfo.gameObject.SetActive(true);
		SetPackageBanner();
	}

	public override void OnHideAfter()
	{
		Owner = null;
		CustomResultCallBack = null;
	}

	public void Set(UIBase owner, E_CurrencyType type, BigInteger needCount_PerMile, int workshopIdx, Action<bool> customResultCallBack)
	{
		Owner = new WeakReference<UIBase>(owner);
		CurCurrencyType = type;
		NeedCount_PerMile = needCount_PerMile;
		WorkshopIdx = workshopIdx;
		CustomResultCallBack = customResultCallBack;
		GemPurchaseAmount = BigInteger.Zero;

		if (GemPurchaseAmountText != null)
			GemPurchaseAmountText.text = ProjectUtility.GetThousandCommaText(GemPurchaseAmount);

		Show();
	}

	private void SetPackageBanner()
	{
		if (PackageBanner != null) PackageBanner.gameObject.SetActive(false);
	}

	private void OnClickGotoMachine()
	{
		CustomResultCallBack?.Invoke(false);
		Hide();
	}

	private void OnClickGotoShop()
	{
		CustomResultCallBack?.Invoke(false);
		Hide();
	}

	private void OnClickGemPurchase()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		CustomResultCallBack?.Invoke(true);
		Hide();
	}
}
