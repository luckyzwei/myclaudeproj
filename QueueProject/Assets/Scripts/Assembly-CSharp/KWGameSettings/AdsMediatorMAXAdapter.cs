using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMediatorMAXAdapter : AdsMediatorMAX
	{
		[SerializeField]
		private AdsMAXWaterfallDataAdapter waterfallData;

		[SerializeField]
		private AdsMaxAPSSettingsAdapter aps;

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
