using KWLocalisation.Localisation;
using UnityEngine;

public class DailyRewardTimer : MonoBehaviour
{
	[SerializeField]
	private TextWrapper m_timerText;

	[Space]
	[Header("Time Format")]
	[SerializeField]
	private string m_hourFormat;

	[SerializeField]
	private string m_minuteFormat;

	[SerializeField]
	private string m_secondFormat;

	[SerializeField]
	private string m_timerPrefix;

	private const float UPDATE_EVERY_X_SECS = 1f;

	private float m_timer;

	private void Start()
	{
	}

	private string GetTimeAsString()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateTimerText()
	{
	}

	protected virtual string GetFormattedTime(int totalSeconds)
	{
		return null;
	}
}
