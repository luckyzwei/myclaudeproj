using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class IAPFailedSchema : ClosedSchema
	{
		public IAPFailedSchema(string productCode, string error, string currencyCode, float price)
		{
		}
	}
}
