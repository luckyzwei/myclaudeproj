using System;
using Balancy.Data;
using KWCore.Utils;

public class NotificationWidgetManager : Singleton<NotificationWidgetManager>
{
	public static Action NotificationChanged;

	private UserNotificationData SaveData => null;

	protected override void Init()
	{
	}

	public bool IsNotificationActive(string notificationId)
	{
		return false;
	}

	public bool IsNotificationRegistered(string notificationId)
	{
		return false;
	}

	public void AddNotification(string notificationId)
	{
	}

	public int GetNotificationCount(string notificationId)
	{
		return 0;
	}

	public void SwallowNotification(string notificationId, bool swallowAll = true)
	{
	}
}
