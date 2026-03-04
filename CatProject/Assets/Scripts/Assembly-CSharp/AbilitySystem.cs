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

	private CompositeDisposable disposables;

	public Subject<AbilityType> OnChangeBoosterState;

	public Subject<int> OnUseBooster;

	public void Init()
	{
		AbilityValues = new Dictionary<AbilityType, BigInteger>();
		disposables = new CompositeDisposable();
		OnChangeBoosterState = new Subject<AbilityType>();
		OnUseBooster = new Subject<int>();
		InitBooster();
	}

	private void InitBooster()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public int GetActiveBoosterAbilityValue(AbilityType type, int regionIdx)
	{
		return 0;
	}

	public bool ActivateBooster(int boosterIdx, int regionIdx, bool useTicket)
	{
		return false;
	}

	public bool IsFreeBooster(int boosterIdx)
	{
		return false;
	}

	public bool IsActiveAnyBooster()
	{
		return false;
	}

	public bool IsActiveMoneyBooster(int regionIdx)
	{
		return false;
	}

	public bool IsActiveExpBooster(int regionIdx)
	{
		return false;
	}

	public bool IsActiveBooster(int boosterIdx)
	{
		return false;
	}

	public bool IsActiveBoosterTicket(int itemIdx)
	{
		return false;
	}

	public void UpdateAbility()
	{
	}

	public void UpdateAbility(int type)
	{
	}

	public void UpdateAbility(AbilityType type)
	{
	}

	public BigInteger GetAbilityBuffValue(AbilityType type)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionAbilityBuffValue(int regionIdx, AbilityType type)
	{
		return default(BigInteger);
	}

	public BigInteger GetPlantBuff(AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionBuildingBuff(int regionIdx, AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public BigInteger GetBuffObjectBuff(AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionCarBuff(int regionIdx, AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionCarBrandBuff(int regionIdx, AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public BigInteger GetCeoCostumeBuff(AbilityType abilityType)
	{
		return default(BigInteger);
	}

	public List<BoosterData> GetOfficeBoosterList()
	{
		return null;
	}
}
