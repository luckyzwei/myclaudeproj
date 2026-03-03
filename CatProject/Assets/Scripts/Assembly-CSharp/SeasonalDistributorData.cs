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
	}

	public void SetTempProductSellingCoolTimeSec(int timeSec)
	{
	}

	public List<int> GetSellingIdxList()
	{
		return null;
	}

	private void SetProductSellingCoolTimeSec(int seasonInfoIdx)
	{
	}
}
