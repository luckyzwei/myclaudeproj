using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWGameSettings;
using UnityEngine;

namespace KWPushNotifications.PushMessageManager
{
	public class PushMessageManager
	{
		[CompilerGenerated]
		private sealed class _003CForegroundCancellationCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PushMessageManager _003C_003E4__this;

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
			public _003CForegroundCancellationCoroutine_003Ed__19(int _003C_003E1__state)
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

		private PushScheduler m_scheduler;

		private PushRuleEngine m_ruleEngine;

		private PushStorage m_storage;

		private LocalPushNotificationsBase m_platformProvider;

		private PushNotifications m_settings;

		private Coroutine m_foregroundCancellationCoroutine;

		private bool m_isApplicationForeground;

		private bool m_isInitialized;

		public void Initialise(LocalPushNotificationsBase platformProvider, PushNotifications settings, PushStorage storage)
		{
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		public void TriggerLocalPushNotification(PushTriggerData data)
		{
		}

		public void CancelPush(string pushId)
		{
		}

		public Dictionary<string, SavedNotificationData> GetScheduledPushes()
		{
			return null;
		}

		private void CheckDeliveredPushes()
		{
		}

		private void ProcessPushQueue()
		{
		}

		private void ApplyForegroundCancellation()
		{
		}

		public int GetTodaysDeliveredPushCount()
		{
			return 0;
		}

		private void UpdateForegroundMonitoring()
		{
		}

		public void StopForegroundMonitoring()
		{
		}

		[IteratorStateMachine(typeof(_003CForegroundCancellationCoroutine_003Ed__19))]
		private IEnumerator ForegroundCancellationCoroutine()
		{
			return null;
		}

		private float CalculateForegroundCheckInterval()
		{
			return 0f;
		}
	}
}
