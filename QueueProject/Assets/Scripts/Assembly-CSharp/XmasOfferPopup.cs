using System;
using Balancy.Models;
using UnityEngine;

public class XmasOfferPopup : LimitedOfferPopup
{
	[SerializeField]
	private bool m_useRewardsAsFlyingIcon;

	public override void Config(KwaleeOffer kwaleeOffer, Action callback = null, bool userRequested = false, string source = "")
	{
	}

	private void SetIcon()
	{
	}

	public override void MoveIconAndClose()
	{
	}
}
