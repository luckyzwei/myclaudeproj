using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMAXWaterfallData
	{
		public abstract bool EnableMultipleWaterfalls { get; set; }

		public abstract bool EnableWaterfallsShuffle { get; set; }

		public abstract AdsMAXWaterfallPlatform IOS { get; set; }

		public abstract AdsMAXWaterfallPlatform Android { get; set; }
	}
}
