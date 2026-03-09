using System;

namespace KWAnalytics.Analytics
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AnalyticsEventParameterAttribute : Attribute
	{
		public string Name { get; }

		public string Description { get; }

		public AnalyticsEventParameterAttribute(string name, string description)
		{
		}
	}
}
