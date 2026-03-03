using System;
using System.Collections.Generic;
using Treeplla.Data;
using UniRx;

public class SeasonalShopData
{
	public DateTime StatueBuyTime;

	public int StatueSlotCount;

	public int CoinBankLevel;

	public int CoinBankValue;

	public List<PackageData> Packages;

	public List<int> ExpirePackage;

	public List<int> ViewPackage;

	public int SeasonInfoIdx { get; private set; }

	public IReactiveProperty<bool> IsStatueActive { get; private set; }

	public IReactiveProperty<bool> IsActivePremiumBuildingSlot { get; private set; }

	public IReactiveProperty<int> MaxTimeToUnlockNextEmployee { get; private set; }

	public IReactiveProperty<bool> IsPremiumPassActive { get; private set; }

	public SeasonalShopData()
	{
	}

	public SeasonalShopData(int seasonInfoIdx)
	{
	}

	public void UpdateData(Treeplla.Data.SeasonalShopData seasonalShopData)
	{
	}

	private void GetPiggyBankLevel()
	{
	}

	public void SetPiggyBankLevel(int value)
	{
	}

	public void SetMaxTimeToUnlockNextEmployee()
	{
	}
}
