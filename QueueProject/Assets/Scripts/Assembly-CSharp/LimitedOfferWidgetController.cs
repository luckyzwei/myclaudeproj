using Balancy.Models;
using KWCore.UI;
using UnityEngine;

public class LimitedOfferWidgetController : MonoBehaviour
{
	private ButtonLimitedOffer[] m_buttons;

	private LimitedOffer m_currentActiveOffer;

	private void Awake()
	{
	}

	private void CoreEventsOnPopupClosed(PopUpBase obj)
	{
	}

	private void OnDestroy()
	{
	}

	private void CheckForExistingOffer()
	{
	}

	private bool IsOfferActive(string offerClientId)
	{
		return false;
	}

	public ButtonLimitedOffer GetButtonForOffer(string offerClientId)
	{
		return null;
	}
}
