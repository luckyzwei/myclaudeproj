using System;
using System.Numerics;
using UniRx;

public class BuildingData : IReadOnlyData, ICloneable
{
	public int Idx;

	public int Level;

	public int Time;

	public DateTime NextRewardTime;

	public IReactiveProperty<BigInteger> Value;

	public IReactiveProperty<int> RemainNextRewardTime;

	public BuildingData(int idx, int lv, int time, BigInteger value)
	{
		Idx = idx;
		Level = lv;
		Time = time;
		Value = new ReactiveProperty<BigInteger>(value);
	}

	public void LevelUp()
	{
	}

	public void Create()
	{
		Value = new ReactiveProperty<BigInteger>();
		RemainNextRewardTime = new ReactiveProperty<int>();
	}

	public virtual object Clone()
	{
		BuildingData clone = (BuildingData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
