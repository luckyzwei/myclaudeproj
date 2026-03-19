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
		if (isPremium)
		{
			if (RewardedPremiumIdxList == null)
				RewardedPremiumIdxList = new List<int>();
			if (RewardedPremiumIdxList.Contains(rewardIdx))
				return false;
			RewardedPremiumIdxList.Add(rewardIdx);
		}
		else
		{
			if (RewardedNormalIdxList == null)
				RewardedNormalIdxList = new List<int>();
			if (RewardedNormalIdxList.Contains(rewardIdx))
				return false;
			RewardedNormalIdxList.Add(rewardIdx);
		}
		return true;
	}

	public bool IsReceived(int rewardIdx, bool isPremium)
	{
		if (isPremium)
			return RewardedPremiumIdxList != null && RewardedPremiumIdxList.Contains(rewardIdx);
		return RewardedNormalIdxList != null && RewardedNormalIdxList.Contains(rewardIdx);
	}

	public bool IsAllRewarded()
	{
		if (TotalStepCount <= 0) return false;
		int normalCount = RewardedNormalIdxList != null ? RewardedNormalIdxList.Count : 0;
		return normalCount >= TotalStepCount;
	}

	public static PassReceiveUserData FromFlatBuffer(PassReceiveData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new PassReceiveUserData();
		result.RewardedNormalIdxList = new List<int>();
		for (int i = 0; i < d.NormalLength; i++)
			result.RewardedNormalIdxList.Add(d.Normal(i));
		result.RewardedPremiumIdxList = new List<int>();
		for (int i = 0; i < d.PremiumLength; i++)
			result.RewardedPremiumIdxList.Add(d.Premium(i));
		return result;
	}

	public static Offset<PassReceiveData> ToFlatBuffer(FlatBufferBuilder builder, PassReceiveUserData data)
	{
		if (data == null) return default(Offset<PassReceiveData>);
		VectorOffset normalOffset = default(VectorOffset);
		if (data.RewardedNormalIdxList != null && data.RewardedNormalIdxList.Count > 0)
			normalOffset = PassReceiveData.CreateNormalVector(builder, data.RewardedNormalIdxList.ToArray());
		VectorOffset premiumOffset = default(VectorOffset);
		if (data.RewardedPremiumIdxList != null && data.RewardedPremiumIdxList.Count > 0)
			premiumOffset = PassReceiveData.CreatePremiumVector(builder, data.RewardedPremiumIdxList.ToArray());
		return PassReceiveData.CreatePassReceiveData(builder, normalOffset, premiumOffset);
	}
}
