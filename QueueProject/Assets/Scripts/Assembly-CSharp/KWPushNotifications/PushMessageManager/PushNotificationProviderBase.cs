using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KWPushNotifications.PushMessageManager
{
	public abstract class PushNotificationProviderBase : IPushNotificationProvider
	{
		[CompilerGenerated]
		private sealed class _003CCheckUserRespondedToNotificationOnBoot_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PushNotificationProviderBase _003C_003E4__this;

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
			public _003CCheckUserRespondedToNotificationOnBoot_003Ed__2(int _003C_003E1__state)
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

		protected LocalPushNotificationsBase m_platformProvider;

		public virtual void Initialise(bool requestAuthorizationOnAppLaunch, PushStorage storage)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckUserRespondedToNotificationOnBoot_003Ed__2))]
		private IEnumerator CheckUserRespondedToNotificationOnBoot()
		{
			return null;
		}

		public virtual void DoOnApplicationPause(bool pause)
		{
		}

		public void RequestUserAuthorization()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void CreateLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
		{
		}

		public virtual void TriggerLocalPushNotification(PushTriggerData data)
		{
		}

		public virtual Dictionary<string, SavedNotificationData> GetScheduledPushes()
		{
			return null;
		}

		public virtual int GetTodaysDeliveredPushCount()
		{
			return 0;
		}

		public abstract void CancelScheduledLocalPushNotification(string messageId);

		public abstract string GetSystemName();
	}
}
