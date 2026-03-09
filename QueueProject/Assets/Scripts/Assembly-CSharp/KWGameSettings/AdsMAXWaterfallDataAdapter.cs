using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMAXWaterfallDataAdapter : AdsMAXWaterfallData
	{
		[SerializeField]
		private bool enableMultipleWaterfalls;

		[SerializeField]
		private bool enableWaterfallsShuffle;

		[SerializeField]
		private AdsMAXWaterfallPlatformAdapter iosPlatform;

		[SerializeField]
		private AdsMAXWaterfallPlatformAdapter androidPlatform;

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

		public override AdsMAXWaterfallPlatform IOS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsMAXWaterfallPlatform Android
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
