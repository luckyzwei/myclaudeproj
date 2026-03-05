using Unity.Notifications.Android;

public class LocalNotification
{
	private static AndroidNotificationChannel notificationChannel;

	public static void CallNotification(int pushID, double remainTime, string title, string context)
	{
		if (remainTime <= 0) return;
		var notification = new AndroidNotification();
		notification.Title = title;
		notification.Text = context;
		notification.FireTime = System.DateTime.Now.AddSeconds(remainTime);
		notification.SmallIcon = "icon_small";
		notification.LargeIcon = "icon_large";
		AndroidNotificationCenter.SendNotification(notification, "default_channel");
	}

	public static void AllClearNotification()
	{
		AndroidNotificationCenter.CancelAllNotifications();
	}

	public static void Init()
	{
		notificationChannel = new AndroidNotificationChannel()
		{
			Id = "default_channel",
			Name = "Default Channel",
			Importance = Importance.Default,
			Description = "Game notifications"
		};
		AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);
	}

	private static int GetSDKInt()
	{
#if UNITY_ANDROID && !UNITY_EDITOR
		using (var version = new UnityEngine.AndroidJavaClass("android.os.Build$VERSION"))
		{
			return version.GetStatic<int>("SDK_INT");
		}
#else
		return 0;
#endif
	}
}
