using Balancy.Models.Store;
using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class PopupDailyChallengeIAP : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWDailyChallenge/Popup-DailyChallenge-IAP";

	public const string PREFAB_NAME_RESULT = "Prefabs/KWDailyChallenge/Popup-DailyChallenge-IAPResults";

	private const string UNLOCK_MONTH_KEY = "DailyChallengeMonthlyIAP.Button";

	private const string UNLOCK_ALL = "DailyChallengeIAP.Button";

	private const string UNLOCK_ALL_DAYS_CLIENT_ID = "dc_no_ads";

	private const string UNLOCK_MONTH_ANALYTICS_FORMAT = "dc_{0}";

	[SerializeField]
	private bool m_isResultScreenPopup;

	[SerializeField]
	private StorePurchaseButton m_unlockAllLevelsButton;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[SerializeField]
	private DateButtonLabel m_dateLabel;

	[SerializeField]
	private Text m_headerTMP;

	[SerializeField]
	private Text m_buttonTMP;

	private Product m_product;

	private void Awake()
	{
	}

	public void Config(DCDate dcDate)
	{
	}

	public bool HasUnlockedAllDays()
	{
		return false;
	}

	private void OnUnlockAllDaysPurchase(bool success)
	{
	}

	public void OnWatchRvButtonClick()
	{
	}

	private void ConfigStoreButton(DCDate dcDate)
	{
	}
}
