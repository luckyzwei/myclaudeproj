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
	}

	public void AddAccumulateRegionMoney_Per(int regionIdx, BigInteger rewardValue)
	{
	}

	public bool IsExistAccumulateRegionMoney_Per(int regionIdx)
	{
		return false;
	}

	public int GetPassGroupIdx()
	{
		return 0;
	}

	public bool IsAllPassReceived()
	{
		return false;
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
