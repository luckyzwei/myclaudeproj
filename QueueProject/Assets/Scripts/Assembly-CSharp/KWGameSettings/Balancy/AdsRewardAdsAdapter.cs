using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsRewardAdsAdapter : AdsRewardAds
	{
		public override int InterstitialCoolDown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int InterstitialCoolDownByLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override AdsRewardAdBlockerSettings BlockerSettings { get; set; }

		public override bool EnableRVAdText
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
