using UnityEngine;

[SortingLayer("PopUpInfo")]
public class TryCloseBannerPopUp : MonoBehaviour
{
	private const string POPUP_TYPE = "no_ads";

	private readonly Vector2 BANNER_X_LEFT_POSITION;

	[SerializeField]
	private RectTransform m_closeButtonRootRect;

	private bool m_isNoAdsPopupShowing;

	private void Awake()
	{
	}

	private void HandleNoAdsPopupClosed()
	{
	}

	private void HandleNoAdsPopUpOpened()
	{
	}

	public void OnTryCloseBanner()
	{
	}

	private void OnEnable()
	{
	}

	private void SetBannerXPosition()
	{
	}

	private void BuyNoAdsFromBannerCloseButton()
	{
	}

	private void OnPurchaseSuccess()
	{
	}

	private void OnPurchaseFailure()
	{
	}

	private void SendNoAdsClickedAnalyticsEvent()
	{
	}

	private void SetBannerXButtonEnabled(bool enabled)
	{
	}

	private void OnDestroy()
	{
	}
}
