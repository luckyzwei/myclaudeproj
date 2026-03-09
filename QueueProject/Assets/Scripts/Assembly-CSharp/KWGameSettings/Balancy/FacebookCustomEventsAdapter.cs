using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	public class FacebookCustomEventsAdapter : FacebookCustomEventSettings
	{
		public override string EventName { get; set; }

		public override bool Enabled { get; set; }

		public override int[] EventValues { get; set; }

		public FacebookCustomEventsAdapter(FacebookEvent facebookEvent)
		{
		}
	}
}
