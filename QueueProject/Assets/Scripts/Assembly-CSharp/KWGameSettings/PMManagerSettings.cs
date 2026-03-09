using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class PMManagerSettings
	{
		public abstract bool EnablePMMSystem { get; set; }

		public abstract int DailyPushLimit { get; set; }

		public abstract int SpamPreventionMinutes { get; set; }

		public abstract int QuietHoursStartHour { get; set; }

		public abstract int QuietHoursEndHour { get; set; }

		public abstract int ForegroundCancelSeconds { get; set; }
	}
}
