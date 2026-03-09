using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAds.Ads;
using UnityEngine;

namespace KWFirebase
{
	public class FirebaseManager
	{
		[CompilerGenerated]
		private sealed class _003CUpdateTimeSinceStartUpRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FirebaseManager _003C_003E4__this;

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
			public _003CUpdateTimeSinceStartUpRoutine_003Ed__32(int _003C_003E1__state)
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

		private const string CURRENT_AD_TYPE = "current_ad_type";

		private const string TIME_SINCE_STARTUP = "time_since_start_up";

		private const string APP_IN_BACKGROUND = "app_in_background";

		private const string WATERFALL_STATUS = "waterfall_status";

		private const string APP_SESSION_ID = "app_session_id";

		private const string GAME_SESSION_ID = "game_session_id";

		private const string DEVICE_ID = "device_id";

		private const string LEVEL = "level";

		private const string STAGE = "stage";

		private const string COUNTRY = "country";

		private const string REMOTE_SETTINGS_RECEIVED = "remote_settings_received";

		private const float TIME_SINCE_START_UPDATE_INTERVAL = 1f;

		private static bool s_isInitialized;

		private static WaitForSecondsRealtime s_timeSinceStartUpdateYieldInstruction;

		private readonly FirebaseRevenueImpression m_firebaseRevenueImpression;

		private bool m_initialisationStarted;

		private string m_currentAdType;

		private bool m_isApplicationPaused;

		private bool m_remoteSettingsReceived;

		private WaitForSecondsRealtime m_timeSinceStartUpdateYieldInstruction;

		public static bool IsInitialized => false;

		public static event Action<bool> OnFirebaseInitialisedEvent
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

		private void HandleGameSettingsReceived()
		{
		}

		private void InitialiseFirebase()
		{
		}

		private void InitialiseCrashlytics()
		{
		}

		public static void LogMessage(string message)
		{
		}

		public static void LogException(Exception exception)
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTimeSinceStartUpRoutine_003Ed__32))]
		private IEnumerator UpdateTimeSinceStartUpRoutine()
		{
			return null;
		}

		private void OnLevelCompleted()
		{
		}

		private void OnInterstitialAdStarted(CoreAdImpressionData adImpressionData)
		{
		}

		private void OnRewardedVideoAdStarted(CoreAdImpressionData adImpressionData)
		{
		}

		private void OnInterstitialAdFinished(string adUnit)
		{
		}

		private void OnRewardedAdFinished()
		{
		}

		private void SetAdStatus(string adStatus)
		{
		}

		private void SetTimeSinceStartKeyValues()
		{
		}

		private void SetCountry(string country)
		{
		}

		private void SetKeysAndValues()
		{
		}

		private void UpdateVendorIdKey()
		{
		}

		public static void OnFeedbackButtonClicked()
		{
		}
	}
}
