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
		TimerType = E_TimerType.RemainTime;
		EndTime = endTime;
		LimitTimeSec = totalTimeSec;
		LocalFormatKey = localFormatKey;
		TimeFormat = timeFormat;
		OnTimeEnd = onTimeEnd;
		Prefix = null;
		Suffix = null;
		bStartTimer = true;
	}

	public void SetRemainTimer(DateTime endTime, int totalTimeSec, string prefix, string suffix, E_TimeFormat timeFormat, Action onTimeEnd)
	{
		TimerType = E_TimerType.RemainTime;
		EndTime = endTime;
		LimitTimeSec = totalTimeSec;
		Prefix = prefix;
		Suffix = suffix;
		LocalFormatKey = null;
		TimeFormat = timeFormat;
		OnTimeEnd = onTimeEnd;
		bStartTimer = true;
	}

	public void SetRemainTimer(DateTime endTime, int totalTimeSec, E_TimeFormat timeFormat, Action onTimeEnd)
	{
		TimerType = E_TimerType.RemainTime;
		EndTime = endTime;
		LimitTimeSec = totalTimeSec;
		LocalFormatKey = null;
		Prefix = null;
		Suffix = null;
		TimeFormat = timeFormat;
		OnTimeEnd = onTimeEnd;
		bStartTimer = true;
	}

	public void SetElapsedTimer(DateTime startTime, int limitTimeSec, string localFormatKey, E_TimeFormat timeFormat, Action onTimeEnd)
	{
		TimerType = E_TimerType.ElapsedTime;
		StartTime = startTime;
		LimitTimeSec = limitTimeSec;
		LocalFormatKey = localFormatKey;
		TimeFormat = timeFormat;
		OnTimeEnd = onTimeEnd;
		bStartTimer = true;
	}

	public void SetProgressValue(int value)
	{
		if (TimeSlider != null)
			TimeSlider.value = value;
	}

	public void SetLocalizeText(string key)
	{
		if (TimeText != null)
			TimeText.text = key;
	}

	public void SetText(string textStr)
	{
		if (TimeText != null)
			TimeText.text = textStr;
	}

	private void Update()
	{
		if (!bStartTimer) return;
		if (TimerType == E_TimerType.RemainTime)
			UpdateRemainTime();
		else if (TimerType == E_TimerType.ElapsedTime)
			UpdateElapsedTime();
	}

	private void UpdateRemainTime()
	{
		int remainSec = (int)(EndTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec < 0) remainSec = 0;
		TimerTimeSec = remainSec;
		SetTimeText(remainSec);
		if (LimitTimeSec > 0)
			SetTimeSlider(LimitTimeSec - remainSec, LimitTimeSec);
		OnUpdateTimeSec?.Invoke(remainSec);
		if (remainSec <= 0)
		{
			bStartTimer = false;
			OnTimeEnd?.Invoke();
		}
	}

	private void UpdateElapsedTime()
	{
		int elapsedSec = (int)(DateTime.UtcNow - StartTime).TotalSeconds;
		int remainSec = LimitTimeSec - elapsedSec;
		if (remainSec < 0) remainSec = 0;
		TimerTimeSec = remainSec;
		SetTimeText(remainSec);
		SetTimeSlider(elapsedSec, LimitTimeSec);
		OnUpdateTimeSec?.Invoke(remainSec);
		if (remainSec <= 0)
		{
			bStartTimer = false;
			OnTimeEnd?.Invoke();
		}
	}

	private void SetTimeText(int remainTimeSec)
	{
		if (TimeText == null) return;
		string timeStr = GetTimeString(remainTimeSec);
		if (!string.IsNullOrEmpty(LocalFormatKey))
			TimeText.text = string.Format(LocalFormatKey, timeStr);
		else if (!string.IsNullOrEmpty(Prefix) || !string.IsNullOrEmpty(Suffix))
			TimeText.text = (Prefix ?? "") + timeStr + (Suffix ?? "");
		else
			TimeText.text = timeStr;
	}

	private void SetTimeSlider(int elapsedTimeSec, int totalTimeSec)
	{
		if (TimeSlider == null || totalTimeSec <= 0) return;
		TimeSlider.value = Mathf.Clamp01((float)elapsedTimeSec / totalTimeSec);
	}

	private string GetTimeString(int remainTimeSec)
	{
		if (remainTimeSec < 0) remainTimeSec = 0;
		int hours = remainTimeSec / 3600;
		int minutes = (remainTimeSec % 3600) / 60;
		int seconds = remainTimeSec % 60;
		switch (TimeFormat)
		{
			case E_TimeFormat.TimeFormat_Long:
				return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
			case E_TimeFormat.TimeFormat_Short:
				if (hours > 0) return string.Format("{0}h {1}m", hours, minutes);
				if (minutes > 0) return string.Format("{0}m {1}s", minutes, seconds);
				return string.Format("{0}s", seconds);
			case E_TimeFormat.TwoDigitLong:
				return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
			case E_TimeFormat.TwoDigitShort:
				return string.Format("{0:D2}:{1:D2}", minutes, seconds);
			case E_TimeFormat.MinuteSecondColons:
				return string.Format("{0:D2}:{1:D2}", minutes, seconds);
			default:
				return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
		}
	}
}
