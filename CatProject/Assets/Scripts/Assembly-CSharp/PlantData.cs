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
		if (LevelProperty == null) LevelProperty = new ReactiveProperty<int>();
		if (ExpProperty == null) ExpProperty = new ReactiveProperty<float>();
		if (RemainNextAbilityUseTime == null) RemainNextAbilityUseTime = new ReactiveProperty<int>();
		if (Fulls == null) Fulls = new Dictionary<int, float>();
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
