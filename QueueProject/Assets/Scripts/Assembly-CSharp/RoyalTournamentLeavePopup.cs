using System;
using KWCore.UI;
using UnityEngine;

public class RoyalTournamentLeavePopup : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentLeave";

	[SerializeField]
	private float m_closeDelay;

	public static void Show(Action closedCallback = null)
	{
	}

	public void OnExitPressed()
	{
	}

	public void OnContinuePressed()
	{
	}
}
