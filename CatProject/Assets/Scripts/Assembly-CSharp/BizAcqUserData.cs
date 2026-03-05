using System;
using System.Collections.Generic;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;

public class BizAcqUserData
{
	public DateTime LastRewardAccumulateTime;

	public int CurrentStageIdx { get; set; }

	public DateTime AutoPlayGuideShownTime { get; set; }

	public BizAcqTeamUserData TeamData { get; set; }

	public DateTime LastRewardGetTime { get; set; }

	public DateTime LastStageClearTime { get; set; }

	public int LastClearStageIdx { get; set; }

	public List<CurrencyUserData> AccumulateRewards { get; set; }

	public BigInteger AccumulateReinforceStone_Per { get; set; }

	public int MultipleRewardGetCount { get; set; }

	public DateTime MultipleRewardLastGetTime { get; set; }

	public DateTime WeeklyShopShownTime { get; set; }

	public List<PassReceiveUserData> PassReceiveData { get; set; }

	public bool AutoPlayOn { get; set; }

	public int BattleSpeedIndex { get; set; }

	public bool ActiveSpeedTrial { get; set; }

	public JewelryBoxUserData JewelryBoxData { get; set; }

	public void AddAccumulateReinforceStone_Per(BigInteger rewardValue)
	{
		AccumulateReinforceStone_Per += rewardValue;
	}

	public void AddAccumulateRegionMoney_Per(int regionIdx, BigInteger rewardValue)
	{
		if (AccumulateRewards == null)
			AccumulateRewards = new List<CurrencyUserData>();

		for (int i = 0; i < AccumulateRewards.Count; i++)
		{
			if (AccumulateRewards[i] != null && (int)AccumulateRewards[i].CurrencyId == regionIdx)
			{
				AccumulateRewards[i].Value += rewardValue;
				return;
			}
		}

		var newData = new CurrencyUserData();
		newData.CurrencyId = (Config.CurrencyID)regionIdx;
		newData.Value = rewardValue;
		AccumulateRewards.Add(newData);
	}

	public bool IsExistAccumulateRegionMoney_Per(int regionIdx)
	{
		if (AccumulateRewards == null) return false;
		for (int i = 0; i < AccumulateRewards.Count; i++)
		{
			if (AccumulateRewards[i] != null && (int)AccumulateRewards[i].CurrencyId == regionIdx)
				return true;
		}
		return false;
	}

	public int GetPassGroupIdx()
	{
		return CurrentStageIdx / 10;
	}

	public bool IsAllPassReceived()
	{
		if (PassReceiveData == null || PassReceiveData.Count == 0) return false;
		for (int i = 0; i < PassReceiveData.Count; i++)
		{
			if (PassReceiveData[i] == null || !PassReceiveData[i].IsAllRewarded())
				return false;
		}
		return true;
	}

	public static BizAcqUserData FromFlatBuffer(BizAcqData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new BizAcqUserData();
		return result;
	}

	public static Offset<BizAcqData> ToFlatBuffer(FlatBufferBuilder builder, BizAcqUserData data)
	{
		return default(Offset<BizAcqData>);
	}
}
