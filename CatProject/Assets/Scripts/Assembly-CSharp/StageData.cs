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

	private DateTime _stageStartTime;
	private long _stagePlayTime;
	private long _mainStagePlayTime;

	public DateTime StageStartTime
	{
		get { return _stageStartTime; }
		set { _stageStartTime = value; }
	}

	public long StagePlayTime
	{
		get { return _stagePlayTime; }
		set { _stagePlayTime = value; }
	}

	public long MainStagePlayTime
	{
		get { return _mainStagePlayTime; }
		set { _mainStagePlayTime = value; }
	}

	public void Init(int idx)
	{
		StageIdx = idx;
		Money = new ReactiveProperty<BigInteger>(BigInteger.Zero);
		Power = new ReactiveProperty<int>(0);
		Point = new ReactiveProperty<int>(0);
		Offices = new Dictionary<int, OfficeData>();
		UnLockCompanyList = new ReactiveCollection<int>();
		CompanyList = new List<int>();
		Companies = new ReactiveCollection<CompanyData>();
		AbilityInvestData = new List<InvestData>();
		_stageStartTime = DateTime.UtcNow;
		_stagePlayTime = 0L;
		_mainStagePlayTime = 0L;
	}

	public void UpgradeStageIdx()
	{
		StageIdx++;
	}

	public void SetStageIdx(int idx)
	{
		StageIdx = idx;
	}
}
