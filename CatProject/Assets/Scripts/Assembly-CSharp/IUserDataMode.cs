using System;
using System.Collections.Generic;
using UniRx;

public interface IUserDataMode
{
	StageData StageData { get; }

	RegionData RegionData { get; }

	OfflineData OfflineData { get; set; }

	DateTime NextAdsupplyTime { get; set; }

	IReactiveCollection<BuffObjectData> BuffObjects { get; set; }

	CountingAdsData ExpAdsData { get; set; }

	CountingAdsData GemAdsData { get; set; }

	int ActiveRegion { get; set; }

	Dictionary<int, RegionData> RegionDatas { get; set; }

	DateTime CompanyRefreshTime { get; set; }

	InGameSeasonalData SeasonalData { get; set; }

	int MaxRegion { get; }

	RegionData MaxRegionData { get; }
}
