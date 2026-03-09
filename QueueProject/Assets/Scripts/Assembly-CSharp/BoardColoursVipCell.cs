using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;

public class BoardColoursVipCell : BoardColoursCell
{
	public override void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
	}

	protected override bool IsUnlocked()
	{
		return false;
	}

	private void ShowVipPopup()
	{
	}

	private void UpdateButton()
	{
	}
}
