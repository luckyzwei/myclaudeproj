using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMediatorAlmadaAdapter : AdsMediatorAlmada
	{
		[SerializeField]
		private string appIdAndroid;

		[SerializeField]
		private string appIdIOS;

		[SerializeField]
		private long bannerRefreshTimeInMs;

		[SerializeField]
		private long retryBannerAdsRequestTimeAfterLostBidInMs;

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
