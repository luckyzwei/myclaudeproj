using System;
using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMaxAPSPlatformAdapter : AdsMaxAPSPlatform
	{
		public override string AppKey { get; set; }

		public override string InterstitialKey { get; set; }

		public override string RewardKey { get; set; }

		public override string BannerKey { get; set; }

		public AdsMaxAPSPlatformAdapter(global::Balancy.Models.Settings.Core.AdsMaxAPSPlatform platform)
		{
		}
	}
}
