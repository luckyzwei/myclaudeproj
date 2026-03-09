using KWCore.UI;
using TMPro;
using UnityEngine;

public class RoyalTournamentInfoPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentInfo";

	[SerializeField]
	private TextMeshProUGUI m_text1;

	public static RoyalTournamentInfoPopup Show()
	{
		return null;
	}

	public static void TryToShow()
	{
	}

	private void Awake()
	{
	}
}
