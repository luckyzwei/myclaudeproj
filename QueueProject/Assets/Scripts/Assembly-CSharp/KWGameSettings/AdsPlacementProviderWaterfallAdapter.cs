using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsPlacementProviderWaterfallAdapter : AdsPlacementProviderWaterfall
	{
		[SerializeField]
		private string[] interstitial;

		[SerializeField]
		private string[] playable;

		[SerializeField]
		private string[] reward;

		[SerializeField]
		private string[] banner;

		[SerializeField]
		private string[] native;

		[SerializeField]
		private string[] appOpen;

		public override string[] Interstitial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Playable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Reward
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Banner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] Native
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] AppOpen
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
