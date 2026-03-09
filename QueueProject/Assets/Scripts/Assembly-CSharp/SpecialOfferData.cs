using Balancy.Data.SmartObjects;
using Balancy.Models;

public class SpecialOfferData
{
	public OfferInfo offerInfo;

	public KwaleeOffer kwaleeOffer;

	public bool IsActive => false;

	public SpecialOfferData(OfferInfo info, KwaleeOffer offer)
	{
	}
}
