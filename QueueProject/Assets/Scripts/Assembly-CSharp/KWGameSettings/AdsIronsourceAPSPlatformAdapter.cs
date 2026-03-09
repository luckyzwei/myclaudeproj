using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsIronsourceAPSPlatformAdapter : AdsIronsourceAPSPlatform
	{
		[SerializeField]
		private string appKey;

		[SerializeField]
		private string interstitialKey;

		[SerializeField]
		private string rewardKey;

		[SerializeField]
		private string bannerKey;

		public override string AppKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string InterstitialKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RewardKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string BannerKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
