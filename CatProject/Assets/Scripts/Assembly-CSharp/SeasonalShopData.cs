using System;
using System.Collections.Generic;
using Treeplla.Data;
using UniRx;
using UnityEngine;

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
		Packages = new List<PackageData>();
		ExpirePackage = new List<int>();
		ViewPackage = new List<int>();
		IsStatueActive = new ReactiveProperty<bool>(false);
		IsActivePremiumBuildingSlot = new ReactiveProperty<bool>(false);
		MaxTimeToUnlockNextEmployee = new ReactiveProperty<int>(0);
		IsPremiumPassActive = new ReactiveProperty<bool>(false);
	}

	public SeasonalShopData(int seasonInfoIdx) : this()
	{
		SeasonInfoIdx = seasonInfoIdx;
	}

	public void UpdateData(Treeplla.Data.SeasonalShopData seasonalShopData)
	{
		SeasonInfoIdx = seasonalShopData.Seasoninfoidx;
		StatueSlotCount = seasonalShopData.Statueslotcount;
		StatueBuyTime = new DateTime(seasonalShopData.Statuebuytime);
		CoinBankValue = seasonalShopData.Piggyvalue;
		IsStatueActive.Value = seasonalShopData.Statueactive;
		IsActivePremiumBuildingSlot.Value = seasonalShopData.Buildingslotactive;
		IsPremiumPassActive.Value = seasonalShopData.Premiumpassactive;

		Packages.Clear();
		for (int i = 0; i < seasonalShopData.PackagesLength; i++)
		{
			var pkg = seasonalShopData.Packages(i);
			if (pkg.HasValue)
				Packages.Add(new PackageData(pkg.Value.Idx, pkg.Value.Endtime, pkg.Value.Buycount));
		}
		ExpirePackage.Clear();
		for (int i = 0; i < seasonalShopData.ExpirepackageLength; i++)
			ExpirePackage.Add(seasonalShopData.Expirepackage(i));
		ViewPackage.Clear();
		for (int i = 0; i < seasonalShopData.ViewpackageLength; i++)
			ViewPackage.Add(seasonalShopData.Viewpackage(i));
	}

	private void GetPiggyBankLevel()
	{
		CoinBankLevel = Mathf.Max(CoinBankLevel, 1);
	}

	public void SetPiggyBankLevel(int value)
	{
		CoinBankLevel = value;
	}

	public void SetMaxTimeToUnlockNextEmployee()
	{
		MaxTimeToUnlockNextEmployee.Value = 0;
	}
}
