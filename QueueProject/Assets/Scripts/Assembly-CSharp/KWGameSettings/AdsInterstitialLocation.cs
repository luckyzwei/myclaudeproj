using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsInterstitialLocation
	{
		public abstract string Location { get; set; }

		public abstract bool CanShow { get; set; }

		public abstract long Cooldown { get; set; }

		public abstract int CooldownByLevel { get; set; }

		public abstract float Probability { get; set; }

		public abstract bool EnableAdBreakPopup { get; set; }

		public abstract float[] ImpressionsThreshold { get; set; }

		public abstract float[] NoFillImpressionsThreshold { get; set; }
	}
}
