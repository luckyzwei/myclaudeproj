using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CalendarWidget : MonoBehaviour
{
	protected const int MAX_CALENDAR_CELLS = 42;

	private const string DC_REPLAY = "dc_prev_day";

	protected static readonly string[] s_monthsFull;

	protected static readonly string[] s_monthsShort;

	[SerializeField]
	protected Button m_previousMonthButton;

	[SerializeField]
	protected Button m_nextMonthButton;

	[SerializeField]
	protected TextMeshProUGUI m_currentMonthText;

	[SerializeField]
	protected TextMeshProUGUI m_currentYearText;

	[SerializeField]
	protected GameObject m_playButton;

	[SerializeField]
	protected GameObject m_rvPlayButton;

	[SerializeField]
	protected GameObject m_noChallengeGO;

	[SerializeField]
	protected DateButtonLabel[] m_dateButtonLabels;

	[SerializeField]
	protected CalendarCell m_calendarCellPrefab;

	[SerializeField]
	protected Transform m_calendarCellsParent;

	[SerializeField]
	protected RectTransform m_panelRectTransform;

	protected CalendarCell[] m_calendarCells;

	protected string m_dailyChallengeID;

	public virtual void Config(string dailyChallengeID)
	{
	}

	private void SpawnCalendarCells()
	{
	}

	protected virtual void UpdateCalendarCells()
	{
	}

	protected virtual void UpdatePlayButton()
	{
	}

	public virtual void UpdateCalendar()
	{
	}

	private void NextMonth()
	{
	}

	private void PreviousMonth()
	{
	}

	protected void OnCellSelected(DCDate dcDate)
	{
	}

	public virtual void OnPlayPressed()
	{
	}

	public virtual void WatchRv()
	{
	}

	public CalendarCell GetCalendarCell(int day = 0)
	{
		return null;
	}

	public static string GetDateShortString(DCDate date)
	{
		return null;
	}

	public static string GetDateLongString(DCDate date)
	{
		return null;
	}

	public static string GetMonthName(int index, bool shortVersion = false)
	{
		return null;
	}
}
