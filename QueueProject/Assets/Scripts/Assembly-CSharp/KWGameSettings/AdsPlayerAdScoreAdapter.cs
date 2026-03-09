using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsPlayerAdScoreAdapter : AdsPlayerAdScore
	{
		[SerializeField]
		private long maxAdTimeCompensationMs;

		[SerializeField]
		private float noFillThresholdScaleFactor;

		[SerializeField]
		private AdsScoreCoeficientAdapter[] coefficients;

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

		public override AdsScoreCoeficient[] Coefficients
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
