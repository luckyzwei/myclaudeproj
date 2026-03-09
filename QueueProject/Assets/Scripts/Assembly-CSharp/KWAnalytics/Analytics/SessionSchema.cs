using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class SessionSchema : ClosedSchema
	{
		public enum State
		{
			STARTED = 0,
			ENDED = 1
		}

		public SessionSchema(State state)
		{
		}
	}
}
