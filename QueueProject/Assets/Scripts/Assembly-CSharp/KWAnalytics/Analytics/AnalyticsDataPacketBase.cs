using System;
using System.Collections;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public abstract class AnalyticsDataPacketBase
	{
		public AnalyticsDataPacketBase()
		{
		}

		public abstract void FillHashTable(ref Hashtable hashTable);

		protected abstract string HashtableKey();

		public abstract void ResetValues();
	}
}
