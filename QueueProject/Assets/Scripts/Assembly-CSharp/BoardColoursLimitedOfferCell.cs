using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;

public class BoardColoursLimitedOfferCell : BoardColoursCell
{
	private bool m_inited;

	private bool m_refreshOnEnable;

	public override void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
		base.Configure(icon, callback, product);
		m_inited = true;
		m_unlocked = true; // All unlocked in offline mode
	}

	public override void OnButtonPressed()
	{
		base.OnButtonPressed();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	private void UpdateButton(string clientId)
	{
		SetButtonAnimations();
	}

	private void OnEnable()
	{
		if (m_refreshOnEnable && m_inited)
			SetButtonAnimations();
	}
}
