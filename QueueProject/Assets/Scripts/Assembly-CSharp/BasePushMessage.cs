using System;
using KWPushNotifications.PushMessageManager;
using UnityEngine;

public abstract class BasePushMessage : MonoBehaviour
{
	[SerializeField]
	protected string m_titleKey;

	[SerializeField]
	protected string m_bodyKey;

	[SerializeField]
	protected PushPriority m_priority;

	protected DateTime m_minTime;

	protected DateTime m_maxTime;

	protected string m_title;

	protected string m_body;

	public abstract string GetPushMessageID();

	protected void SetMinTime(DateTime minTime, bool absoluteTime = false)
	{
	}

	protected void SetMinTime(TimeSpan timeSpan, bool absoluteTime = false)
	{
	}

	protected void SetMinTime(TimeSpanSerializable timeSpan, bool absoluteTime = false)
	{
	}

	protected void SetMinTime(int days, int hour, int minute, int seconds, bool absoluteTime = false)
	{
	}

	protected void SetMaxTime(DateTime maxTime, bool absoluteTime = false)
	{
	}

	protected void SetMaxTime(TimeSpan timeSpan, bool absoluteTime = false)
	{
	}

	protected void SetMaxTime(TimeSpanSerializable timeSpan, bool absoluteTime = false)
	{
	}

	protected void SetMaxTime(int days, int hour, int minute, int seconds, bool absoluteTime = false)
	{
	}

	protected void SetPriority(PushPriority priority)
	{
	}

	public void Trigger(int minDeliverTimeSeconds, int maxDeliverTimeSeconds, PushPriority priority = PushPriority.P2_MEDIUM)
	{
	}

	public void Trigger(DateTime minDeliverTime, DateTime maxDeliverTime, PushPriority priority = PushPriority.P2_MEDIUM)
	{
	}

	public void Trigger()
	{
	}

	public void CancelPreviouslySetPushMessage()
	{
	}

	public static DateTime GetServerTime()
	{
		return default(DateTime);
	}

	public abstract void ReCheck();

	public virtual void TestTrigger()
	{
	}
}
