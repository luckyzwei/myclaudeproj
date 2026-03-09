using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMAXPlatformAdUnityAdapter : AdsMAXPlatformAdUnity
	{
		[SerializeField]
		private string adUnit;

		[SerializeField]
		private bool enabled;

		public override string AdUnit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool Enabled
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
