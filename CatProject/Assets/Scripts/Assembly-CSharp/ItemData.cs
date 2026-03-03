using System;
using UniRx;

public class ItemData : IReadOnlyData, ICloneable
{
	public IReactiveProperty<int> CountProperty;

	public int ItemIdx { get; private set; }

	public int ItemCount { get; private set; }

	public ItemData(int idx, int count)
	{
	}

	public void AddCount(int cnt)
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
