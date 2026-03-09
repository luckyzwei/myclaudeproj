using KWAnalytics.Analytics;

public class AnalyticsObjectBase
{
	private int m_key;

	private string m_eventName;

	public AnalyticsObjectBase(string eventName)
	{
	}

	protected GenericEvent GetGenericEvent()
	{
		return null;
	}

	public void AddBoolParam(int index, bool value)
	{
	}

	public void AddIntParam(int index, int value)
	{
	}

	public void AddStringParam(int index, string value)
	{
	}

	public void AddVeryLongString(string[] values, string name)
	{
	}

	public void Close()
	{
	}
}
