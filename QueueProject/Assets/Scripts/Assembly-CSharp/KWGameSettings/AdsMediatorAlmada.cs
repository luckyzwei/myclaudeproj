using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMediatorAlmada
	{
		public abstract string AppIdAndroid { get; set; }

		public abstract string AppIdIOS { get; set; }

		public abstract long BannerRefreshTimeInMs { get; set; }

		public abstract long RetryBannerAdsRequestTimeAfterLostBidInMs { get; set; }
	}
}
