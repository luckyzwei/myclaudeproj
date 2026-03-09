using Balancy.Models.SmartObjects.Conditions;
using TMPro;
using UnityEngine;

public class QueensGameEventTimerWidget : MonoBehaviour
{
	private const int DAYS_IN_SECS = 604800;

	[SerializeField]
	private string m_eventClientId;

	[SerializeField]
	private TextMeshProUGUI m_timeText;

	[SerializeField]
	private bool m_weekDayFormat;

	private bool m_weekTextInitialized;

	private string m_cachedWeekText;

	private static readonly string[] k_weekAbbrev;

	private void OnEnable()
	{
	}

	private int GetTimeLeft()
	{
		return 0;
	}

	private string ComputeWeekdayText(int timeLeftInSeconds)
	{
		return null;
	}

	private void UpdateTimeText(int timeLeftInSeconds)
	{
	}

	private void Update()
	{
	}

	private static string FormatDays(DayBased daysOfTheWeek)
	{
		return null;
	}

	private static bool TryExtractDaysMask(DayBased dayBased, out int mask)
	{
		mask = default(int);
		return false;
	}
}
