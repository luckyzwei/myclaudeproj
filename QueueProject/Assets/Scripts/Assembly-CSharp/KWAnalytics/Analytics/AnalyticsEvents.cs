using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KWAnalytics.Analytics
{
	public class AnalyticsEvents
	{
		public static event Action<AnalyticEvent> OnAnalyticsEventLogged
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

		public static event Action<Hashtable> OnStoredAnalyticsLogged
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

		public static void SendOnAnalyticsEventLogged(AnalyticEvent analyticEvent)
		{
		}

		public static void SendOnStoredAnalyticsLogged(Hashtable analyticEvent)
		{
		}
	}
}
