using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UniRx;

public class RentalFeeSystem
{
	public IReactiveProperty<BigInteger> RuntimeRentalFeeValue;

	public IReactiveProperty<BigInteger> RentalFeeValue;

	private CompositeDisposable disposables;

	private CompositeDisposable companyDisposables;

	public IReactiveProperty<int> RunTimeGetMoneyTime;

	private float DeltaTime;

	private Config.CurrencyID RentalFeeIdx;

	private Dictionary<int, BigInteger> OtherRegionRentalFee;

	public readonly int REVENUE_GRAPH_CYCLE_COUNT;

	private float RevenueGraph_ElapsedTime;

	public Subject<bool> OnChangeRevenueGraph;

	public int get_money_time { get; private set; }

	public int require_item_decrement { get; private set; }

	public int REVENUE_GRAPH_CHANGE_CYCLE { get; private set; }

	public List<BigInteger> RevenueGraphValues { get; private set; }

	public void Init()
	{
		disposables = new CompositeDisposable();
		companyDisposables = new CompositeDisposable();
		RuntimeRentalFeeValue = new ReactiveProperty<BigInteger>(BigInteger.Zero);
		RentalFeeValue = new ReactiveProperty<BigInteger>(BigInteger.Zero);
		RunTimeGetMoneyTime = new ReactiveProperty<int>(0);
		RentalFeeIdx = Config.CurrencyID.Gold;
		OtherRegionRentalFee = new Dictionary<int, BigInteger>();
		OnChangeRevenueGraph = new Subject<bool>();
		RevenueGraphValues = new List<BigInteger>();
		DeltaTime = 0f;
		RevenueGraph_ElapsedTime = 0f;

		get_money_time = 10;
		require_item_decrement = 50;
		REVENUE_GRAPH_CHANGE_CYCLE = 5;

		CalculateRentalFee();
	}

	private void UpdateRevenueGraph(BigInteger nowRentalFeeValue, int nowRentalFeeGetTime, float deltaTime)
	{
		RevenueGraph_ElapsedTime += deltaTime;
		if (RevenueGraph_ElapsedTime >= REVENUE_GRAPH_CHANGE_CYCLE)
		{
			RevenueGraph_ElapsedTime -= REVENUE_GRAPH_CHANGE_CYCLE;
			if (RevenueGraphValues == null)
				RevenueGraphValues = new List<BigInteger>();

			RevenueGraphValues.Add(nowRentalFeeValue);
			if (RevenueGraphValues.Count > REVENUE_GRAPH_CYCLE_COUNT)
				RevenueGraphValues.RemoveAt(0);

			if (OnChangeRevenueGraph != null)
				OnChangeRevenueGraph.OnNext(true);
		}
	}

	public void CalculateRentalFee()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null) return;

		BigInteger totalFee = CalculateActiveRegionRentalFee(false);
		RentalFeeValue.Value = totalFee;

		int baseTime = get_money_time;
		int buffValue = gameRoot.AbilitySystem != null
			? gameRoot.AbilitySystem.GetActiveBoosterAbilityValue(AbilitySystem.AbilityType.RentalFeeGetTime, mainData.ActiveRegion)
			: 0;
		int effectiveTime = baseTime;
		if (buffValue > 0)
			effectiveTime = System.Math.Max(1, baseTime - buffValue);

		RunTimeGetMoneyTime.Value = effectiveTime;
	}

	public void UpdateRunTimeRentalFeeGetTime()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.AbilitySystem == null) return;

		var mainData = gameRoot.UserData?.mainData;
		if (mainData == null) return;

		int baseTime = get_money_time;
		int buffValue = gameRoot.AbilitySystem.GetActiveBoosterAbilityValue(
			AbilitySystem.AbilityType.RentalFeeGetTime, mainData.ActiveRegion);
		int effectiveTime = baseTime;
		if (buffValue > 0)
			effectiveTime = System.Math.Max(1, baseTime - buffValue);

		RunTimeGetMoneyTime.Value = effectiveTime;
	}

	public void CalculateRentalFeeAll()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null || mainData.RegionDatas == null) return;

		OtherRegionRentalFee.Clear();
		foreach (var kvp in mainData.RegionDatas)
		{
			int region = kvp.Key;
			BigInteger regionFee = CalculateStageRentalFee(region, false);
			OtherRegionRentalFee[region] = regionFee;
		}

		CalculateRentalFee();
	}

	public BigInteger CalculateActiveRegionRentalFee(bool containStrike = false)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return BigInteger.Zero;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null) return BigInteger.Zero;

		return CalculateStageRentalFee(mainData.ActiveRegion, containStrike);
	}

	public BigInteger CalculateStageRentalFee(int region, bool containStrike = false)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return BigInteger.Zero;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null || mainData.RegionDatas == null) return BigInteger.Zero;

		RegionData regionData;
		if (!mainData.RegionDatas.TryGetValue(region, out regionData) || regionData == null)
			return BigInteger.Zero;

		var stageData = regionData.StageData;
		if (stageData == null || stageData.Offices == null)
			return BigInteger.Zero;

		BigInteger total = BigInteger.Zero;
		foreach (var kvp in stageData.Offices)
		{
			var officeData = kvp.Value;
			if (officeData == null || !officeData.IsOpen.Value)
				continue;

			total += GetOfficeRentalFee(region, kvp.Key, officeData, containStrike);
		}

		if (gameRoot.AbilitySystem != null)
		{
			BigInteger buff = gameRoot.AbilitySystem.GetAbilityBuffValue(AbilitySystem.AbilityType.AddReward);
			if (buff > 0)
				total = total * (100 + buff) / 100;
		}

		return total;
	}

	public BigInteger GetRegionRentalFee(int region)
	{
		BigInteger fee;
		if (OtherRegionRentalFee != null && OtherRegionRentalFee.TryGetValue(region, out fee))
			return fee;

		return CalculateStageRentalFee(region, false);
	}

	public BigInteger GetRegionIncomePerSecond(int region)
	{
		BigInteger totalFee = GetRegionRentalFee(region);
		int time = RunTimeGetMoneyTime != null ? RunTimeGetMoneyTime.Value : get_money_time;
		if (time <= 0) time = 1;
		return totalFee / time;
	}

	public BigInteger GetRuntimeRentalFee()
	{
		return RuntimeRentalFeeValue != null ? RuntimeRentalFeeValue.Value : BigInteger.Zero;
	}

	public BigInteger GetOfficeRentalFee(int region, int officeKey, OfficeData officeData, bool containStrike = false)
	{
		BigInteger exceptManagerBuff;
		return GetOfficeRentalFee(region, officeKey, officeData, containStrike, out exceptManagerBuff);
	}

	public BigInteger GetOfficeRentalFee(int region, int officeKey, OfficeData officeData, bool containStrike, out BigInteger exceptManagerBuff)
	{
		exceptManagerBuff = BigInteger.Zero;

		if (officeData == null || !officeData.IsOpen.Value)
			return BigInteger.Zero;

		int companyIdx = officeData.CompanyIdx != null ? officeData.CompanyIdx.Value : 0;
		if (companyIdx <= 0)
			return BigInteger.Zero;

		if (!containStrike && officeData.EnableStrike != null && officeData.EnableStrike.Value)
			return BigInteger.Zero;

		BigInteger baseFee = CalculateCompanyRentalFee(region, officeKey, companyIdx);
		exceptManagerBuff = baseFee;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot != null && gameRoot.ManagerCardSystem != null)
		{
			int managerIdx = officeData.Manager != null ? officeData.Manager.Value : 0;
			if (managerIdx > 0)
			{
				baseFee = gameRoot.ManagerCardSystem.CalculateManagerAddRewardBuff(baseFee, managerIdx);
			}
		}

		return baseFee;
	}

	private BigInteger CalculateCompanyRentalFee(int region, int officeKey, int companyIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return BigInteger.Zero;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null || mainData.RegionDatas == null) return BigInteger.Zero;

		RegionData regionData;
		if (!mainData.RegionDatas.TryGetValue(region, out regionData) || regionData == null)
			return BigInteger.Zero;

		var stageData = regionData.StageData;
		if (stageData == null || stageData.Offices == null) return BigInteger.Zero;

		OfficeData officeData;
		if (!stageData.Offices.TryGetValue(officeKey, out officeData) || officeData == null)
			return BigInteger.Zero;

		return officeData.RentalFee;
	}

	public bool isEnoughRequireItem(int region, int office)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return true;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null || mainData.RegionDatas == null) return true;

		RegionData regionData;
		if (!mainData.RegionDatas.TryGetValue(region, out regionData) || regionData == null)
			return true;

		var stageData = regionData.StageData;
		if (stageData == null || stageData.Offices == null) return true;

		OfficeData officeData;
		if (!stageData.Offices.TryGetValue(office, out officeData) || officeData == null)
			return true;

		if (officeData.Items == null || officeData.Items.Count == 0)
			return false;

		return true;
	}

	public bool isEnoughRequireItem(int office, int seat, out int randdissatisfyItem, out bool isdeskenough)
	{
		randdissatisfyItem = -1;
		isdeskenough = true;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return true;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null) return true;

		int region = mainData.ActiveRegion;
		var stageData = mainData.StageData;
		if (stageData == null || stageData.Offices == null) return true;

		OfficeData officeData;
		if (!stageData.Offices.TryGetValue(office, out officeData) || officeData == null)
			return true;

		if (officeData.Items == null || officeData.Items.Count == 0)
		{
			isdeskenough = false;
			return false;
		}

		bool allEnough = true;
		for (int i = 0; i < officeData.Items.Count; i++)
		{
			var item = officeData.Items[i];
			if (item == null || item.Level <= 0)
			{
				allEnough = false;
				randdissatisfyItem = i;
				if (item != null && item.Type == 0) // desk type
					isdeskenough = false;
			}
		}

		return allEnough;
	}

	public BigInteger CalculateStrikeRentalFee(int region)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return BigInteger.Zero;

		var mainData = gameRoot.UserData.mainData;
		if (mainData == null || mainData.RegionDatas == null) return BigInteger.Zero;

		RegionData regionData;
		if (!mainData.RegionDatas.TryGetValue(region, out regionData) || regionData == null)
			return BigInteger.Zero;

		var stageData = regionData.StageData;
		if (stageData == null || stageData.Offices == null) return BigInteger.Zero;

		BigInteger strikeLoss = BigInteger.Zero;
		foreach (var kvp in stageData.Offices)
		{
			var officeData = kvp.Value;
			if (officeData == null || !officeData.IsOpen.Value)
				continue;

			if (officeData.EnableStrike != null && officeData.EnableStrike.Value)
			{
				int companyIdx = officeData.CompanyIdx != null ? officeData.CompanyIdx.Value : 0;
				if (companyIdx > 0)
					strikeLoss += CalculateCompanyRentalFee(region, kvp.Key, companyIdx);
			}
		}

		return strikeLoss;
	}

	public void Update()
	{
		float dt = UnityEngine.Time.deltaTime;
		DeltaTime += dt;

		int moneyTime = RunTimeGetMoneyTime != null ? RunTimeGetMoneyTime.Value : get_money_time;
		if (moneyTime <= 0) moneyTime = get_money_time;

		if (DeltaTime >= moneyTime)
		{
			DeltaTime -= moneyTime;

			BigInteger fee = RentalFeeValue != null ? RentalFeeValue.Value : BigInteger.Zero;
			if (fee > BigInteger.Zero)
			{
				RuntimeRentalFeeValue.Value += fee;
				PlayRentalFeeGetSound();
			}
		}

		BigInteger currentFee = RentalFeeValue != null ? RentalFeeValue.Value : BigInteger.Zero;
		int currentTime = RunTimeGetMoneyTime != null ? RunTimeGetMoneyTime.Value : get_money_time;
		UpdateRevenueGraph(currentFee, currentTime, dt);
	}

	private void PlayRentalFeeGetSound()
	{
		gameObject.SetActive(true);
	}
}
