public class SoftRatingAnalytics
{
	public static class RatingsPopup
	{
		public enum FlowSteps
		{
			POPUP = 0,
			CONFIRM = 1,
			FEEDBACK = 2,
			CLOSED = 3
		}

		public static void SendEvent(FlowSteps step, int rating)
		{
		}
	}
}
