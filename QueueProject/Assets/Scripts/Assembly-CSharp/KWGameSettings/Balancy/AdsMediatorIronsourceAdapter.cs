using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMediatorIronsourceAdapter : AdMediatorIronsource
	{
		public override AdsIronsourceAPSSettings APS { get; set; }

		public override string AppKeyIos
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppKeyAndroid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppKeyChina
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
