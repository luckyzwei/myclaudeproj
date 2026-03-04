using System;
using UniRx;

public class FactoryItemData : IReadOnlyData, ICloneable
{
	public IReactiveProperty<int> CountProperty;

	public int Idx { get; private set; }

	public int Count { get; private set; }

	public FactoryItemData(int idx, int count)
	{
		Idx = idx;
		Count = count;
	}

	public void Create()
	{
		CountProperty = new ReactiveProperty<int>();
	}

	public virtual object Clone()
	{
		FactoryItemData clone = (FactoryItemData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
