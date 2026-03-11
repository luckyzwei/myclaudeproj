using System;
using UnityEngine.UI;
using UnityEngine;

public class NextSpinTimerWidget : MonoBehaviour
{
	private const float UPDATE_EVERY_X_SECS = 1f;

	[SerializeField]
	private Text m_timerText;

	[SerializeField]
	private string m_format;

	private float m_refreshTimer;

	private bool m_callbackSent;

	private Action m_timerHitZero;

	private int m_secondsRemaining;

	private void Start()
	{
	}

	public void ListenToWhenTimerHits0(Action onTimerHitZero, long secondsRemaining)
	{
	}

	private void UpdateTimerText()
	{
	}

	protected virtual string FormatTime(int time)
	{
		return null;
	}

	private void Update()
	{
	}
}
