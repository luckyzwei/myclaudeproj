using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMaxAPSSettingsAdapter : AdsMaxAPSSettings
	{
		[SerializeField]
		private AdsMaxAPSPlatformAdapter iOS;

		[SerializeField]
		private AdsMaxAPSPlatformAdapter android;

		public override AdsMaxAPSPlatform IOS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsMaxAPSPlatform Android
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
