using System.Collections;
using System.Collections.Generic;
using KWCore.CoreRequests;

namespace KWAnalytics.Analytics
{
	public class RedshiftAnalyticsProvider : BaseProvider
	{
		private const string QA_API_END_POINT = "https://hyper-uat.api.kwalee.com:743/";

		private const string LIVE_API_END_POINT = "https://hyper.api.kwalee.com:743/";

		private const string API_END_POINT_KEY = "API_END_POINT";

		private LegacyAnalyticProviderLocalStorage m_localStorage;

		private List<Hashtable> m_eventCache;

		private bool m_suspendHasBegun;

		private string m_liveEndPoint;

		public void Start()
		{
		}

		private string GetAPIEndPoint()
		{
			return null;
		}

		private string GetLiveAPIEndPoint()
		{
			return null;
		}

		private void UpdateLiveAPIEndPoint()
		{
		}

		public override void AppSuspendHasBegun(bool suspend)
		{
		}

		public override void StartSession()
		{
		}

		public override void FlushSession()
		{
		}

		private void SendEventsToHTTP()
		{
		}

		private string ExtractEventInfoType(List<Hashtable> events)
		{
			return null;
		}

		private void AddEventToServer(string url, string postData, string eventInfoType = null, bool isMultipleEvents = false)
		{
		}

		private List<CoreRequestHeader> GenerateAnalyticsHeaders(string eventInfoType = null, bool isMultipleEvents = false)
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

		private void EventErrorCallback(long errorCode, string error)
		{
		}

		private void EventSuccessCallback(string success)
		{
		}

		protected override void LogEventInternal(BaseSchema baseSchema)
		{
		}

		protected override void LogEventInternal(AnalyticEvent analyticEvent)
		{
		}

		private void TryFlushCacheOnNewEvents()
		{
		}

		private void FlushCache()
		{
		}

		private void CacheEvent(BaseSchema baseSchema)
		{
		}

		public override void AddProviderParameters(BaseSchema schema)
		{
		}
	}
}
