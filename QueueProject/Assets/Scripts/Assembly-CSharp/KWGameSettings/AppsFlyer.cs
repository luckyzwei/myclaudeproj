using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AppsFlyer
	{
		public abstract AppsFlyerCustomEvents[] CustomEvents { get; set; }

		public abstract int SystemDisableAfterHours { get; set; }

		public abstract bool SendRevenueData { get; set; }

		public abstract int IdleThresholdSeconds { get; set; }
	}
}
