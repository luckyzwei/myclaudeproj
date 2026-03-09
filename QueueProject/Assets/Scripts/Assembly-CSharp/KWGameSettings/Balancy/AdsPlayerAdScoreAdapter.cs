using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsPlayerAdScoreAdapter : AdsPlayerAdScore
	{
		public override long MaxAdTimeCompensationMs
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override float NoFillThresholdScaleFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override AdsScoreCoeficient[] Coefficients { get; set; }
	}
}
