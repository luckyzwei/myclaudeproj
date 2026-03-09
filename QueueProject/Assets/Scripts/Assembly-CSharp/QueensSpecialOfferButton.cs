using Balancy.Models;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class QueensSpecialOfferButton : MonoBehaviour
{
	[SerializeField]
	private string m_source;

	[SerializeField]
	private Image m_icon;

	private Product m_product;

	private KwaleeOffer m_kwaleeOffer;

	private SpecialOfferContainerData m_specialOfferContainerData;

	public void Config(KwaleeOffer kwaleeOffer, SpecialOfferContainerData specialOfferContainerData)
	{
	}

	public void Disable()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnProductPurchased()
	{
	}

	private void Start()
	{
	}

	public void OnButtonPressed()
	{
	}
}
