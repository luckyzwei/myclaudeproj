using System;
using UniRx;

public class ItemData : IReadOnlyData, ICloneable
{
	public IReactiveProperty<int> CountProperty;

	public int ItemIdx { get; private set; }

	public int ItemCount { get; private set; }

	public ItemData(int idx, int count)
	{
		ItemIdx = idx;
		ItemCount = count;
	}

	public void AddCount(int cnt)
	{
		ItemCount += cnt;
		if (CountProperty != null) CountProperty.Value = ItemCount;
	}

	public void Create()
	{
		CountProperty = new ReactiveProperty<int>(ItemCount);
	}

	public virtual object Clone()
	{
		ItemData clone = (ItemData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
