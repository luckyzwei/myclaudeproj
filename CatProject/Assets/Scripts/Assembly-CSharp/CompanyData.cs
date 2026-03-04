using System;
using System.Numerics;
using UniRx;

public class CompanyData : IReadOnlyData, ICloneable
{
	public bool MaxReward;

	public IReactiveProperty<int> LevelProperty;

	public IReactiveProperty<BigInteger> ExpProperty;

	public IReactiveProperty<int> IncreaseExp;

	public int MaxLevel;

	private bool FirstMax;

	public static bool MaxLevelCompany;

	public int Idx { get; private set; }

	public int Level { get; private set; }

	public BigInteger Exp { get; private set; }

	public int Grade { get { return 0; } }

	public CompanyData(int idx, int level, BigInteger exp, bool maxreward)
	{
		Idx = idx;
		Level = level;
		Exp = exp;
		MaxReward = maxreward;
	}

	public void UpdateExp(int targetRegion = -1, bool forceStrikeMood = false)
	{
	}

	public int CalculateIncreaseExp(int targetRegion, bool forceStrikeMood, bool checkStrike)
	{
		return 0;
	}

	public bool IsEnableLevelUp()
	{
		return false;
	}

	public bool IsEnableMaxLevelUp()
	{
		return false;
	}

	public void Create()
	{
		LevelProperty = new ReactiveProperty<int>(Level);
		ExpProperty = new ReactiveProperty<BigInteger>(Exp);
		IncreaseExp = new ReactiveProperty<int>();
	}

	public bool IsFirstMaxLevel()
	{
		return false;
	}

	public bool IsMaxLevel()
	{
		return false;
	}

	public virtual object Clone()
	{
		CompanyData clone = (CompanyData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
