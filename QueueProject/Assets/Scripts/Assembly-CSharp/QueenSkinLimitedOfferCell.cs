using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using UnityEngine;

public class QueenSkinLimitedOfferCell : QueenSkinCell
{
	[SerializeField]
	private PriceWidget m_priceWidget;

	private bool m_inited;

	private bool m_refreshOnEnable;

	public override void Configure(QueenSkinIcons icon, Action<QueenSkinIcons> callback, Action<bool> purchaseCallback = null, Action purchaseFailCallback = null, Product product = null)
	{
	}

	public override void OnButtonPressed()
	{
	}

	private void UpdateButton(string clientId)
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnDestroy()
	{
	}
}
