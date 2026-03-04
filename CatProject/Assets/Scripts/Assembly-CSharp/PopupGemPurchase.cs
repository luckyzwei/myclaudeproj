using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupGemPurchase", false, false)]
public class PopupGemPurchase : UIBase
{
	[SerializeField]
	private ItemArticle NeedItem;

	[SerializeField]
	private Text CurrencyPurchaseNeedCashValueText;

	[SerializeField]
	private Button PurchaseButton;

	[SerializeField]
	private HudTopComponent hudTop;

	[SerializeField]
	private ShopContentsMoneyTimeWarp ShopContentsMoney;

	[SerializeField]
	private Button BoostShortcutButton;

	public Action<bool> OnPurchaseCompleteAction;

	private BigInteger InsufficientAmount;

	private int RequiredCash;

	private int RewardId;

	private int RewardType;

	private int RegionIdx;

	private BigInteger RequiredAmount;

	private object[] LogUseGemParams;

	private bool OnOfferwallReddot;

	protected override void Awake()
	{
	}

	public void Set(int currencyID, int region, BigInteger requiredAmount, params object[] a_params)
	{
	}

	public void Set(int rewardType, int rewardID, int region, BigInteger insufficientAmount, params object[] a_params)
	{
	}

	private void SetOfferwall()
	{
	}

	private void OnClickBoostShortcut()
	{
	}

	private void UpdateInsufficientAmount(BigInteger hasValue)
	{
	}

	private void OnClickPurchaseBtn()
	{
	}

	private void OnPurchaseComplete()
	{
	}

	public override void OnHideBefore()
	{
	}
}
