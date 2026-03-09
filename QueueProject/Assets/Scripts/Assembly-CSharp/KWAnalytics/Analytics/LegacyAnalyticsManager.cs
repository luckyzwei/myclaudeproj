using System;
using System.Collections.Generic;
using KWCore;

namespace KWAnalytics.Analytics
{
	public class LegacyAnalyticsManager
	{
		private const string PREF_RECORDANALYTICS = "prefs_recordAnalytics";

		public static string SESSION_ID;

		public static string UNITY_SESSION_ID;

		public static long PREVIOUS_SESSION_START_TIME;

		public static long PREVIOUS_SESSION_END_TIME;

		private List<BaseProvider> m_providersList;

		private Dictionary<Type, OpenSchema> m_openSchemas;

		private Dictionary<int, OpenSchema> m_openKeySchemas;

		private int m_openSchemaKeyIndex;

		private readonly object m_flushSessionLock;

		private List<ServerInterface> m_serverInterfaces;

		private int m_appInstallKey;

		public void Initialize(List<ServerInterface> serverInterfaces, BaseProvider provider = null, string userId = null)
		{
		}

		public void RegisterProvider(BaseProvider provider)
		{
		}

		private void TryGenerateNewSessionID(bool fromPauseEvent)
		{
		}

		private void HandleSessionIDEnd()
		{
		}

		public static string GetGameSessionID()
		{
			return null;
		}

		public static string GetUnitySessionID()
		{
			return null;
		}

		public void AddInstantEvent(BaseSchema schema)
		{
		}

		public void AddOpenEvent(OpenSchema openSchema)
		{
		}

		public void AddOpenDebugEvent(OpenSchema openSchema)
		{
		}

		public int AddOpenEventWithKey(OpenSchema schema)
		{
			return 0;
		}

		public int AddOpenDebugEventWithKey(OpenSchema openSchema)
		{
			return 0;
		}

		private T GetOpenEvent<T>() where T : OpenSchema
		{
			return null;
		}

		public T GetOpenOrJoinEvent<T>() where T : OpenSchema, new()
		{
			return null;
		}

		private T GetOpenEventWithKey<T>(int key) where T : OpenSchema
		{
			return null;
		}

		public T GetOpenOrJoinEventWithKey<T>(int key) where T : OpenSchema, new()
		{
			return null;
		}

		public void CloseOpenEvent<T>() where T : OpenSchema
		{
		}

		public void CloseOpenEventWithKey<T>(int key) where T : OpenSchema
		{
		}

		private void LogEvent(BaseSchema schema)
		{
		}

		private void CloseAnyOpenEvents()
		{
		}

		public void FlushSession()
		{
		}

		public void DoOnApplicationQuit()
		{
		}

		public void AppSuspendHasBegun(bool suspend)
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		private void TrySendPlayerInstallEvent()
		{
		}

		private void UpdateAppInstalledAnalyticEvent()
		{
		}

		private void ApplyProviderChanges(BaseSchema schema)
		{
		}

		private void SessionStartEvent()
		{
		}

		private void SessionEndEvent()
		{
		}
	}
}
