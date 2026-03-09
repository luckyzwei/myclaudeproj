using System;

namespace KWAnalytics.Analytics
{
	[AttributeUsage(AttributeTargets.Class)]
	public class AnalyticsEventAttribute : Attribute
	{
		public string Name { get; }

		public string Description { get; }

		public AnalyticsEventAttribute(string name, string description)
		{
		}
	}
}
