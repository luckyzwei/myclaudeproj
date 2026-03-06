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
		base.Awake();
		if (PurchaseButton != null) PurchaseButton.onClick.AddListener(OnClickPurchaseBtn);
		if (BoostShortcutButton != null) BoostShortcutButton.onClick.AddListener(OnClickBoostShortcut);
	}

	public void Set(int currencyID, int region, BigInteger requiredAmount, params object[] a_params)
	{
		RewardType = currencyID;
		RewardId = 0;
		RegionIdx = region;
		RequiredAmount = requiredAmount;
		LogUseGemParams = a_params;
		InsufficientAmount = BigInteger.Zero;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateInsufficientAmount(requiredAmount);
		SetOfferwall();

		if (hudTop != null) hudTop.gameObject.SetActive(true);
		if (ShopContentsMoney != null) ShopContentsMoney.gameObject.SetActive(false);

		Show();
	}

	public void Set(int rewardType, int rewardID, int region, BigInteger insufficientAmount, params object[] a_params)
	{
		RewardType = rewardType;
		RewardId = rewardID;
		RegionIdx = region;
		InsufficientAmount = insufficientAmount;
		LogUseGemParams = a_params;
		RequiredAmount = BigInteger.Zero;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateInsufficientAmount(insufficientAmount);
		SetOfferwall();

		if (hudTop != null) hudTop.gameObject.SetActive(true);
		if (ShopContentsMoney != null) ShopContentsMoney.gameObject.SetActive(true);

		Show();
	}

	private void SetOfferwall()
	{
		OnOfferwallReddot = false;
		if (BoostShortcutButton != null) BoostShortcutButton.gameObject.SetActive(OnOfferwallReddot);
	}

	private void OnClickBoostShortcut()
	{
		Hide();
	}

	private void UpdateInsufficientAmount(BigInteger hasValue)
	{
		if (CurrencyPurchaseNeedCashValueText != null)
			CurrencyPurchaseNeedCashValueText.text = ProjectUtility.GetThousandCommaText(hasValue);
	}

	private void OnClickPurchaseBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		OnPurchaseComplete();
	}

	private void OnPurchaseComplete()
	{
		OnPurchaseCompleteAction?.Invoke(true);
		Hide();
	}

	public override void OnHideBefore()
	{
		OnPurchaseCompleteAction = null;
	}
}
