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
		Idx = idx;
		Expire = expire;
		LimitTime = limitTime;
	}

	public void Create()
	{
		Param = new List<int>();
		OfferTimeMap = new Dictionary<Config.E_PackageOfferType, DateTime>();
		Purchase = false;
	}

	public virtual object Clone()
	{
		SpecialPackageData clone = (SpecialPackageData)MemberwiseClone();
		clone.Create();
		return clone;
	}

	public void BuyPackage()
	{
		Purchase = true;
	}

	public void ExpirePackage()
	{
		Expire = true;
	}

	public bool IsOfferTime(Config.E_PackageOfferType offerType, bool emptyIsTrue)
	{
		if (OfferTimeMap == null || !OfferTimeMap.ContainsKey(offerType))
			return emptyIsTrue;
		return DateTime.UtcNow < OfferTimeMap[offerType];
	}

	public void UpdateOfferTime(Config.E_PackageOfferType offerType)
	{
		if (OfferTimeMap == null)
			OfferTimeMap = new Dictionary<Config.E_PackageOfferType, DateTime>();
		OfferTimeMap[offerType] = DateTime.UtcNow;
	}
}
