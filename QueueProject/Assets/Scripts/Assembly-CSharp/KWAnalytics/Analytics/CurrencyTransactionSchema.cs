using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class CurrencyTransactionSchema : ClosedSchema
	{
		public enum CurrencyType
		{
			SOFT = 0,
			HARD = 1
		}

		public CurrencyTransactionSchema(CurrencyType currencyType, string currencyCode, long currencyValue, long newBalance, string description)
		{
		}
	}
}
