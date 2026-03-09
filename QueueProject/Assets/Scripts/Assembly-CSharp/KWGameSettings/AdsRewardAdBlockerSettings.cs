using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsRewardAdBlockerSettings
	{
		public abstract bool Enabled { get; set; }

		public abstract long Duration { get; set; }

		public abstract long OvertimeToKill { get; set; }

		public abstract long RetryInterval { get; set; }
	}
}
