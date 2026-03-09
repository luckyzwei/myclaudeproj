using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMAXWaterfallDataAdapter : AdsMAXWaterfallData
	{
		public override bool EnableMultipleWaterfalls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool EnableWaterfallsShuffle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override AdsMAXWaterfallPlatform IOS { get; set; }

		public override AdsMAXWaterfallPlatform Android { get; set; }
	}
}
