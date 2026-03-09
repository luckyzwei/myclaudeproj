using System;
using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AppsFlyerCustomEventsAdapter : AppsFlyerCustomEvents
	{
		public override string EventName { get; set; }

		public override bool Enabled { get; set; }

		public override int[] EventValues { get; set; }

		public AppsFlyerCustomEventsAdapter(global::Balancy.Models.Settings.Core.AppsFlyerCustomEvents customEvent)
		{
		}

		public static AppsFlyerCustomEventsAdapter[] GetArray()
		{
			return null;
		}
	}
}
