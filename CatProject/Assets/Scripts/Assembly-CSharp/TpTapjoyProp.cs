using TapjoyUnity;
using UnityEngine;
using UnityEngine.Events;

public class TpTapjoyProp : MonoBehaviour
{
	public enum OfferwallPlaceType
	{
		none = -1,
		shop = 0,
		hud = 1,
		popup_lack = 2
	}

	public TJPlacement offerwallPlacement;

	public string output;

	public bool shouldPreload;

	public bool contentIsReadyForPlacement;

	public bool isConnected;

	private string sdkKey;

	private string offerwallPlacementName;

	private string offerwallSegmentPlacementName;

	private UnityAction _offerwallCB;

	private int _reuseCount;

	private int ReuseCount => 0;

	public void Awake()
	{
	}

	public void InitConnect()
	{
	}

	public void InitOfferwall()
	{
	}

	private string GetPlacementName()
	{
		return null;
	}

	public void ShowOfferwall(OfferwallPlaceType placeType, UnityAction cb = null)
	{
	}

	public void UpdateReward()
	{
	}

	private void OnDisable()
	{
	}

	public void HandleConnectSuccess()
	{
	}

	public void HandleConnectFailure(int code, string msg)
	{
	}

	public void HandleConnectWarning(int code, string msg)
	{
	}

	public void HandlePlacementRequestSuccess(TJPlacement placement)
	{
	}

	public void HandlePlacementRequestFailure(TJPlacement placement, string error)
	{
	}

	public void HandlePlacementContentReady(TJPlacement placement)
	{
	}

	public void HandlePlacementContentShow(TJPlacement placement)
	{
	}

	public void HandlePlacementContentDismiss(TJPlacement placement)
	{
	}

	public void HandlePlacementOnClick(TJPlacement placement)
	{
	}

	private void HandleOnPurchaseRequest(TJPlacement placement, TJActionRequest request, string productId)
	{
	}

	private void HandleOnRewardRequest(TJPlacement placement, TJActionRequest request, string itemId, int quantity)
	{
	}

	public void HandleAwardCurrencyResponse(string currencyName, int balance)
	{
	}

	public void HandleAwardCurrencyResponseFailure(string error)
	{
	}

	public void HandleGetCurrencyBalanceResponse(string currencyName, int balance)
	{
	}

	public void HandleGetCurrencyBalanceResponseFailure(string error)
	{
	}

	public void HandleSpendCurrencyResponse(string currencyName, int balance)
	{
	}

	public void HandleSpendCurrencyResponseFailure(string error)
	{
	}

	public void HandleEarnedCurrency(string currencyName, int amount)
	{
	}
}
