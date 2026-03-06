using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UniRx;

public class AbilitySystem
{
	public enum AbilityType
	{
		EmployeeMoodUp = 1,
		OfflineTime = 2,
		AddReward = 3,
		DirectGivePower = 4,
		AddGem = 5,
		CompanyExpUp = 6,
		AddRewardPer10sec = 7,
		AddInfraRevenue = 8,
		DecreaseUpgradePrice = 9,
		CompanyExpPerUp = 10,
		OfflineValueMulti = 11,
		RentalFeeGetTime = 12,
		AddRewardPer10sec_CeoRoom = 13,
		RouletteAddFreeCnt = 10001,
		RouletteExpenseDec = 10002,
		RouletteLuckyDrawDec = 10003,
		VipBankReceiveCnt = 10101,
		VipBankSaveMaxCnt = 10102,
		VipBankRewardInc = 10103,
		WorldMapBankCoolTimeDec = 10201,
		WorldMapRewardCollect = 10202,
		WorldMapCarHouseExpenseDec = 10203,
		InvestRewardAdd = 10301,
		InvestRewardAddCnt = 10302,
		InvestCooltimeDec = 10303,
		Max = 10304
	}

	private Dictionary<AbilityType, BigInteger> AbilityValues;

	private Dictionary<int, bool> ActiveBoosters;

	private CompositeDisposable disposables;

	public Subject<AbilityType> OnChangeBoosterState;

	public Subject<int> OnUseBooster;

	public void Init()
	{
		AbilityValues = new Dictionary<AbilityType, BigInteger>();
		ActiveBoosters = new Dictionary<int, bool>();
		disposables = new CompositeDisposable();
		OnChangeBoosterState = new Subject<AbilityType>();
		OnUseBooster = new Subject<int>();
		InitBooster();
	}

	private void InitBooster()
	{
		// TODO
	}

	public void UpdateOneSeconds()
	{
		// Update display
	}

	public int GetActiveBoosterAbilityValue(AbilityType type, int regionIdx)
	{
		return 0;
	}

	public bool ActivateBooster(int boosterIdx, int regionIdx, bool useTicket)
	{
		if (ActiveBoosters == null) return false;
		ActiveBoosters[boosterIdx] = true;
		OnUseBooster.OnNext(boosterIdx);
		return true;
	}

	public bool IsFreeBooster(int boosterIdx)
	{
		return false;
	}

	public bool IsActiveAnyBooster()
	{
		if (ActiveBoosters == null) return false;
		foreach (var kvp in ActiveBoosters)
		{
			if (kvp.Value) return true;
		}
		return false;
	}

	public bool IsActiveMoneyBooster(int regionIdx)
	{
		return IsActiveAnyBooster();
	}

	public bool IsActiveExpBooster(int regionIdx)
	{
		return false;
	}

	public bool IsActiveBooster(int boosterIdx)
	{
		if (ActiveBoosters != null && ActiveBoosters.TryGetValue(boosterIdx, out bool active))
			return active;
		return false;
	}

	public bool IsActiveBoosterTicket(int itemIdx)
	{
		return false;
	}

	public void UpdateAbility()
	{
		if (AbilityValues == null) return;
	}

	public void UpdateAbility(int type)
	{
		UpdateAbility((AbilityType)type);
	}

	public void UpdateAbility(AbilityType type)
	{
		if (AbilityValues == null) return;

		BigInteger total = BigInteger.Zero;
		total += GetPlantBuff(type);
		total += GetBuffObjectBuff(type);
		total += GetCeoCostumeBuff(type);

		AbilityValues[type] = total;
		OnChangeBoosterState.OnNext(type);
	}

	public BigInteger GetAbilityBuffValue(AbilityType type)
	{
		if (AbilityValues != null && AbilityValues.TryGetValue(type, out BigInteger value))
			return value;
		return BigInteger.Zero;
	}

	public BigInteger GetRegionAbilityBuffValue(int regionIdx, AbilityType type)
	{
		BigInteger total = GetAbilityBuffValue(type);
		total += GetRegionBuildingBuff(regionIdx, type);
		total += GetRegionCarBuff(regionIdx, type);
		total += GetRegionCarBrandBuff(regionIdx, type);
		return total;
	}

	public BigInteger GetPlantBuff(AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public BigInteger GetRegionBuildingBuff(int regionIdx, AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public BigInteger GetBuffObjectBuff(AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public BigInteger GetRegionCarBuff(int regionIdx, AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public BigInteger GetRegionCarBrandBuff(int regionIdx, AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public BigInteger GetCeoCostumeBuff(AbilityType abilityType)
	{
		return BigInteger.Zero;
	}

	public List<BoosterData> GetOfficeBoosterList()
	{
		return new List<BoosterData>();
	}
}
