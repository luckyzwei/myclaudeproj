using KWAnalytics.Analytics;

public class AddressableAnalytics : OpenSchema
{
	private const string EVENT_NAME = "server_error";

	public void SetMessage(string message)
	{
	}

	public void SetType(string type)
	{
	}

	public void SetName(string name)
	{
	}

	protected override string GetUniqueKeyForJoin()
	{
		return null;
	}
}
