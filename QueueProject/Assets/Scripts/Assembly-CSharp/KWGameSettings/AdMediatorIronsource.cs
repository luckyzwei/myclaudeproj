using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdMediatorIronsource
	{
		public abstract AdsIronsourceAPSSettings APS { get; set; }

		public abstract string AppKeyIos { get; set; }

		public abstract string AppKeyAndroid { get; set; }

		public abstract string AppKeyChina { get; set; }
	}
}
