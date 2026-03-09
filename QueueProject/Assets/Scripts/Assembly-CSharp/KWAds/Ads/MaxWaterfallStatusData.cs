namespace KWAds.Ads
{
	public struct MaxWaterfallStatusData
	{
		public string adUnitId;

		public int originalIndex;

		public MAXImpressionDataWrapper impressionData;

		public MaxWaterfallStatusData(string adUnitId, int originalIndex)
		{
			this.adUnitId = null;
			this.originalIndex = 0;
			impressionData = null;
		}

		public MaxWaterfallStatusData(string adUnitId, int originalIndex, MAXImpressionDataWrapper impressionData)
		{
			this.adUnitId = null;
			this.originalIndex = 0;
			this.impressionData = null;
		}

		public MaxWaterfallStatusData(MaxWaterfallStatusData waterfallStatus)
		{
			adUnitId = null;
			originalIndex = 0;
			impressionData = null;
		}
	}
}
