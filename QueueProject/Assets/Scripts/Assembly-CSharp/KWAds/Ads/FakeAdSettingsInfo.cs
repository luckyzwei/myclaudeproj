using System;

namespace KWAds.Ads
{
	[Serializable]
	public class FakeAdSettingsInfo
	{
		[Serializable]
		public class AdNetwork
		{
			public string name;

			public float minBid;

			public float maxBid;

			public AdNetwork()
			{
			}

			public AdNetwork(string name, float minBid, float maxBid)
			{
			}
		}

		public AdNetwork adNetwork;

		public string adUnit;

		public string instanceName;

		public string instanceId;

		public string segmentName;

		public double lifetimeRevenue;

		public string ab;

		public string country;

		public string auctionId;

		public double? revenue;

		public string appAdPlacementFormat;

		public void GenerateBid()
		{
		}
	}
}
