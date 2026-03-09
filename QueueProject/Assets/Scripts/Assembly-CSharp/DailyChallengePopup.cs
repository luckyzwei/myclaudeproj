using KWCore.UI;
using UnityEngine;

public class DailyChallengePopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWDailyChallenge/PopUp-DailyChallenge";

	[SerializeField]
	private CalendarWidget m_calendarWidget;

	public CalendarWidget CalendarWidget => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Config(string dailyChallengeID)
	{
	}

	public void ClosePopup()
	{
	}
}
