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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void Set(UIBase owner, E_CurrencyType type, BigInteger needCount_PerMile, int workshopIdx, Action<bool> customResultCallBack)
	{
	}

	private void SetPackageBanner()
	{
	}

	private void OnClickGotoMachine()
	{
	}

	private void OnClickGotoShop()
	{
	}

	private void OnClickGemPurchase()
	{
	}
}
