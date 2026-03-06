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

	public int Grade { get { return Level / 10; } }

	public CompanyData(int idx, int level, BigInteger exp, bool maxreward)
	{
		Idx = idx;
		Level = level;
		Exp = exp;
		MaxReward = maxreward;
	}

	public void UpdateExp(int targetRegion = -1, bool forceStrikeMood = false)
	{
		int increaseValue = CalculateIncreaseExp(targetRegion, forceStrikeMood, true);
		if (increaseValue <= 0) return;

		Exp += increaseValue;
		if (ExpProperty != null)
			ExpProperty.Value = Exp;
		if (IncreaseExp != null)
			IncreaseExp.Value = increaseValue;

		while (IsEnableLevelUp())
		{
			Level++;
			if (LevelProperty != null)
				LevelProperty.Value = Level;

			if (IsMaxLevel() && !FirstMax)
			{
				FirstMax = true;
				MaxLevelCompany = true;
			}
		}
	}

	public int CalculateIncreaseExp(int targetRegion, bool forceStrikeMood, bool checkStrike)
	{
		if (IsMaxLevel()) return 0;
		return 1;
	}

	public bool IsEnableLevelUp()
	{
		if (MaxLevel <= 0) return false;
		if (Level >= MaxLevel) return false;
		BigInteger needExp = (Level + 1) * 100;
		return Exp >= needExp;
	}

	public bool IsEnableMaxLevelUp()
	{
		if (MaxLevel <= 0) return false;
		return Level < MaxLevel;
	}

	public void Create()
	{
		LevelProperty = new ReactiveProperty<int>(Level);
		ExpProperty = new ReactiveProperty<BigInteger>(Exp);
		IncreaseExp = new ReactiveProperty<int>();
	}

	public bool IsFirstMaxLevel()
	{
		return FirstMax;
	}

	public bool IsMaxLevel()
	{
		if (MaxLevel <= 0) return false;
		return Level >= MaxLevel;
	}

	public virtual object Clone()
	{
		CompanyData clone = (CompanyData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
