using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWPushNotifications.PushMessageManager;
using Unity.Notifications.Android;

namespace KWPushNotifications
{
	public class AndroidPushNotifications : LocalPushNotificationsBase
	{
		[CompilerGenerated]
		private sealed class _003CRequestNotificationPermission_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AndroidPushNotifications _003C_003E4__this;

			private PermissionRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRequestNotificationPermission_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string GAME_ICON_SMALL = "game_icon_small";

		private const string GAME_ICON_LARGE = "game_icon_large";

		private AndroidNotificationChannel m_androidNotificationChannel;

		private AndroidNotification m_notification;

		private int m_lastProcessedNotificationId;

		public override void Initialise(PushStorage storage)
		{
		}

		protected override void CheckForPermissionChange()
		{
		}

		public override void RequestUserAuthorization()
		{
		}

		[IteratorStateMachine(typeof(_003CRequestNotificationPermission_003Ed__8))]
		private IEnumerator RequestNotificationPermission()
		{
			return null;
		}

		private void RegisterForAndroidNotifications()
		{
		}

		public override void HandleLocalNotificationsOnPause(bool pause)
		{
		}

		public override int SendLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
		{
			return 0;
		}

		public override void OnUserRespondedToNotification()
		{
		}

		public override void CancelAllLocalNotifications()
		{
		}

		public override void CancelScheduledLocalNotificationFromId(string messageId, string context = "")
		{
		}
	}
}
