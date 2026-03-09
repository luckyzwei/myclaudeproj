using System.Collections;
using System.Collections.Generic;
using KWCore.CoreRequests;

namespace KWAnalytics.Analytics
{
	public class AnalyticsProvider : BaseProvider
	{
		private const string API_END_POINT = "https://events.api.kwalee.com/";

		private AnalyticsLocalStorage m_localStorage;

		private List<Hashtable> m_eventCache;

		private bool m_suspendHasBegun;

		public void Start()
		{
		}

		public override void FlushSession()
		{
		}

		protected override void LogEventInternal(AnalyticEvent analyticEvent)
		{
		}

		public override void LogEventImmediate(AnalyticEvent analyticEvent)
		{
		}

		private void CheckLocalStorage()
		{
		}

		private void SendEventsToHttp()
		{
		}

		private void CacheEvent(AnalyticEvent analyticEvent)
		{
		}

		private void TryFlushCacheOnNewEvents()
		{
		}

		private void FlushCache()
		{
		}

		private void AddEventToServer(string postData, string eventType = null, bool isMultipleEvents = false)
		{
		}

		private void EventErrorCallback(long errorCode, string error)
		{
		}

		private void EventSuccessCallback(string success)
		{
		}

		private List<CoreRequestHeader> GenerateAnalyticsHeaders(string eventType = null, bool isMultipleEvents = false)
		{
			return null;
		}

		private string GetBuildEnvironment()
		{
			return null;
		}

		private string GetDevicePlatform()
		{
			return null;
		}

		private bool IsDebugEvent()
		{
			return false;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		public override void StartSession()
		{
		}

		protected override void LogEventInternal(BaseSchema baseSchema)
		{
		}
	}
}
