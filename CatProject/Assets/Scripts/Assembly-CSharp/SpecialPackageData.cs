using System;
using System.Collections.Generic;

public class SpecialPackageData : IReadOnlyData, ICloneable
{
	public int Idx;

	public bool Expire;

	public List<int> Param;

	public bool Purchase;

	public DateTime LimitTime;

	public Dictionary<Config.E_PackageOfferType, DateTime> OfferTimeMap;

	public SpecialPackageData(int idx, bool expire = false, DateTime limitTime = default(DateTime))
	{
	}

	public void Create()
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public void BuyPackage()
	{
	}

	public void ExpirePackage()
	{
	}

	public bool IsOfferTime(Config.E_PackageOfferType offerType, bool emptyIsTrue)
	{
		return false;
	}

	public void UpdateOfferTime(Config.E_PackageOfferType offerType)
	{
	}
}
