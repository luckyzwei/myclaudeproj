using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class GameCoreAdapter : GameCore
	{
		[SerializeField]
		private bool enableBankAnalytics;

		[SerializeField]
		private bool showNoAds;

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
