using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMaxAPSSettingsAdapter : AdsMaxAPSSettings
	{
		public override AdsMaxAPSPlatform IOS { get; set; }

		public override AdsMaxAPSPlatform Android { get; set; }
	}
}
