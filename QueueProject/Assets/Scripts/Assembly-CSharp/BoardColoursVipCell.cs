using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;

public class BoardColoursVipCell : BoardColoursCell
{
	public override void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
		base.Configure(icon, callback, product);
		m_unlocked = true; // All unlocked in offline mode
	}

	protected override bool IsUnlocked()
	{
		return true; // All unlocked in offline mode
	}

	private void ShowVipPopup()
	{
		// VIP popup not needed in offline mode
	}

	private void UpdateButton()
	{
		SetButtonAnimations();
	}
}
