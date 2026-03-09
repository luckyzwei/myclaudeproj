public class AccountActionEvent : AnalyticsObjectBase
{
	public enum Action
	{
		link_start = 0,
		link_end = 1,
		sync = 2,
		unlink = 3,
		delete = 4,
		lost = 5
	}

	private const string EVENT_NAME = "account_";

	public AccountActionEvent(Action action, string platform, string location)
		: base(null)
	{
	}
}
