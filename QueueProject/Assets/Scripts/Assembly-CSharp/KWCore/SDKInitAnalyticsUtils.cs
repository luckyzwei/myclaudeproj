using System;
using System.Collections.Generic;

namespace KWCore
{
	public class SDKInitAnalyticsUtils
	{
		private List<string> m_initialisedSystems;

		private List<string> m_tempSystemLogger;

		private DateTime m_initStartTime;

		public SDKInitAnalyticsUtils(DateTime startTime)
		{
		}

		public void AddInitialisedSystem(string systemName)
		{
		}

		public void SendSystemInitializedEvent(string systemName)
		{
		}

		private void SendEvent(string systemName)
		{
		}

		public void SendSDKInitEvent(bool isInitialised, string context)
		{
		}

		private string GetInitialisedSystems()
		{
			return null;
		}
	}
}
