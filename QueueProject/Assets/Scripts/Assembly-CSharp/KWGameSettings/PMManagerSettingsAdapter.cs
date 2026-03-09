using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class PMManagerSettingsAdapter : PMManagerSettings
	{
		[SerializeField]
		private bool enablePMMSystem;

		[SerializeField]
		private int dailyPushLimit;

		[SerializeField]
		private int spamPreventionMinutes;

		[SerializeField]
		private int quietHoursStartHour;

		[SerializeField]
		private int quietHoursEndHour;

		[SerializeField]
		private int foregroundCancelSeconds;

		public override bool EnablePMMSystem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int DailyPushLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int SpamPreventionMinutes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int QuietHoursStartHour
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int QuietHoursEndHour
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ForegroundCancelSeconds
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
