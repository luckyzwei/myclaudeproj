using System;

namespace KWFirebase
{
	public interface IProductPurchaser
	{
		void PurchaseProduct(string productId, Action<PurchaseResult> callback);
	}
}
