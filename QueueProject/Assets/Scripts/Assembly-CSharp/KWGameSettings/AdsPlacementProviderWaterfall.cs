using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsPlacementProviderWaterfall
	{
		public abstract string[] Interstitial { get; set; }

		public abstract string[] Playable { get; set; }

		public abstract string[] Reward { get; set; }

		public abstract string[] Banner { get; set; }

		public abstract string[] Native { get; set; }

		public abstract string[] AppOpen { get; set; }
	}
}
