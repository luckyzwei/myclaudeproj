using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class IntInsteadOfRv
	{
		public abstract bool Enabled { get; set; }

		public abstract float MinRevenueBoostPercentage { get; set; }
	}
}
