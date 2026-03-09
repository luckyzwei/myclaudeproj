using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMAXWaterfallPlatformAdapter : AdsMAXWaterfallPlatform
	{
		[SerializeField]
		private AdsMAXPlatformAdUnityAdapter[] interstitial;

		[SerializeField]
		private AdsMAXPlatformAdUnityAdapter[] reward;

		[SerializeField]
		private AdsMAXPlatformAdUnityAdapter[] banner;

		public override AdsMAXPlatformAdUnity[] Interstitial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsMAXPlatformAdUnity[] Reward
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsMAXPlatformAdUnity[] Banner
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
