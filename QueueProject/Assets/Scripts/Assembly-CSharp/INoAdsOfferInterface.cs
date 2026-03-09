using System;
using Balancy;
using Balancy.Models.Store;

public interface INoAdsOfferInterface
{
	string GetPrefabPath();

	void Config(UnnyProduct originalProduct, Product discountedProduct, Action callback);
}
