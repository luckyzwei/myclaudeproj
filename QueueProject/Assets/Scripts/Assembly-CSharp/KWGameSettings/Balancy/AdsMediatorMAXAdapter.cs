using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMediatorMAXAdapter : AdsMediatorMAX
	{
		public override AdsMAXWaterfallData WaterfallData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsMaxAPSSettings APS
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
