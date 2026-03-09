namespace KWAds.Ads
{
	public class AdsProviderRewardedWaterfall : AdsProviderWaterfallBase
	{
		protected override CoreMediatorImpressionData GetCoreImpressionData(AdsProviderBase provider)
		{
			return null;
		}

		protected override string GetWaterfallTypeNameForDebugLogs()
		{
			return null;
		}

		protected override void SetCompetitorData(CoreCompetitorImpressionData competitorData, AdsProviderBase selectedProvider)
		{
		}
	}
}
