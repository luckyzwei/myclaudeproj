using System;
using System.Collections.Generic;

public class ExponentialRetry
{
	private Action m_triggerCallback;

	private readonly int m_maxPow;

	private float m_retryTimer;

	private float m_retryPow;

	private static List<float> m_sequence;

	public ExponentialRetry(Action callback, int maxPow)
	{
	}

	public void Update(float time)
	{
	}

	public void StartRetryTimer()
	{
	}

	public void ResetPow()
	{
	}
}
