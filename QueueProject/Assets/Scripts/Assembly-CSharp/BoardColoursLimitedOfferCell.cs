using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;

public class BoardColoursLimitedOfferCell : BoardColoursCell
{
	private bool m_inited;

	private bool m_refreshOnEnable;

	public override void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
	}

	public override void OnButtonPressed()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void UpdateButton(string clientId)
	{
	}

	private void OnEnable()
	{
	}
}
