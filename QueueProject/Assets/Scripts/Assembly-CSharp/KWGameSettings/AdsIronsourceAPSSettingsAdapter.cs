using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsIronsourceAPSSettingsAdapter : AdsIronsourceAPSSettings
	{
		[SerializeField]
		private AdsIronsourceAPSPlatformAdapter iOS;

		[SerializeField]
		private AdsIronsourceAPSPlatformAdapter android;

		public override AdsIronsourceAPSPlatform IOS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override AdsIronsourceAPSPlatform Android
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
