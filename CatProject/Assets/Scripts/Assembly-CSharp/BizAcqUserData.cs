using System;
using System.Collections.Generic;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

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

	private static DateTime LongToDateTime(long timestamp)
	{
		if (timestamp == 0) return DateTime.MinValue;
		return DateTimeOffset.FromUnixTimeSeconds(timestamp).UtcDateTime;
	}

	private static long DateTimeToLong(DateTime dt)
	{
		if (dt == DateTime.MinValue) return 0;
		return new DateTimeOffset(dt).ToUnixTimeSeconds();
	}

	public static BizAcqUserData FromFlatBuffer(BizAcqData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new BizAcqUserData();
		result.CurrentStageIdx = d.Curstageidx;
		result.LastRewardGetTime = LongToDateTime(d.Lastrewardgettime);
		result.LastStageClearTime = LongToDateTime(d.Laststagecleartime);
		result.AutoPlayGuideShownTime = LongToDateTime(d.Autoplayguideshowntime);
		result.MultipleRewardGetCount = d.Multiplerewardgetcount;
		result.MultipleRewardLastGetTime = LongToDateTime(d.Multiplerewardlastgettime);
		result.AutoPlayOn = d.Autoplayon;
		result.BattleSpeedIndex = d.Battlespeedindex;
		result.LastRewardAccumulateTime = LongToDateTime(d.Lastrewardaccumulatetime);
		result.WeeklyShopShownTime = LongToDateTime(d.Weeklyshopshowntime);
		result.ActiveSpeedTrial = d.Activespeedtrial;

		// Accumulate reinforce stone (BigInteger stored as string)
		if (!string.IsNullOrEmpty(d.Accumulatereinstone))
		{
			if (BigInteger.TryParse(d.Accumulatereinstone, out var reinStone))
				result.AccumulateReinforceStone_Per = reinStone;
		}

		// Accumulate rewards
		result.AccumulateRewards = new List<CurrencyUserData>();
		for (int i = 0; i < d.AccumulaterewardsLength; i++)
		{
			var rewardData = d.Accumulaterewards(i);
			if (rewardData.HasValue)
				result.AccumulateRewards.Add(CurrencyUserData.FromFlatBuffer(rewardData.Value));
		}

		// Team data
		result.TeamData = new BizAcqTeamUserData();
		result.TeamData.FromFlatBuffer(d.Teamdata);

		// Pass receive data
		result.PassReceiveData = new List<PassReceiveUserData>();
		for (int i = 0; i < d.PassreceiveLength; i++)
		{
			var passData = PassReceiveUserData.FromFlatBuffer(d.Passreceive(i));
			if (passData != null)
				result.PassReceiveData.Add(passData);
		}

		// Jewelry box data
		result.JewelryBoxData = new JewelryBoxUserData();
		result.JewelryBoxData.Level = new ReactiveProperty<int>(d.Jewelryboxlevel);
		result.JewelryBoxData.StageStep = d.Jewelryboxstagestep;
		result.JewelryBoxData.StageLastShownStep = d.Jewelryboxstagelastshownstep;
		if (!string.IsNullOrEmpty(d.Jewelryboxvalue))
		{
			BigInteger.TryParse(d.Jewelryboxvalue, out var jbValue);
			result.JewelryBoxData.AccumulateValue = jbValue;
		}

		return result;
	}

	public static Offset<BizAcqData> ToFlatBuffer(FlatBufferBuilder builder, BizAcqUserData data)
	{
		if (data == null) return default(Offset<BizAcqData>);

		var teamOffset = BizAcqTeamUserData.ToFlatBuffer(builder, data.TeamData);
		var rewardsOffset = CurrencyUserData.ToFlatBufferVector(builder, data.AccumulateRewards);

		// Pass receive
		VectorOffset passOffset = default(VectorOffset);
		if (data.PassReceiveData != null && data.PassReceiveData.Count > 0)
		{
			var passOffsets = new Offset<Treeplla.Data.PassReceiveData>[data.PassReceiveData.Count];
			for (int i = 0; i < data.PassReceiveData.Count; i++)
				passOffsets[i] = PassReceiveUserData.ToFlatBuffer(builder, data.PassReceiveData[i]);
			passOffset = builder.CreateVectorOfTables(passOffsets);
		}

		var reinStoneOffset = builder.CreateString(data.AccumulateReinforceStone_Per.ToString());
		var jbValueOffset = builder.CreateString(
			data.JewelryBoxData != null ? data.JewelryBoxData.AccumulateValue.ToString() : "0");

		return BizAcqData.CreateBizAcqData(
			builder,
			data.CurrentStageIdx,
			teamOffset,
			DateTimeToLong(data.LastRewardGetTime),
			DateTimeToLong(data.LastStageClearTime),
			rewardsOffset,
			DateTimeToLong(data.AutoPlayGuideShownTime),
			data.MultipleRewardGetCount,
			DateTimeToLong(data.MultipleRewardLastGetTime),
			passOffset,
			data.AutoPlayOn,
			data.BattleSpeedIndex,
			reinStoneOffset,
			DateTimeToLong(data.LastRewardAccumulateTime),
			DateTimeToLong(data.WeeklyShopShownTime),
			jbValueOffset,
			data.JewelryBoxData != null && data.JewelryBoxData.Level != null ? data.JewelryBoxData.Level.Value : 1,
			data.JewelryBoxData != null ? data.JewelryBoxData.StageStep : 0,
			data.JewelryBoxData != null ? data.JewelryBoxData.StageLastShownStep : 0,
			data.ActiveSpeedTrial
		);
	}
}
