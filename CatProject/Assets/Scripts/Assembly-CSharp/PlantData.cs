using System;
using System.Collections.Generic;
using UniRx;

public class PlantData : IReadOnlyData, ICloneable
{
	public int Idx;

	public float Exp;

	public int Level;

	public int Count;

	public Dictionary<int, float> Fulls;

	public IReactiveProperty<int> LevelProperty;

	public IReactiveProperty<float> ExpProperty;

	public int AddExp;

	public float NeedLvUpExp;

	public float DecreaseFull;

	public DateTime AbilityUseTime;

	public IReactiveProperty<int> RemainNextAbilityUseTime;

	public bool IsNew;

	public bool isMax { get; private set; }

	public void Create()
	{
		LevelProperty = new ReactiveProperty<int>();
		ExpProperty = new ReactiveProperty<float>();
		RemainNextAbilityUseTime = new ReactiveProperty<int>();
	}

	public void LevelUp(Action cb = null)
	{
		Level++;
		if (LevelProperty != null)
			LevelProperty.Value = Level;
		Exp = 0f;
		if (ExpProperty != null)
			ExpProperty.Value = Exp;
		UpdateLevel();
		cb?.Invoke();
	}

	private void UpdateLevel()
	{
		if (LevelProperty != null)
			LevelProperty.Value = Level;
	}

	public void UpdateIncreaseExpBuff()
	{
		if (ExpProperty != null)
			ExpProperty.Value = Exp;
	}

	public virtual object Clone()
	{
		PlantData clone = (PlantData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
