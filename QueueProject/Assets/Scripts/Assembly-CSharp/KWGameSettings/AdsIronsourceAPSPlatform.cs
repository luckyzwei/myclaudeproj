using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsIronsourceAPSPlatform
	{
		public abstract string AppKey { get; set; }

		public abstract string InterstitialKey { get; set; }

		public abstract string RewardKey { get; set; }

		public abstract string BannerKey { get; set; }
	}
}
