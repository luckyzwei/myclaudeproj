using System;
using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class RoyalTouranmentResultSummaryPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentResultSummary";

	[SerializeField]
	private Text m_eliminatedText;

	[SerializeField]
	private Text m_positionText;

	[SerializeField]
	private Text m_newBestText;

	[SerializeField]
	private Text m_bextText;

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
