using System;
using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsInterstitialLocationsAdapter : AdsInterstitialLocation
	{
		public override string Location { get; set; }

		public override bool CanShow { get; set; }

		public override long Cooldown { get; set; }

		public override int CooldownByLevel { get; set; }

		public override float Probability { get; set; }

		public override bool EnableAdBreakPopup { get; set; }

		public override float[] ImpressionsThreshold { get; set; }

		public override float[] NoFillImpressionsThreshold { get; set; }

		private AdsInterstitialLocationsAdapter(global::Balancy.Models.Settings.Core.AdsInterstitialLocation location)
		{
		}

		public static AdsInterstitialLocationsAdapter[] GetArray()
		{
			return null;
		}
	}
}
