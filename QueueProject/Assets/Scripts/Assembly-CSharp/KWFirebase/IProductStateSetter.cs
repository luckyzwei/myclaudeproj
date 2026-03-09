using UnityEngine.Purchasing;

namespace KWFirebase
{
	internal interface IProductStateSetter
	{
		void UpdateFromCache(ProductInfo cachedProduct);

		void SetPurchaser(IProductPurchaser purchaser);

		void SetOwnership(bool value);

		void SetValidation(bool value);

		void SetQuantity(int quantity);

		void SetExpireDuration(long duration);

		void SetProduct(Product product);
	}
}
