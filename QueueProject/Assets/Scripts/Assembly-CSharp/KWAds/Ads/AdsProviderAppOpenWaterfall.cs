namespace KWAds.Ads
{
	public class AdsProviderAppOpenWaterfall : AdsProviderWaterfallBase
	{
		protected override void SetCompetitorData(CoreCompetitorImpressionData competitorData, AdsProviderBase selectedProvider)
		{
		}

		protected override CoreMediatorImpressionData GetCoreImpressionData(AdsProviderBase provider)
		{
			return null;
		}

		protected override string GetWaterfallTypeNameForDebugLogs()
		{
			return null;
		}
	}
}
