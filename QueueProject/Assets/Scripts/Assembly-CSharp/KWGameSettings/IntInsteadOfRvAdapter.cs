using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class IntInsteadOfRvAdapter : IntInsteadOfRv
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private float minRevenueBoostPercentage;

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
	}
}
