using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsInterstitialAdapter : AdsInterstitial
	{
		[SerializeField]
		private CooldownSystemType cooldownSystemType;

		[SerializeField]
		private int unlockLevel;

		[SerializeField]
		private int startDelay;

		[SerializeField]
		private int globalCooldown;

		[SerializeField]
		private int startDelayFirst;

		[SerializeField]
		private int startDelayByLevel;

		[SerializeField]
		private int globalCooldownByLevel;

		[SerializeField]
		private int startDelayFirstByLevel;

		[SerializeField]
		private AdsInterstitialLocationsAdapter[] locations;

		[SerializeField]
		private AdsInterstitialSplashSettingsAdapter splashSettings;

		[SerializeField]
		private bool enableDoubleIntSystem;

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

		public override AdsInterstitialLocation[] Locations
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsInterstitialSplashSettings SplashSettings
		{
			get
			{
				return null;
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
	}
}
