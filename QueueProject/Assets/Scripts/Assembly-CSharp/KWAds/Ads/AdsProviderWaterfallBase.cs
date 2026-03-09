using System.Collections.Generic;

namespace KWAds.Ads
{
	public abstract class AdsProviderWaterfallBase
	{
		private const long JSON_MAX_CHARACTER_COUNT = 4000L;

		private List<AdsProviderBase> m_listOfProviders;

		protected abstract void SetCompetitorData(CoreCompetitorImpressionData competitorData, AdsProviderBase selectedProvider);

		protected abstract CoreMediatorImpressionData GetCoreImpressionData(AdsProviderBase provider);

		protected abstract string GetWaterfallTypeNameForDebugLogs();

		public AdsProviderBase GetCurrentProviderInUse()
		{
			return null;
		}

		public List<AdsProviderBase> GetListOfProviders()
		{
			return null;
		}

		public void AddProviderToTheWaterfall(AdsProviderBase provider)
		{
		}

		private CoreCompetitorImpressionData GetCompetitorData(double? competitorBestBid, string competitorName, string allCompetitorsAuctionResultJson)
		{
			return null;
		}

		private bool IsProviderInTheWaterfall(string providerName)
		{
			return false;
		}

		private AdsProviderBase GetWinnerProvider()
		{
			return null;
		}

		private AdsProviderBase GetRunnerUpProvider(AdsProviderBase winner)
		{
			return null;
		}

		private List<AdsProviderBase> GetListOfReadyProviders()
		{
			return null;
		}

		private string BeautifyJsonSubstring(string str)
		{
			return null;
		}

		private AdsProviderBase GetWinningProviderToUse()
		{
			return null;
		}

		private bool IsCompetitorRevenueBigger(AdsProviderBase provider, AdsProviderBase competitor)
		{
			return false;
		}

		private bool IsProviderRevenueReady(AdsProviderBase provider)
		{
			return false;
		}

		private long GetMediatorJsonMaxCount()
		{
			return 0L;
		}

		private string GetAllCompetitorsJson()
		{
			return null;
		}

		private void SetCompetitorsBidAndData(AdsProviderBase selectedProvider, AdsProviderBase runnerUpProvider)
		{
		}
	}
}
