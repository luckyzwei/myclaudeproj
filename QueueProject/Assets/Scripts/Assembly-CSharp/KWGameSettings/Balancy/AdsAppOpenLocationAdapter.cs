using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	public class AdsAppOpenLocationAdapter : OpenAdLocation
	{
		public override string Location { get; set; }

		public override bool CanShow { get; set; }

		public override float Probability { get; set; }

		private AdsAppOpenLocationAdapter(AdsAppOpenLocation location)
		{
		}

		public static AdsAppOpenLocationAdapter[] GetArray()
		{
			return null;
		}
	}
}
