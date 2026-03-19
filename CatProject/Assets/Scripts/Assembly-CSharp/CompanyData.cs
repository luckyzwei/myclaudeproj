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
		// Base exp scales with grade (level / 10), minimum 1
		int baseExp = 1 + Grade;
		// Strike penalty: employees on strike produce less
		if (checkStrike && forceStrikeMood)
			baseExp = Math.Max(1, baseExp / 2);
		return baseExp;
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
		if (LevelProperty == null) LevelProperty = new ReactiveProperty<int>(Level);
		else LevelProperty.Value = Level;
		if (ExpProperty == null) ExpProperty = new ReactiveProperty<BigInteger>(Exp);
		else ExpProperty.Value = Exp;
		if (IncreaseExp == null) IncreaseExp = new ReactiveProperty<int>();
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
