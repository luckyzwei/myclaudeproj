using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsScoreCoeficientAdapter : AdsScoreCoeficient
	{
		[SerializeField]
		private string metric;

		[SerializeField]
		private float weight;

		[SerializeField]
		private float relativeWeight;

		[SerializeField]
		private long timeInterval;

		public override string Metric
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override float Weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override float RelativeWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override long TimeInterval
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
