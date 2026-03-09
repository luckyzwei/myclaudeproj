using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	public class AdsMAXPlatformAdUnityAdapter : AdsMAXPlatformAdUnity
	{
		public override string AdUnit { get; set; }

		public override bool Enabled { get; set; }

		public AdsMAXPlatformAdUnityAdapter(global::Balancy.Models.Settings.Core.AdsMAXPlatformAdUnity adUnity)
		{
		}

		public static AdsMAXPlatformAdUnityAdapter[] GetArray(global::Balancy.Models.Settings.Core.AdsMAXPlatformAdUnity[] adType)
		{
			return null;
		}
	}
}
