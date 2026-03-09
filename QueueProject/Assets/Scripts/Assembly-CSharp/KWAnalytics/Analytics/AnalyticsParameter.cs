namespace KWAnalytics.Analytics
{
	public class AnalyticsParameter<T>
	{
		public string Name { get; set; }

		public T Value { get; set; }

		public AnalyticsParameter(string name)
		{
		}

		public void SetValue(T value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
