using System;
using System.Collections.Generic;
using System.Numerics;
using UniRx;

public class StageData : IClientData
{
	public Dictionary<int, OfficeData> Offices;

	public IReactiveCollection<int> UnLockCompanyList;

	public List<int> CompanyList;

	public int RecommendCompanyIdx;

	public IReactiveCollection<CompanyData> Companies;

	public MissionData[] Missions;

	public RegionMissionData RegionMissionData;

	public MoneySafeData MoneySafeData;

	public IReactiveProperty<BigInteger> Money { get; set; }

	public IReactiveProperty<int> Power { get; set; }

	public IReactiveProperty<int> Point { get; set; }

	public int StageIdx { get; private set; }

	public InvestData InvestData { get; set; }

	public List<InvestData> AbilityInvestData { get; set; }

	public DateTime StageStartTime
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public long StagePlayTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public long MainStagePlayTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public void Init(int idx)
	{
	}

	public void UpgradeStageIdx()
	{
	}

	public void SetStageIdx(int idx)
	{
	}
}
