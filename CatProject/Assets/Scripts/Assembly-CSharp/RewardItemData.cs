using System.Numerics;

public class RewardItemData : IRewardItemData
{
	public int rewardType;

	public int rewardIdx;

	public BigInteger rewardValue;

	public int rewardRegion;

	public string resImg;

	public Config.AtlasType atlasType;

	public bool isTimeRevenue;

	public bool IsSpecialReward;

	public RewardItemData(int _type, int _idx, BigInteger _count, int region = -1, string res = "", Config.AtlasType atlas = Config.AtlasType.None, bool bTimeRevenue = true)
	{
		rewardType = _type;
		rewardIdx = _idx;
		rewardValue = _count;
		rewardRegion = region;
		resImg = res;
		atlasType = atlas;
		isTimeRevenue = bTimeRevenue;
	}

	public bool IsSameReward(IRewardItemData other)
	{
		if (other is RewardItemData otherReward)
		{
			return rewardType == otherReward.rewardType && rewardIdx == otherReward.rewardIdx;
		}
		return false;
	}

	public bool IsSameReward(int type, int idx)
	{
		return rewardType == type && rewardIdx == idx;
	}

	public bool IsSameReward(int type, int idx, int region)
	{
		return rewardType == type && rewardIdx == idx && rewardRegion == region;
	}

	public bool IsCompanyExpReward()
	{
		return rewardType == (int)Config.RewardType.Exp;
	}

	public bool EnableReward()
	{
		return rewardValue > 0;
	}
}
