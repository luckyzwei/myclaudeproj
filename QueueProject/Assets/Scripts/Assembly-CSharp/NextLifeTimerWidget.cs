using System;
using TMPro;
using UnityEngine;

public class NextLifeTimerWidget : MonoBehaviour
{
	private const int HOURS_IN_DAY = 24;

	private const int MINUTES_IN_HOUR = 60;

	private const int SECONDS_IN_MINUTE = 60;

	private const float UPDATE_EVERY_X_SECS = 1f;

	[SerializeField]
	private TextMeshProUGUI m_timerText;

	[SerializeField]
	private string m_fullText;

	private float m_timer;

	private Action m_timerHitZero;

	private bool m_callbackSent;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void ListenToWhenTimerHits0(Action onTimerHitZero)
	{
	}

	private void UpdateTimerText()
	{
	}

	private void Update()
	{
	}

	private void HandleCurrencyChanged(long newValue, string currencyID, long diffAmount)
	{
	}

	private void LifeSystemManagerOnLivesValueChanged(int newlifecount)
	{
	}

	private void LifeSystemManagerOnInfiniteLivesExpired()
	{
	}
}
