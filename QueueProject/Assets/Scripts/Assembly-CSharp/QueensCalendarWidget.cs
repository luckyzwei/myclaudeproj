using UnityEngine.UI;
using UnityEngine;

public class QueensCalendarWidget : CalendarWidget
{
	private enum Buttons
	{
		NONE = 0,
		RV = 1,
		NO_CHALLENGE = 2,
		PLAY = 3
	}

	private const string UNLOCK_MONTH_KEY = "DailyChallengeMonthlyIAP.Button";

	private const string UNLOCK_ALL = "DailyChallengeIAP.Button";

	[SerializeReference]
	private GameObject m_noChallengeThisMonthText;

	[SerializeReference]
	private GameObject m_noChallengeAtAllText;

	[SerializeField]
	private GameObject m_unlockMonthButton;

	[SerializeField]
	private Text m_unlockMonthButtonText;

	private bool m_shouldConsumeFreeDC;

	private bool m_iapEnabled;

	public override void Config(string dailyChallengeID)
	{
	}

	protected override void UpdatePlayButton()
	{
	}

	private void SetActiveAppropirateNoChallengeText()
	{
	}

	public void OnUnlockAllDaysButtonClick()
	{
	}

	public override void OnPlayPressed()
	{
	}

	public override void WatchRv()
	{
	}

	public void OnInfoButtonClick()
	{
	}

	protected override void UpdateCalendarCells()
	{
	}

	public override void UpdateCalendar()
	{
	}
}
