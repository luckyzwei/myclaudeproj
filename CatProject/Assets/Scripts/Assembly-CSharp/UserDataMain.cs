using System;
using System.Collections.Generic;
using UniRx;

public class UserDataMain : IUserDataMode
{
	public OfflineData OfflineData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DateTime NextAdsupplyTime { get; set; }

	public DateTime NextAdsupplyGemTime { get; set; }

	public IReactiveCollection<BuffObjectData> BuffObjects { get; set; }

	public CountingAdsData ExpAdsData { get; set; }

	public CountingAdsData GemAdsData { get; set; }

	public Dictionary<int, RegionData> RegionDatas { get; set; }

	public int ActiveRegion { get; set; }

	public StageData StageData => null;

	public RegionData RegionData => null;

	public DateTime CompanyRefreshTime { get; set; }

	public int MaxRegion => 0;

	public RegionData MaxRegionData => null;

	public InGameSeasonalData SeasonalData { get; set; }
}
