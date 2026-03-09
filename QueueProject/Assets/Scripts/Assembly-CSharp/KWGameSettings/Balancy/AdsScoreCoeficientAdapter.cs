using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	public class AdsScoreCoeficientAdapter : AdsScoreCoeficient
	{
		public override string Metric { get; set; }

		public override float Weight { get; set; }

		public override float RelativeWeight { get; set; }

		public override long TimeInterval { get; set; }

		public AdsScoreCoeficientAdapter(global::Balancy.Models.Settings.Core.AdsScoreCoeficient coeficient)
		{
		}

		public static AdsScoreCoeficientAdapter[] GetArray()
		{
			return null;
		}
	}
}
