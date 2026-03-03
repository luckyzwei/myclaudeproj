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
	}

	public void Create()
	{
	}

	public virtual object Clone()
	{
		return null;
	}
}
