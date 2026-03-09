using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class IntInsteadOfRvAdapter : IntInsteadOfRv
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
