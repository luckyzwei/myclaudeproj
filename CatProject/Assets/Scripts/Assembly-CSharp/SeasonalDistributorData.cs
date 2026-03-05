using System.Collections.Generic;
using Treeplla;
using UniRx;

public class SeasonalDistributorData
{
	private int SeasonInfoIdx;

	private int SeasonThemeIdx;

	public Dictionary<int, SeasonalDistributorProductData> SaleProductsMap;

	public int BuildingIdx { get; private set; }

	public IReactiveProperty<int> ProductSellingCoolTimeSec { get; private set; }

	public void Init(int seasonInfoIdx, Treeplla.SeasonalBuildingData buildingTable)
	{
		SeasonInfoIdx = seasonInfoIdx;
		if (buildingTable != null)
		{
			BuildingIdx = buildingTable.BuildingIdx;
			SeasonThemeIdx = buildingTable.SeasonThemeIdx;
		}
		SaleProductsMap = new Dictionary<int, SeasonalDistributorProductData>();
		ProductSellingCoolTimeSec = new ReactiveProperty<int>(0);
		SetProductSellingCoolTimeSec(seasonInfoIdx);
	}

	public void SetTempProductSellingCoolTimeSec(int timeSec)
	{
		if (ProductSellingCoolTimeSec != null)
			ProductSellingCoolTimeSec.Value = timeSec;
	}

	public List<int> GetSellingIdxList()
	{
		var list = new List<int>();
		if (SaleProductsMap == null) return list;
		foreach (var kvp in SaleProductsMap)
		{
			if (kvp.Value != null && kvp.Value.isSelling != null && kvp.Value.isSelling.Value)
				list.Add(kvp.Key);
		}
		return list;
	}

	private void SetProductSellingCoolTimeSec(int seasonInfoIdx)
	{
		// Set cooltime from table data based on season info
		if (ProductSellingCoolTimeSec != null)
			ProductSellingCoolTimeSec.Value = 60;
	}
}
