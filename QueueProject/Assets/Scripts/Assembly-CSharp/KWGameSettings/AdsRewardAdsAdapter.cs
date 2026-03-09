using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsRewardAdsAdapter : AdsRewardAds
	{
		[SerializeField]
		private int interstitialCoolDown;

		[SerializeField]
		private int interstitialCoolDownByLevel;

		[SerializeField]
		private AdsRewardAdBlockerSettingsAdapter rewardAdBlockerSettings;

		[SerializeField]
		private bool enableRVAdText;

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

		public override AdsRewardAdBlockerSettings BlockerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
