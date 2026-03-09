using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMediatorMAX
	{
		public abstract AdsMAXWaterfallData WaterfallData { get; set; }

		public abstract AdsMaxAPSSettings APS { get; set; }
	}
}
