namespace KWAds.Ads
{
	public class CoreAdImpressionData
	{
		public readonly string location;

		public readonly string adUnitIdentifier;

		public readonly float? cost;

		public string adUnitType { get; private set; }

		public CoreAdImpressionData(string adUnitIdentifier, string adUnitType, string location, float? cost)
		{
		}

		public void SetAdUnitType(string unitType)
		{
		}
	}
}
