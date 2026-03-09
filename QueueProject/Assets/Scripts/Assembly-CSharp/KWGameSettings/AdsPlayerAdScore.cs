using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsPlayerAdScore
	{
		public abstract long MaxAdTimeCompensationMs { get; set; }

		public abstract float NoFillThresholdScaleFactor { get; set; }

		public abstract AdsScoreCoeficient[] Coefficients { get; set; }
	}
}
