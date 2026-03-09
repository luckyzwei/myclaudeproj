using Balancy.Models;

namespace KWGameSettings.Balancy
{
	public class PMManagerSettingsAdapter : PMManagerSettings
	{
		public override bool EnablePMMSystem { get; set; }

		public override int DailyPushLimit { get; set; }

		public override int SpamPreventionMinutes { get; set; }

		public override int QuietHoursStartHour { get; set; }

		public override int QuietHoursEndHour { get; set; }

		public override int ForegroundCancelSeconds { get; set; }

		public PMManagerSettingsAdapter(PmManagerSettings pmManagerSettings)
		{
		}
	}
}
