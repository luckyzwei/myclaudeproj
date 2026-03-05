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

	public bool IsMaxLevel { get { return maxLevel > 0 && productLevel >= maxLevel; } }

	public SeasonalDistributorProductData(int themeIdx, int idx, int sortOrder, DateTime lastSellingTime = default(DateTime))
	{
		productIdx = idx;
		productSortOrder = sortOrder;
		productLevel = 0;
		lastSellingDataTime = lastSellingTime;
		isSelling = new ReactiveProperty<bool>(false);
		isPauseSelling = new ReactiveProperty<bool>(false);
		isUpgradeOpen = new ReactiveProperty<bool>(false);
		unlockCost = BigInteger.Zero;
		unlock_level = 0;
		maxLevel = 0;
	}
}
