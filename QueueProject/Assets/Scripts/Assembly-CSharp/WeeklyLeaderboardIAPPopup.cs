using System;
using KWCore.UI;
using UnityEngine;

public class WeeklyLeaderboardIAPPopup : PopUpBase
{
	private const string POPUP_NAME = "Prefabs/KWLeaderboard/Popup-WeeklyLeaderboard-IAPOffer";

	private const string REWARD_POPUP = "Prefabs/KWReward/Popup-StoreReward";

	private const string BUY_ALL_PRODUCT_ID = "queensmaster_leaderboard_bundle_all";

	private const string A_PRODUCT_ID = "queensmaster_leaderboard_bundle_01";

	private const string B_PRODUCT_ID = "queensmaster_leaderboard_bundle_02";

	private const string C_PRODUCT_ID = "queensmaster_leaderboard_bundle_03";

	[SerializeField]
	private PriceWidget m_iapPriceA;

	[SerializeField]
	private PriceWidget m_iapPriceB;

	[SerializeField]
	private PriceWidget m_iapPriceC;

	[SerializeField]
	private PriceWidget m_buyAllPrice;

	[SerializeField]
	private StorePurchaseButton m_iapButtonA;

	[SerializeField]
	private StorePurchaseButton m_iapButtonB;

	[SerializeField]
	private StorePurchaseButton m_iapButtonC;

	[SerializeField]
	private StorePurchaseButton m_buyallButton;

	[Header("Cells (A, B, C Only)")]
	[SerializeField]
	private RewardWidget m_rewardWidgetA;

	[SerializeField]
	private RewardWidget m_rewardWidgetB;

	[SerializeField]
	private RewardWidget m_rewardWidgetC;

	public static void Show(Action onClose = null)
	{
	}

	public void Configure()
	{
	}

	private void SetupProduct(string productId, PriceWidget priceWidget, StorePurchaseButton purchaseButton, RewardWidget rewardW = null)
	{
	}
}
