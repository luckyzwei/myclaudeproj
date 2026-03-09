using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsRewardAdBlockerSettingsAdapter : AdsRewardAdBlockerSettings
	{
		public override bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override long Duration
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long OvertimeToKill
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long RetryInterval
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
