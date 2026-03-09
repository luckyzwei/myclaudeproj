using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsPlacementProviderWaterfallAdapter : AdsPlacementProviderWaterfall
	{
		public override string[] Interstitial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Playable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Reward
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Banner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Native
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] AppOpen
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string[] GetSelectedEnumValues<TEnum>(TEnum selectedValues) where TEnum : Enum
		{
			return null;
		}
	}
}
