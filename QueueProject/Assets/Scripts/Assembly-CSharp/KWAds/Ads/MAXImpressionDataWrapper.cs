namespace KWAds.Ads
{
	public class MAXImpressionDataWrapper : ImpressionDataWrapperBase<MaxSdkBase.AdInfo>
	{
		public override CoreCompetitorImpressionData GetCompetitorImpressionData()
		{
			return null;
		}

		public override void AdLoaded(MaxSdkBase.AdInfo impressionData)
		{
		}

		public override void AdPaid(MaxSdkBase.AdInfo impressionData)
		{
		}

		public override double? GetRevenue()
		{
			return null;
		}

		public bool IsLoading()
		{
			return false;
		}

		public override string GetAppAdPlacementFormat()
		{
			return null;
		}

		public override void SetAppAdPlacementFormat(string appAdPlacementFormat)
		{
		}

		public override string GetJsonRepresentation()
		{
			return null;
		}
	}
}
