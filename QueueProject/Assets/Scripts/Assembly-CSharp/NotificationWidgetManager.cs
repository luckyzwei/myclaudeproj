using System;
using System.Collections.Generic;
using Balancy.Data;
using KWCore.Utils;

public class NotificationWidgetManager : Singleton<NotificationWidgetManager>
{
	public static Action NotificationChanged;

	private Dictionary<string, int> m_notifications;

	private UserNotificationData SaveData => null;

	protected override void Init()
	{
		m_notifications = new Dictionary<string, int>();
	}

	public bool IsNotificationActive(string notificationId)
	{
		return m_notifications != null && m_notifications.ContainsKey(notificationId) && m_notifications[notificationId] > 0;
	}

	public bool IsNotificationRegistered(string notificationId)
	{
		return m_notifications != null && m_notifications.ContainsKey(notificationId);
	}

	public void AddNotification(string notificationId)
	{
		if (m_notifications == null) m_notifications = new Dictionary<string, int>();
		if (m_notifications.ContainsKey(notificationId))
			m_notifications[notificationId]++;
		else
			m_notifications[notificationId] = 1;
		NotificationChanged?.Invoke();
	}

	public int GetNotificationCount(string notificationId)
	{
		if (m_notifications != null && m_notifications.ContainsKey(notificationId))
			return m_notifications[notificationId];
		return 0;
	}

	public void SwallowNotification(string notificationId, bool swallowAll = true)
	{
		if (m_notifications == null || !m_notifications.ContainsKey(notificationId)) return;
		if (swallowAll)
			m_notifications[notificationId] = 0;
		else
			m_notifications[notificationId] = Math.Max(0, m_notifications[notificationId] - 1);
		NotificationChanged?.Invoke();
	}
}
