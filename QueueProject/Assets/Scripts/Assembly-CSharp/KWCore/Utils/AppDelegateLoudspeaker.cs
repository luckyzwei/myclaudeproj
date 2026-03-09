using System.Runtime.CompilerServices;
using UnityEngine;

namespace KWCore.Utils
{
	public class AppDelegateLoudspeaker : MonoBehaviour
	{
		public delegate void RegisteredForRemoteNotificationsDelegate(string token);

		public delegate void FailedToRegisterForRemoteNotificationsDelegate();

		public delegate void ReceivedRemoteNotificationDelegate(string payload);

		public delegate void ReceivedLocalNotificationDelegate();

		public delegate void OpenedURLDelegate(string url);

		public delegate void ReceivedMemoryWarningDelegate();

		public delegate void SignificantTimeChangeDelegate();

		public delegate void WillChangeStatusBarFrameDelegate();

		public delegate void WillChangeStatusBarOrientationDelegate();

		public delegate void ApplicationDidFinishLaunchingDelegate();

		public delegate void ApplicationDidBecomeActiveDelegate();

		public delegate void ApplicationWillResignActiveDelegate();

		public delegate void ApplicationWillTerminateDelegate();

		public delegate void ApplicationReadyToRecieveMessagesDelegate();

		private static AndroidJavaClass s_androidCls;

		private static AndroidJavaClass AndroidCls => null;

		public static event RegisteredForRemoteNotificationsDelegate RegisteredForRemoteNotifications
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event FailedToRegisterForRemoteNotificationsDelegate FailedToRegisterForRemoteNotifications
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ReceivedRemoteNotificationDelegate ReceivedRemoteNotification
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ReceivedLocalNotificationDelegate ReceivedLocalNotification
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OpenedURLDelegate OpenURL
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ReceivedMemoryWarningDelegate ReceivedMemoryWarning
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SignificantTimeChangeDelegate SignificantTimeChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event WillChangeStatusBarFrameDelegate WillChangeStatusBarFrame
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event WillChangeStatusBarOrientationDelegate WillChangeStatusBarOrientation
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ApplicationDidFinishLaunchingDelegate ApplicationDidFinishLaunching
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ApplicationDidBecomeActiveDelegate ApplicationDidBecomeActive
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ApplicationWillResignActiveDelegate ApplicationWillResignActive
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ApplicationWillTerminateDelegate ApplicationWillTerminate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event ApplicationReadyToRecieveMessagesDelegate ApplicationReadyToRecieveMessages
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetReadyForMessages()
		{
		}

		public void _BroadcastUIApplicationDidRegisterForRemoteNotificationsNotification(string token)
		{
		}

		public void _BroadcastUIApplicationDidFailToRegisterForRemoteNotificationsNotification()
		{
		}

		public void _BroadcastUIApplicationDidReceiveRemoteNotificationNotification(string payload)
		{
		}

		public void _BroadcastUIApplicationDidReceiveLocalNotificationNotification()
		{
		}

		public void _BroadcastUIApplicationDidOpenURL(string url)
		{
		}

		public void _BroadcastUIApplicationDidReceiveMemoryWarningNotification()
		{
		}

		public void _BroadcastUIApplicationSignificantTimeChangeNotification()
		{
		}

		public void _BroadcastUIApplicationWillChangeStatusBarFrameNotification()
		{
		}

		public void _BroadcastUIApplicationWillChangeStatusBarOrientationNotification()
		{
		}

		public void _BroadcastUIApplicationDidFinishLaunchingNotification()
		{
		}

		public void _BroadcastUIApplicationDidBecomeActiveNotification()
		{
		}

		public void _BroadcastUIApplicationWillResignActiveNotification()
		{
		}

		public void _BroadcastUIApplicationWillTerminateNotification()
		{
		}

		public void SendReadyToRecieveMessagesEvent()
		{
		}
	}
}
