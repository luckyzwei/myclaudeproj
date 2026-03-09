using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsInterstitialSplashSettingsAdapter : AdsInterstitialSplashSettings
	{
		public override int StartShowingAfterBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowEveryXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
