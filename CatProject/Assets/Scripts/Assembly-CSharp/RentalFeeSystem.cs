using System.Collections.Generic;
using System.Numerics;
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
	}

	private void UpdateRevenueGraph(BigInteger nowRentalFeeValue, int nowRentalFeeGetTime, float deltaTime)
	{
	}

	public void CalculateRentalFee()
	{
	}

	public void UpdateRunTimeRentalFeeGetTime()
	{
	}

	public void CalculateRentalFeeAll()
	{
	}

	public BigInteger CalculateActiveRegionRentalFee(bool containStrike = false)
	{
		return default(BigInteger);
	}

	public BigInteger CalculateStageRentalFee(int region, bool containStrike = false)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionRentalFee(int region)
	{
		return default(BigInteger);
	}

	public BigInteger GetRegionIncomePerSecond(int region)
	{
		return default(BigInteger);
	}

	public BigInteger GetRuntimeRentalFee()
	{
		return default(BigInteger);
	}

	public BigInteger GetOfficeRentalFee(int region, int officeKey, OfficeData officeData, bool containStrike = false)
	{
		return default(BigInteger);
	}

	public BigInteger GetOfficeRentalFee(int region, int officeKey, OfficeData officeData, bool containStrike, out BigInteger exceptManagerBuff)
	{
		exceptManagerBuff = default(BigInteger);
		return default(BigInteger);
	}

	private BigInteger CalculateCompanyRentalFee(int region, int officeKey, int companyIdx)
	{
		return default(BigInteger);
	}

	public bool isEnoughRequireItem(int region, int office)
	{
		return false;
	}

	public bool isEnoughRequireItem(int office, int seat, out int randdissatisfyItem, out bool isdeskenough)
	{
		randdissatisfyItem = default(int);
		isdeskenough = default(bool);
		return false;
	}

	public BigInteger CalculateStrikeRentalFee(int region)
	{
		return default(BigInteger);
	}

	public void Update()
	{
	}

	private void PlayRentalFeeGetSound()
	{
	}
}
