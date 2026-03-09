using System;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class RoyalTouranmentResultSummaryPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentResultSummary";

	[SerializeField]
	private TextMeshProUGUI m_eliminatedText;

	[SerializeField]
	private TextMeshProUGUI m_positionText;

	[SerializeField]
	private TextMeshProUGUI m_newBestText;

	[SerializeField]
	private TextMeshProUGUI m_bextText;

	[SerializeField]
	private GameObject m_newBestContainer;

	public static RoyalTouranmentResultSummaryPopup Show(Action finished)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Configure()
	{
	}
}
