using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class GameCoreAdapter : GameCore
	{
		public override bool EnableBankAnalytics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool ShowNoAds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
