using System;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using KWGameSettings;
using KWLocalisation.Localisation;
using UnityEngine;

[SortingLayer("SpecialOffer")]
public class SubscriptionFullScreenPopUp : PopUpBase
{
	private const string REWARD_POPUP = "Prefabs/KWReward/Popup-StoreReward";

	[SerializeField]
	protected TextWrapper m_priceStringWeekly;

	[SerializeField]
	protected TextWrapper m_priceStringMonthly;

	[SerializeField]
	protected TextWrapper m_smallPrint;

	[SerializeField]
	protected TextWrapper m_termsAndPrivacyLink;

	[SerializeField]
	protected TextWrapper m_tryForFreeForXDays;

	protected Subscription m_settings;

	protected StoreItem m_referencedProduct;

	protected Action<bool> m_productPurchasedCallback;

	protected bool m_isClosed;

	private void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public virtual void OnSubscribeWeeklyPressed()
	{
	}

	public virtual void OnSubscribeMonthlyPressed()
	{
	}

	public void OnPrivacyAndTermsPressed()
	{
	}

	protected virtual void OnPurchasedSubscription(bool didPurchase)
	{
	}

	private void OnRewardsGiven()
	{
	}
}
