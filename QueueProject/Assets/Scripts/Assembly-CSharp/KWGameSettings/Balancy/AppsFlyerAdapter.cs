using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AppsFlyerAdapter : AppsFlyer
	{
		public override AppsFlyerCustomEvents[] CustomEvents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int SystemDisableAfterHours
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool SendRevenueData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int IdleThresholdSeconds
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
