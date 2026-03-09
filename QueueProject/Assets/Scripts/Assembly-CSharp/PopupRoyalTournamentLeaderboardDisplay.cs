using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupRoyalTournamentLeaderboardDisplay : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentLeaderboardDisplay";

	[SerializeField]
	private Button m_continueButton;

	[SerializeField]
	private QueensLiveLeaderboardWidget m_leaderboardWidget;

	private bool m_isClosing;

	private void GiveCrowns()
	{
	}

	private void Awake()
	{
	}

	protected override void FinishedIntroAnimation()
	{
	}

	public void OnContinuePressed()
	{
	}

	protected override void OnDestroy()
	{
	}
}
