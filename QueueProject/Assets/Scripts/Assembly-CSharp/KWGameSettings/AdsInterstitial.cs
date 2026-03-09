using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsInterstitial
	{
		public abstract int MinLevel { get; set; }

		public abstract int StartDelayByLevel { get; set; }

		public abstract int GlobalCooldownByLevel { get; set; }

		public abstract int StartDelayFirstByLevel { get; set; }

		public abstract int StartDelay { get; set; }

		public abstract int GlobalCooldown { get; set; }

		public abstract int StartDelayFirst { get; set; }

		public abstract AdsInterstitialLocation[] Locations { get; set; }

		public abstract AdsInterstitialSplashSettings SplashSettings { get; set; }

		public abstract bool EnableDoubleIntSystem { get; set; }
	}
}
