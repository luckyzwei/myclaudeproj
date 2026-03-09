using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsIronsourceAPSSettings
	{
		public abstract AdsIronsourceAPSPlatform IOS { get; set; }

		public abstract AdsIronsourceAPSPlatform Android { get; set; }
	}
}
