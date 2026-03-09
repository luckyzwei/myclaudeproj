using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMAXWaterfallPlatform
	{
		public abstract AdsMAXPlatformAdUnity[] Interstitial { get; set; }

		public abstract AdsMAXPlatformAdUnity[] Reward { get; set; }

		public abstract AdsMAXPlatformAdUnity[] Banner { get; set; }
	}
}
