using System.Collections.Generic;
using Balancy.Models;
using UnityEngine;

public class SpecialOfferController : MonoBehaviour
{
	private KwaleeOffer m_activeKwaleeOffer;

	[SerializeField]
	private Transform m_receiverTransform;

	[SerializeField]
	private Transform m_parentReceiver;

	[SerializeField]
	private SpecialOfferContainerData m_specialOfferContainerData;

	[SerializeField]
	private string m_source;

	[SerializeField]
	private QueensSpecialOfferButton m_specialOfferButton;

	private bool m_showSpecialOffer;

	public static List<SpecialOfferData> GetSpecialOffers => null;

	public static KwaleeOffer[] GetActiveSpecialOffers => null;

	private bool PickSpecialOffer()
	{
		return false;
	}

	public void ShowCurrentSpecialOffer()
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	private void SetSpecialOfferButton()
	{
	}
}
