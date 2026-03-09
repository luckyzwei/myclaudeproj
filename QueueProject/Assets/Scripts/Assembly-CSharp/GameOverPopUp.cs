using System;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(KPFGameLossAnalytics))]
public class GameOverPopUp : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-GameOver";

	private const string LIFE = "life";

	[SerializeField]
	private GameObject m_lifeLost;

	[SerializeField]
	private GameObject m_crownsToPlace;

	[SerializeField]
	private GameObject m_gemsRevealed;

	[SerializeField]
	private GameObject m_levelFailed;

	[SerializeField]
	private TextMeshProUGUI m_crownsAmount;

	[Space]
	[SerializeField]
	private TextMeshProUGUI m_reviveHeartsText;

	[SerializeField]
	private TextMeshProUGUI m_reviveText;

	[SerializeField]
	private string m_reviveTextFormatKey;

	[SerializeField]
	private bool m_only1Step;

	[SerializeField]
	private LifeCounterWidget m_lifeCounterWidget;

	[Header("Play On With Coins")]
	[SerializeField]
	private SimpleCoinPurchaseButton m_buttonCoin;

	[Header("Play On With RV")]
	[SerializeField]
	private GameObject m_buttonAd;

	[Header("Play On Free")]
	[SerializeField]
	private GameObject m_buttonFree;

	[Header("Offers")]
	[SerializeField]
	private BundleBuilder m_bundleBuilder;

	private static int s_lastLevelFailed;

	private KPFGameLossAnalytics m_gameLossAnalytics;

	private string m_context;

	private int m_screenIndex;

	private PopupInputBlocker m_popupInputBlocker;

	private ReviveLogic m_currentLogic;

	public event Action GaveUpEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void BalancyMarket_OnProductPurchased(StoreItem product, BalancyMarketEvents.PurchaseType type, string analyticInfo)
	{
	}

	private string GetAnalyticsStringForLogic(ReviveLogic currentLogic)
	{
		return null;
	}

	private bool HasFreeRevives()
	{
		return false;
	}

	private void SpendFreeRevive()
	{
	}

	private void ActivateButton(ReviveLogic logic)
	{
	}

	public void ConfigGameOverPopup(string context)
	{
	}

	private void ConfigHeartsTexts()
	{
	}

	private void TryShowBundles()
	{
	}

	private void SetupSoftReviveButton()
	{
	}

	private void OnSoftRevivePurchased(bool success)
	{
	}

	public void Revive(bool useRV)
	{
	}

	private void OnReviveSuccess()
	{
	}

	public void GiveUp()
	{
	}

	private void GaveUp()
	{
	}

	private void TryShowLifeLostPopUp()
	{
	}

	private void SendLossEvent()
	{
	}

	private void OnHomeScreenPressed()
	{
	}

	private void OnApplicationQuit()
	{
	}

	protected override void OnDestroy()
	{
	}
}
