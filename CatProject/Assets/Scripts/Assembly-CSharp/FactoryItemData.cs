using System;
using UniRx;

public class FactoryItemData : IReadOnlyData, ICloneable
{
	public IReactiveProperty<int> CountProperty;

	public int Idx { get; private set; }

	public int Count { get; private set; }

	public FactoryItemData(int idx, int count)
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
