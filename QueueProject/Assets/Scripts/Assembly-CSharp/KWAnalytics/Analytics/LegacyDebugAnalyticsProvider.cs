using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KWAnalytics.Analytics
{
	public class LegacyDebugAnalyticsProvider : BaseProvider
	{
		private List<Hashtable> m_eventList;

		public static event Action<Hashtable> DebugAnalyticSent
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

		public override void AppSuspendHasBegun(bool suspend)
		{
		}

		public override void StartSession()
		{
		}

		public override void FlushSession()
		{
		}

		protected override void LogEventInternal(BaseSchema baseSchema)
		{
		}

		protected override void LogEventInternal(AnalyticEvent analyticEvent)
		{
		}
	}
}
