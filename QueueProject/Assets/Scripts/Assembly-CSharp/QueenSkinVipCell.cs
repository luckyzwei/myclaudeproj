using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;

public class QueenSkinVipCell : QueenSkinCell
{
	public override void Configure(QueenSkinIcons icon, Action<QueenSkinIcons> callback, Action<bool> purchaseCallback = null, Action purchaseFailCallback = null, Product product = null)
	{
		base.Configure(icon, callback, purchaseCallback, purchaseFailCallback, product);
		// VIP skins unlocked in offline mode
		m_unlocked = true;
	}

	private void ShowVipPopup()
	{
		// VIP popup not needed in offline mode
	}

	private void UpdateButton()
	{
		SetButtonAnimation();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}
}
