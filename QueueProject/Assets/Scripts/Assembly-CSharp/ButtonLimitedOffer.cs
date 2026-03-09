using Balancy.Models;
using Balancy.Models.Store;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLimitedOffer : MonoBehaviour
{
	private const string NOTIFICATION_ID = "limited_offer_button";

	private static bool s_notificationCleared;

	[Tooltip("Leave empty for using as generic button")]
	[SerializeField]
	private string m_offerClientId;

	[Tooltip("If false, uses the icon already set in the image")]
	[SerializeField]
	private bool m_fetchIconFromServer;

	[Space]
	[SerializeField]
	private RectTransform m_outsidePos;

	[SerializeField]
	private Image m_iconImage;

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private LimitedOfferTimer m_timer;

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private Transform m_landingPoint;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	private LimitedOffer m_offer;

	private Vector3 m_timerDefaultScale;

	public string OfferClientId => null;

	private void Awake()
	{
	}

	private void OnTimeFinished()
	{
	}

	private void OnLimitedOfferPurchased(string clientId)
	{
	}

	private void OnStoreItemPurchased(Product product, bool wasSuccess)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnButtonClicked()
	{
	}

	public void Config(LimitedOffer offer)
	{
	}

	public void ConfigInstantly(LimitedOffer offer)
	{
	}

	public Transform GetIconTransform()
	{
		return null;
	}

	public void IconReceived()
	{
	}

	public void IconStartedMoving()
	{
	}

	private void SubscribeToEvents()
	{
	}

	private void ClearEvents()
	{
	}
}
