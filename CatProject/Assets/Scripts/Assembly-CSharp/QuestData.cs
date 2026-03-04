using System;
using UniRx;

public class QuestData : IReadOnlyData, ICloneable
{
	public int Idx;

	public IReactiveProperty<int> Value;

	public QuestData(int idx, int value)
	{
		Idx = idx;
		Value = new ReactiveProperty<int>(value);
	}

	public void Create()
	{
		Value = new ReactiveProperty<int>();
	}

	public virtual object Clone()
	{
		QuestData clone = (QuestData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
