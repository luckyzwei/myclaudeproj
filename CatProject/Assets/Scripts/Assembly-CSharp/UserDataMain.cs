using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;

public class UserDataMain : IUserDataMode
{
	public OfflineData OfflineData
	{
		get
		{
			var region = RegionData;
			return region != null ? region.OfflineData : null;
		}
		set
		{
			var region = RegionData;
			if (region != null)
				region.OfflineData = value;
		}
	}

	public DateTime NextAdsupplyTime { get; set; }

	public DateTime NextAdsupplyGemTime { get; set; }

	public IReactiveCollection<BuffObjectData> BuffObjects { get; set; }

	public CountingAdsData ExpAdsData { get; set; }

	public CountingAdsData GemAdsData { get; set; }

	public Dictionary<int, RegionData> RegionDatas { get; set; }

	public int ActiveRegion { get; set; }

	public StageData StageData
	{
		get
		{
			var region = RegionData;
			return region != null ? region.StageData : null;
		}
	}

	public RegionData RegionData
	{
		get
		{
			if (RegionDatas == null) return null;
			RegionData data;
			return RegionDatas.TryGetValue(ActiveRegion, out data) ? data : null;
		}
	}

	public DateTime CompanyRefreshTime { get; set; }

	public int MaxRegion
	{
		get
		{
			if (RegionDatas == null || RegionDatas.Count == 0) return 0;
			return RegionDatas.Keys.Max();
		}
	}

	public RegionData MaxRegionData
	{
		get
		{
			if (RegionDatas == null) return null;
			RegionData data;
			return RegionDatas.TryGetValue(MaxRegion, out data) ? data : null;
		}
	}

	public InGameSeasonalData SeasonalData { get; set; }

	public void Init()
	{
		RegionDatas = new Dictionary<int, RegionData>();
		BuffObjects = new ReactiveCollection<BuffObjectData>();
		ActiveRegion = 1;
	}

	public void InitFirstRegion()
	{
		if (RegionDatas == null)
			RegionDatas = new Dictionary<int, RegionData>();

		if (!RegionDatas.ContainsKey(1))
		{
			var region = new RegionData();
			region.StageData = new StageData();
			region.StageData.Init(1);
			region.OfflineData = new OfflineData { LastLoginTime = DateTime.UtcNow };
			region.BuyParkingLotData = new List<BuyParkingLotData>();
			RegionDatas[1] = region;
		}
		ActiveRegion = 1;
	}
}
