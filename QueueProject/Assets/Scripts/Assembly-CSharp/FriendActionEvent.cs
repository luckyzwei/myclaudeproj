public class FriendActionEvent : AnalyticsObjectBase
{
	public enum Action
	{
		requested = 0,
		accepted = 1,
		declined = 2,
		removed = 3,
		blocked = 4,
		unblocked = 5
	}

	private const string EVENT_NAME = "friend_";

	public FriendActionEvent(Action action, string actionLocation)
		: base(null)
	{
	}
}
