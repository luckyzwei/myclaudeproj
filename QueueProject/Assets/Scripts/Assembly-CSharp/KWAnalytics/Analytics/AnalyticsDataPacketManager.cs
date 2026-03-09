using System.Collections;
using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	public static class AnalyticsDataPacketManager
	{
		private static Dictionary<string, AnalyticsDataPacketBase> s_packets;

		public static T GetPacket<T>() where T : AnalyticsDataPacketBase, new()
		{
			return null;
		}

		public static void ResetPacket<T>() where T : AnalyticsDataPacketBase, new()
		{
		}

		public static Hashtable GetHashTableFromKey(string key)
		{
			return null;
		}

		private static void FillRefHashTable(string key, ref Hashtable hashTable)
		{
		}

		public static Hashtable GetHashTableFromKeys(string[] keys)
		{
			return null;
		}

		public static Hashtable GetFullHashTable()
		{
			return null;
		}
	}
}
