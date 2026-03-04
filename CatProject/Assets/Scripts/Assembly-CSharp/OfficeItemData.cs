using System;
using UniRx;

public class OfficeItemData : IReadOnlyData, ICloneable
{
	public IReactiveProperty<int> LevelProperty;

	public int Idx { get; private set; }

	public int Type { get; private set; }

	public int Level { get; private set; }

	public OfficeItemData(int type, int idx, int level)
	{
		Type = type;
		Idx = idx;
		Level = level;
	}

	public void Create()
	{
		LevelProperty = new ReactiveProperty<int>();
	}

	public virtual object Clone()
	{
		OfficeItemData clone = (OfficeItemData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
