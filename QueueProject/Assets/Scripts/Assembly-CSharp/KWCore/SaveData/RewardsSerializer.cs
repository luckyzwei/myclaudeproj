using System;
using System.Collections.Generic;
using Balancy.Models.SmartObjects;

namespace KWCore.SaveData
{
	public class RewardsSerializer
	{
		[Serializable]
		public struct RewardStruct
		{
			public int amount;

			public string clientId;

			public RewardStruct(int amount, string clientId)
			{
				this.amount = 0;
				this.clientId = null;
			}
		}

		public static string Serialize(List<RewardStruct> rewardList)
		{
			return null;
		}

		public static List<RewardStruct> Deserialize(string json)
		{
			return null;
		}

		public static void AddReward(Reward reward)
		{
		}

		private static Reward GetCurrentUnclaimedRewards()
		{
			return null;
		}

		private static void SaveUnclaimedRewards(Reward reward)
		{
		}

		public static void RemoveReward(Reward rewardToRemove)
		{
		}

		public static Reward GetReward()
		{
			return null;
		}

		public static List<ItemWithAmount> MergeItems(IEnumerable<ItemWithAmount> items)
		{
			return null;
		}
	}
}
