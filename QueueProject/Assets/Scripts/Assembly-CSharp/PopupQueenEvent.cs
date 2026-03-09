using System;
using KWCore.UI;

public class PopupQueenEvent : PopUpBase
{
	private const bool SHOW_WELCOME_BACK = false;

	private const string PREFAB_NAME_PLAEYED_BEFORE = "Prefabs/Popups/PopUp-QueenEventPrePlay-PlayedBefore";

	private const string PREFAB_NAME_NEVER_PLAYED = "Prefabs/Popups/PopUp-QueenEventPrePlay-NeverPlayed";

	public static PopupQueenEvent Show(Action closeCallback = null)
	{
		return null;
	}

	public void OnInfoButtonClick()
	{
	}

	public void Config()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void Update()
	{
	}

	public void OnStartButtonPressed()
	{
	}
}
