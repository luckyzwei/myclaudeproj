using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class RvInsteadOfIntAdapter : RvInsteadOfInt
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private int enableOnLevel;

		[SerializeField]
		private int showEveryXInts;

		[SerializeField]
		private float minRevenueBoostPercentage;

		[SerializeField]
		private int maxIntDailyReplacements;

		[SerializeField]
		private int maxDailyIntNoFillReplacements;

		[SerializeField]
		private bool showRVOnIntNoFill;

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
