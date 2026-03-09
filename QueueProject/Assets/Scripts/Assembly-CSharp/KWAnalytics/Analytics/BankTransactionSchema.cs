using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class BankTransactionSchema : ClosedSchema
	{
		public BankTransactionSchema(string eventType, int money, long totalMoney, string context = "", string rewardType = "")
		{
		}
	}
}
