using System.Collections.Generic;
using Balancy.Data.SmartObjects;
using Balancy.Models;

public static class BalancySpecialOfferExtensions
{
	public static List<SpecialOfferData> GetActivatedOffers(this IEnumerable<SpecialOfferData> specialOfferData)
	{
		return null;
	}

	public static List<SpecialOfferData> GetAllSpecialOffers(this OfferInfo[] offerInfos)
	{
		return null;
	}

	private static bool TryGetSpecialOffer(this OfferInfo offerInfo, out KwaleeOffer kwaleeOffer)
	{
		kwaleeOffer = null;
		return false;
	}

	private static KwaleeOffer GetKwaleeOffer(this OfferInfo offerInfo)
	{
		return null;
	}
}
