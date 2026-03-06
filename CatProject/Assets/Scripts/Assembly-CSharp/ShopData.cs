using System;
using System.Collections.Generic;

public class ShopData : IClientData
{
	public List<PackageData> Packages;

	public List<SpecialPackageData> SpecialPackages;

	public Dictionary<int, DateTime> FreeTimes;

	public Dictionary<int, CycleLimitedShopGoodsData> CycleLimitedShopGoodsMap;

	public List<int> ExpirePackage;

	public int PiggyValue;

	public int PiggyLevel;

	public List<int> ReceivePiggyReward;

	public Dictionary<int, ShopSaleItemUserData> ShopSaleItemMap;

	public Dictionary<int, EndlessOfferUserData> EndlessOfferMap;

	public DateTime NoAdsSaleEndTime;

	public DateTime PlayerLvPassSaleEndTime;

	public void Create()
	{
		// TODO
	}
}
