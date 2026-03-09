using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsScoreCoeficient
	{
		public abstract string Metric { get; set; }

		public abstract float Weight { get; set; }

		public abstract float RelativeWeight { get; set; }

		public abstract long TimeInterval { get; set; }
	}
}
