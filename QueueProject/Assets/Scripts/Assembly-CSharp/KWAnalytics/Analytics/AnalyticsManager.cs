using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	public class AnalyticsManager
	{
		private const string SESSION_STARTED = "started";

		private const string SESSION_ENDED = "ended";

		private string m_sessionId;

		private string m_unitySessionId;

		private string m_instanceId;

		private readonly object m_flushSessionLock;

		private List<BaseProvider> m_providersList;

		private List<AnalyticEvent> m_tempEventsCache;

		private bool m_gameSettingsLoaded;

		private string m_lastSentAbTestEvent;

		public void Initialise(BaseProvider provider = null)
		{
		}

		public string GetSessionID()
		{
			return null;
		}

		public string GetInstanceID()
		{
			return null;
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		public void DoOnApplicationQuit()
		{
		}

		public void LogEvent(AnalyticEvent analyticEvent)
		{
		}

		public void LogEventImmediate(AnalyticEvent analyticEvent)
		{
		}

		private bool IsEventBlackListed(AnalyticEvent @event)
		{
			return false;
		}

		private void HandleGameLoaded()
		{
		}

		private void HandleGameSettingsUpdated()
		{
		}

		private void RegisterProvider(BaseProvider provider)
		{
		}

		private void GenerateNewSessionID()
		{
		}

		private void GenerateInstanceID()
		{
		}

		private void TrySendABTestEvent()
		{
		}

		private void SendSessionEvent(string sessionContext)
		{
		}

		private void SendAppLifeCycleEvent(string sessionContext)
		{
		}

		private void SendInstallEvent()
		{
		}

		private void SendDeviceInfoEvent()
		{
		}

		private void SendVendorIdEvent()
		{
		}

		private void SendAppUpdatedEvent()
		{
		}

		private void AddEventToDebugPage(AnalyticEvent analyticEvent)
		{
		}

		private void FlushSession()
		{
		}
	}
}
