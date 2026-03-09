using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	public class AdsMAXWaterfallPlatformAdapter : AdsMAXWaterfallPlatform
	{
		public override AdsMAXPlatformAdUnity[] Interstitial { get; set; }

		public override AdsMAXPlatformAdUnity[] Reward { get; set; }

		public override AdsMAXPlatformAdUnity[] Banner { get; set; }

		public AdsMAXWaterfallPlatformAdapter(global::Balancy.Models.Settings.Core.AdsMAXWaterfallPlatform platform)
		{
		}
	}
}
