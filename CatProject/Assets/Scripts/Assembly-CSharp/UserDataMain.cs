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

	public StageData StageData { get { return null; } }

	public RegionData RegionData { get { return null; } }

	public DateTime CompanyRefreshTime { get; set; }

	public int MaxRegion { get { return 0; } }

	public RegionData MaxRegionData { get { return null; } }

	public InGameSeasonalData SeasonalData { get; set; }
}
