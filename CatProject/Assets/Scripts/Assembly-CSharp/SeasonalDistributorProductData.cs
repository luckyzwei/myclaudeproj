using System;
using System.Numerics;
using UniRx;

public class SeasonalDistributorProductData
{
	public int productIdx;

	public int productLevel;

	public int productSortOrder;

	public IReactiveProperty<bool> isSelling;

	public IReactiveProperty<bool> isPauseSelling;

	public DateTime lastSellingDataTime;

	public BigInteger unlockCost;

	public int unlock_level;

	public int maxLevel;

	public IReactiveProperty<bool> isUpgradeOpen;

	public bool IsMaxLevel => false;

	public SeasonalDistributorProductData(int themeIdx, int idx, int sortOrder, DateTime lastSellingTime = default(DateTime))
	{
	}
}
