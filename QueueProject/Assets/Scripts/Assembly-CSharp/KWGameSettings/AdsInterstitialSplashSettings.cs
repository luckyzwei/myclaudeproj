using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsInterstitialSplashSettings
	{
		public abstract int StartShowingAfterBoots { get; set; }

		public abstract int ShowEveryXBoots { get; set; }
	}
}
