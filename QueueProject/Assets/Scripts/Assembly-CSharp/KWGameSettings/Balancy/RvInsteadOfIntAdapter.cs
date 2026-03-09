using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class RvInsteadOfIntAdapter : RvInsteadOfInt
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

		public override int EnableOnLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowEveryXInts
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override float MinRevenueBoostPercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override int MaxIntDailyReplacements
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int MaxDailyIntNoFillReplacements
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool ShowRVOnIntNoFill
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
