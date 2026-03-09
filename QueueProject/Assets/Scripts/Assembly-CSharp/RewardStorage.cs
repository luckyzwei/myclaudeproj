using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.SmartObjects;

public static class RewardStorage
{
	public class InternalRewardStorage
	{
		private Dictionary<string, int> m_itemWithAmountDict;

		public Reward GetReward()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void AddItem(KwaleeItem item, int count)
		{
		}

		public void AddItem(string itemClientId, int count)
		{
		}
	}

	private static Dictionary<string, InternalRewardStorage> s_rewardsStorageDict;

	public static Reward GetReward(string storageKey)
	{
		return null;
	}

	public static Reward GetRewardAndFlush(string storageKey)
	{
		return null;
	}

	public static void Flush(string storageKey)
	{
	}

	public static void AddItem(string storageKey, string itemClientId, int count)
	{
	}

	public static void AddItem(string storageKey, KwaleeItem item, int count)
	{
	}

	public static bool Contains(string storageKey)
	{
		return false;
	}
}
