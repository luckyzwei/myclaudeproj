using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsRewardAds
	{
		public abstract int InterstitialCoolDown { get; set; }

		public abstract int InterstitialCoolDownByLevel { get; set; }

		public abstract AdsRewardAdBlockerSettings BlockerSettings { get; set; }

		public abstract bool EnableRVAdText { get; set; }
	}
}
