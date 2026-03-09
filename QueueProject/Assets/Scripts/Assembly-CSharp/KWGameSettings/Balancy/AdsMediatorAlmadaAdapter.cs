using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsMediatorAlmadaAdapter : AdsMediatorAlmada
	{
		public override string AppIdAndroid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppIdIOS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override long BannerRefreshTimeInMs
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long RetryBannerAdsRequestTimeAfterLostBidInMs
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
