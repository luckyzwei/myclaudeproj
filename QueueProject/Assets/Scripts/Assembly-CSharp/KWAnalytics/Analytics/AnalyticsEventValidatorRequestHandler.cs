using System;

namespace KWAnalytics.Analytics
{
	public class AnalyticsEventValidatorRequestHandler
	{
		private const string CUSTOM_HEADER_VALUE = "RmV0Y2hBbmFseXRpY3NQYXJhbWV0ZXJAa3dhbGVlMTIz";

		private const string ENDPOINT = "get_analytics_parameter";

		public void RequestParameterDefinitions(Action<string> onSuccess, Action<long, string> onFailure)
		{
		}

		private string GetServerUrl()
		{
			return null;
		}
	}
}
