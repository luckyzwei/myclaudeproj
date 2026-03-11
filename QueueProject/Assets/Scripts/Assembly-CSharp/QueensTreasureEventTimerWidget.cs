using UnityEngine.UI;
using UnityEngine;

public class QueensTreasureEventTimerWidget : MonoBehaviour
{
	private enum TimerType
	{
		ENDS_IN = 0,
		STARTS_IN = 1
	}

	private const int DAYS_IN_SECS = 604800;

	[SerializeField]
	private TimerType m_timerType;

	[Space(10f)]
	[SerializeField]
	private Text m_timeText;

	private int TimeLeft()
	{
		return 0;
	}

	private int TimeToStart()
	{
		return 0;
	}

	private void UpdateTimeText(int timeSeconds)
	{
	}

	private void Update()
	{
	}
}
