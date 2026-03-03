using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeComponent : MonoBehaviour
{
	public enum E_TimeFormat
	{
		None = 0,
		TimeFormat_Long = 1,
		TimeFormat_Short = 2,
		TwoDigitLong = 3,
		TwoDigitShort = 4,
		MinuteSecondColons = 5
	}

	private enum E_TimerType
	{
		None = 0,
		RemainTime = 1,
		ElapsedTime = 2
	}

	[SerializeField]
	private Text TimeText;

	[SerializeField]
	private Slider TimeSlider;

	private E_TimerType TimerType;

	private DateTime EndTime;

	private DateTime StartTime;

	private int LimitTimeSec;

	private bool bStartTimer;

	private string LocalFormatKey;

	private string Prefix;

	private string Suffix;

	private E_TimeFormat TimeFormat;

	private Action OnTimeEnd;

	public Action<int> OnUpdateTimeSec;

	public int TimerTimeSec { get; private set; }

	public void SetRemainTimer(DateTime endTime, int totalTimeSec, string localFormatKey, E_TimeFormat timeFormat, Action onTimeEnd)
	{
	}

	public void SetRemainTimer(DateTime endTime, int totalTimeSec, string prefix, string suffix, E_TimeFormat timeFormat, Action onTimeEnd)
	{
	}

	public void SetRemainTimer(DateTime endTime, int totalTimeSec, E_TimeFormat timeFormat, Action onTimeEnd)
	{
	}

	public void SetElapsedTimer(DateTime startTime, int limitTimeSec, string localFormatKey, E_TimeFormat timeFormat, Action onTimeEnd)
	{
	}

	public void SetProgressValue(int value)
	{
	}

	public void SetLocalizeText(string key)
	{
	}

	public void SetText(string textStr)
	{
	}

	private void Update()
	{
	}

	private void UpdateRemainTime()
	{
	}

	private void UpdateElapsedTime()
	{
	}

	private void SetTimeText(int remainTimeSec)
	{
	}

	private void SetTimeSlider(int elapsedTimeSec, int totalTimeSec)
	{
	}

	private string GetTimeString(int remainTimeSec)
	{
		return null;
	}
}
