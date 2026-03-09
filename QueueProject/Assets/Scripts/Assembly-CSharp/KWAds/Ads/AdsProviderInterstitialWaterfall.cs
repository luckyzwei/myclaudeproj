namespace KWAds.Ads
{
	public class AdsProviderInterstitialWaterfall : AdsProviderWaterfallBase
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
