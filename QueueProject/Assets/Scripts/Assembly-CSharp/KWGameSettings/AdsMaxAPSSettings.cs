using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMaxAPSSettings
	{
		public abstract AdsMaxAPSPlatform IOS { get; set; }

		public abstract AdsMaxAPSPlatform Android { get; set; }
	}
}
