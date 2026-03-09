using System;
using Balancy.Data;
using KWCore.Utils;

public class SubscriptionDiscountManager : MonoSingleton<SubscriptionDiscountManager>
{
	public enum DiscountState
	{
		NONE = 0,
		IN_DISCOUNT = 1,
		IN_COOLDOWN = 2
	}

	private const string CORE_SEGMENT = "Player/Core";

	private bool m_skinPurchased;

	private bool m_skinShowed;

	private DateTime m_lastSkinShow;

	protected override void Init()
	{
	}

	private void Awake()
	{
	}

	private void OnHomeScreenLoaded()
	{
	}

	private void OnSkinPurchased(string text)
	{
	}

	private void OnSkinsPopupClosed()
	{
	}

	public void StartDiscount()
	{
	}

	public void ShowPopup(string source, bool tap = false, Action callback = null)
	{
	}

	private void OnAdStarted()
	{
	}

	private void OnAdFinished()
	{
	}

	public bool WasKilledDuringAd()
	{
		return false;
	}

	public bool HasClickedOnVIP5Times()
	{
		return false;
	}

	public bool HasPurchasedSkin()
	{
		return false;
	}

	private void OnAdFailed()
	{
	}

	private void OnAdShown(string obj)
	{
	}

	public void OpenedVIP()
	{
	}

	public static UserSpecialOfferData GetUserSpecialOfferData()
	{
		return null;
	}

	public static DiscountState GetDiscountState()
	{
		return default(DiscountState);
	}

	public static bool HasItBeenTooLongSinceLastTime()
	{
		return false;
	}

	public static bool IsEnabled()
	{
		return false;
	}
}
