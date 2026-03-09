using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class IAPCompleteSchema : ClosedSchema
	{
		public IAPCompleteSchema(string productCode, bool kangaVerification, string currencyCode, float price, bool isRestore, bool isSandbox = false)
		{
		}
	}
}
