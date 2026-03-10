using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using UnityEngine;

public class QueenSkinLimitedOfferCell : QueenSkinCell
{
	[SerializeField]
	private PriceWidget m_limitedOfferPriceWidget;

	private bool m_inited;

	private bool m_refreshOnEnable;

	public override void Configure(QueenSkinIcons icon, Action<QueenSkinIcons> callback, Action<bool> purchaseCallback = null, Action purchaseFailCallback = null, Product product = null)
	{
		base.Configure(icon, callback, purchaseCallback, purchaseFailCallback, product);
		m_inited = true;
		m_unlocked = true; // All unlocked in offline mode
		if (m_limitedOfferPriceWidget != null)
			m_limitedOfferPriceWidget.gameObject.SetActive(false);
	}

	public override void OnButtonPressed()
	{
		base.OnButtonPressed();
	}

	private void UpdateButton(string clientId)
	{
		SetButtonAnimation();
	}

	private void OnEnable()
	{
		if (m_refreshOnEnable && m_inited)
			SetButtonAnimation();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}
}
