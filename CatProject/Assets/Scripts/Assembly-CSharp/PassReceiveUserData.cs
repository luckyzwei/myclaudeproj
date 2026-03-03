using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class PassReceiveUserData
{
	public List<int> RewardedNormalIdxList;

	public List<int> RewardedPremiumIdxList;

	public int TotalStepCount;

	public bool AddReward(int rewardIdx, bool isPremium)
	{
		return false;
	}

	public bool IsReceived(int rewardIdx, bool isPremium)
	{
		return false;
	}

	public bool IsAllRewarded()
	{
		return false;
	}

	public static PassReceiveUserData FromFlatBuffer(PassReceiveData? data)
	{
		return null;
	}

	public static Offset<PassReceiveData> ToFlatBuffer(FlatBufferBuilder builder, PassReceiveUserData data)
	{
		return default(Offset<PassReceiveData>);
	}
}
