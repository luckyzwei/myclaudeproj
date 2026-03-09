using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsInterstitialSplashSettingsAdapter : AdsInterstitialSplashSettings
	{
		[SerializeField]
		private int startShowingAfterBoots;

		[SerializeField]
		private int showEveryXBoots;

		public override int StartShowingAfterBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowEveryXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
