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
	}

	public bool IsSameReward(IRewardItemData other)
	{
		return false;
	}

	public bool IsSameReward(int type, int idx)
	{
		return false;
	}

	public bool IsSameReward(int type, int idx, int region)
	{
		return false;
	}

	public bool IsCompanyExpReward()
	{
		return false;
	}

	public bool EnableReward()
	{
		return false;
	}
}
