using System;
using TMPro;
using UnityEngine;

public class ScaledTimeTimer : MonoBehaviour
{
	private const float PULSE_AMOUNT = 0.3f;

	private const float PULSE_DURATION = 1f;

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private Animator m_animator;

	private Action m_callback;

	private float m_timeScale;

	private float m_targetTime;

	private float m_elapsedTime;

	private int m_prevSecondsInt;

	private bool m_isPaused;

	private bool m_isConfigured;

	private void Awake()
	{
	}

	public void Config(float timeScale)
	{
	}

	public void ConfigWithDuration(float targetTime, float duration, Action callback)
	{
	}

	public void Config(float timeScale, float targetTime, Action callback)
	{
	}

	private void SetAnimatorPlaying()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	private void Update()
	{
	}

	public void SkipToEnd()
	{
	}

	public void SetTimeScale(float timeScale)
	{
	}

	public void SetColorAndPulse(Color color)
	{
	}
}
