using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsAppOpen
	{
		public abstract OpenAdLocation[] Locations { get; set; }

		public abstract bool ShowOnFirstBoot { get; set; }

		public abstract int ShowAfterXBoots { get; set; }

		public abstract int ShowEveryXBoots { get; set; }

		public abstract string AdUnitAndroid { get; set; }

		public abstract string AdUnitIos { get; set; }
	}
}
