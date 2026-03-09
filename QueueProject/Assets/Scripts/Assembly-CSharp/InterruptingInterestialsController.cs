using Balancy.Models.Gameplay;
using TMPro;
using UnityEngine;

public class InterruptingInterestialsController : MonoBehaviour
{
	private const string AD_BREAK_POPUP_PREFAB = "Prefabs/PopUp-NoAdsOffer";

	private const string NO_AD_FOREVER_PRODUCT_ID = "no_ads";

	private const string NO_AD_24H_PRODUCT_ID = "no_ads_24";

	private static float s_timeElapsed;

	private static int s_timesShown;

	[SerializeField]
	private GameObject m_popupOutstanding;

	[SerializeField]
	private TMP_Text m_rewardText;

	[SerializeField]
	private float m_delay;

	private InterruptingInterestials m_settings;

	private float m_lastTime;

	private bool m_triedShowInt;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnQueenFound(int queenNumber, bool isLastOne, bool isBoosterUsed)
	{
	}

	private void ShowAd()
	{
	}

	private void OnAdDone()
	{
	}

	private void OnAdFailed()
	{
	}

	private void OnAdShown(string placement)
	{
	}

	[ContextMenu("Show No Ads Offer")]
	private void ShowNoAdsOfferPopup()
	{
	}
}
