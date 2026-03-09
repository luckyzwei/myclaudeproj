using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsInterstitialAdapter : AdsInterstitial
	{
		public override int MinLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int StartDelayByLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int GlobalCooldownByLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int StartDelayFirstByLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int StartDelay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int GlobalCooldown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int StartDelayFirst
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool EnableDoubleIntSystem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override AdsInterstitialLocation[] Locations { get; set; }

		public override AdsInterstitialSplashSettings SplashSettings { get; set; }
	}
}
