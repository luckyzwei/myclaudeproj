using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAds;
using KWAds.Ads;
using KWCore.LowEndDeviceTests;

namespace KWCore.Stats
{
	public class UseStatsManager
	{
		private class VisibleAnalyticItem
		{
			public int layerValue;

			public int sortOrder;

			public string itemName;
		}

		[CompilerGenerated]
		private sealed class _003CIncrementAdExclusiveSessionTime_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UseStatsManager _003C_003E4__this;

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
			public _003CIncrementAdExclusiveSessionTime_003Ed__56(int _003C_003E1__state)
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

		private const string OLD_INSTALL_ID_KEY = "authInstallId";

		private const float AD_EXCLUSIVE_SESSION_WAIT_TIME = 1f;

		private int m_gamesPlayedThisBoot;

		private readonly List<TimeEvent> m_eventsTimeline;

		private BandwidthTest m_bandwidthTest;

		private FramerateTest m_framerateTest;

		private MemoryInfoTest m_memoryInfoTest;

		private string m_currentSessionID;

		private long m_sessionStartTime;

		private long m_adStartedTime;

		private long m_pauseStartTime;

		private long m_gameplayPauseTimeStamp;

		private long m_gameplayResumeTimeStamp;

		private long m_currentSessionAdWatchedDuration;

		private long m_lastUpdatedSessionGameplayDuration;

		private long m_sessionInterstitialAdWatchedDuration;

		private long m_sessionRewardAdWatchedDuration;

		private long m_currentAdExclusiveSessionTime;

		private bool m_paused;

		private bool m_adStarted;

		private float m_combinedRevenue;

		public string LevelClientId => null;

		public int LevelAttemptCount => 0;

		public static event Action<long> OnAdDisplayedDurationEvent
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

		public static void SendAdDisplayedDurationEvent(long adWatchedTime)
		{
		}

		public void Initialise()
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		public void DoOnApplicationPauseCompleted(bool pause)
		{
		}

		public long GetLastSessionFinishedTimeStamp()
		{
			return 0L;
		}

		public string GetInstallId()
		{
			return null;
		}

		public string GetPreviousInstallVersion()
		{
			return null;
		}

		public string GetCurrentInstallVersion(bool removeMinorVersion)
		{
			return null;
		}

		private void MigrateInstallId()
		{
		}

		private void GenerateInstallId()
		{
		}

		public int GetNumberOfBoots()
		{
			return 0;
		}

		public int GetNumberOfBootsThisVersion()
		{
			return 0;
		}

		public int GetNumberOfSessions()
		{
			return 0;
		}

		public int GetNumberOfSessionsThisVersion()
		{
			return 0;
		}

		public long GetSessionStartTime()
		{
			return 0L;
		}

		public long GetSessionGameplayDuration()
		{
			return 0L;
		}

		public long GetSessionAdWatchedDuration()
		{
			return 0L;
		}

		public long GetTotalSessionDuration()
		{
			return 0L;
		}

		public long GetSessionInterstitialAdWatchedDuration()
		{
			return 0L;
		}

		public long GetSessionRewardAdWatchedDuration()
		{
			return 0L;
		}

		public List<TimeEvent> GetEventsTimeline()
		{
			return null;
		}

		private void UpdateGameplayTime()
		{
		}

		private void HandleAdStartedEvent(string providerBaseName)
		{
		}

		private void HandleAdCompletedEvent(AdType adType)
		{
		}

		private bool CheckSessionIDChanged()
		{
			return false;
		}

		public long GetAccumulativeSessionTime()
		{
			return 0L;
		}

		public long GetAccumulativeSessionTimeSeconds()
		{
			return 0L;
		}

		private void HandleIncrementAdExclusiveSessionTime()
		{
		}

		[IteratorStateMachine(typeof(_003CIncrementAdExclusiveSessionTime_003Ed__56))]
		private IEnumerator IncrementAdExclusiveSessionTime()
		{
			return null;
		}

		public long GetAdExclusiveSessionTime()
		{
			return 0L;
		}

		private void SetAdExclusiveSessionTime()
		{
		}

		public long GetInstallTime()
		{
			return 0L;
		}

		public long GetTimeSinceInstallTime()
		{
			return 0L;
		}

		public long GetTimeSinceSessionStartTime()
		{
			return 0L;
		}

		public bool GetHasBeenUpdated()
		{
			return false;
		}

		public int NumberOfDaysSinceInstallIgnoringTime()
		{
			return 0;
		}

		public int NumberOfDaysSinceInstall()
		{
			return 0;
		}

		private DateTime DateTimeSinceInstall()
		{
			return default(DateTime);
		}

		public void RecordANewPlay()
		{
		}

		public int GetTotalNumberOfPlays()
		{
			return 0;
		}

		public int GetNumberOfPlaysThisBoot()
		{
			return 0;
		}

		public float GetDownloadSpeed()
		{
			return 0f;
		}

		public float GetAverageFPSPerStage()
		{
			return 0f;
		}

		public int GetAvailableDiskSpaceInMB()
		{
			return 0;
		}

		public int GetAvailableRAMSpaceInMB()
		{
			return 0;
		}

		public int GetInterstitialsWatched()
		{
			return 0;
		}

		public int GetRewardsWatched()
		{
			return 0;
		}

		public void BumpRewardsWatched()
		{
		}

		private void UpdateIapRevenue(float revenue)
		{
		}

		private void UpdateAdRevenue(float revenue)
		{
		}

		private void HandleAdRevenuePaid(CoreMediatorImpressionData impressionData)
		{
		}

		public float GetTotalAdRevenue()
		{
			return 0f;
		}

		private void HandleIapRevenuePaid(float revenue)
		{
		}

		private void UpdateCombinedRevenue(float revenue)
		{
		}

		private void NewBestItem(ref VisibleAnalyticItem item, int layerValue, int sortOrder, string name)
		{
		}

		private void CompareBestItem(ref VisibleAnalyticItem bestItem, int layerValue, int sortingOrder, string itemName)
		{
		}

		private void SendSessionLengthAnalytic()
		{
		}

		public int GetLevelAttemptCount(string levelClientId)
		{
			return 0;
		}

		public string GetLevelAttemptId(string levelClientId)
		{
			return null;
		}

		public void SetLevelClientID(string levelClientId)
		{
		}

		public void SaveGameSessionValues(string levelClientID, int levelAttempt)
		{
		}

		public bool HasUserUpgradedThisBoot(bool includeMinorVersion)
		{
			return false;
		}

		private string RemoveMinorVersion(string version)
		{
			return null;
		}
	}
}
