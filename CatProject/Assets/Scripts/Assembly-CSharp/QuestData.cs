using System;
using UniRx;

public class QuestData : IReadOnlyData, ICloneable
{
	public int Idx;

	public IReactiveProperty<int> Value;

	public QuestData(int idx, int value)
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
