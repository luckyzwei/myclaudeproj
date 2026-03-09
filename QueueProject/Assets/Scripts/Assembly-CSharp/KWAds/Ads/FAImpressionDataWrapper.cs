namespace KWAds.Ads
{
	public class FAImpressionDataWrapper : ImpressionDataWrapperBase<FakeAdSettingsInfo>
	{
		public override CoreCompetitorImpressionData GetCompetitorImpressionData()
		{
			return null;
		}

		public override void AdLoaded(FakeAdSettingsInfo impressionData)
		{
		}

		public override void AdPaid(FakeAdSettingsInfo impressionData)
		{
		}

		public override double? GetRevenue()
		{
			return null;
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
