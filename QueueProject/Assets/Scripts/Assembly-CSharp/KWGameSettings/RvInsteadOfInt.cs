using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class RvInsteadOfInt
	{
		public abstract bool Enabled { get; set; }

		public abstract int EnableOnLevel { get; set; }

		public abstract int ShowEveryXInts { get; set; }

		public abstract float MinRevenueBoostPercentage { get; set; }

		public abstract int MaxIntDailyReplacements { get; set; }

		public abstract int MaxDailyIntNoFillReplacements { get; set; }

		public abstract bool ShowRVOnIntNoFill { get; set; }
	}
}
