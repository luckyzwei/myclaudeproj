using System;
using UniRx;

public class FactoryOrderSlotData : IReadOnlyData, ICloneable
{
	public bool IsOpen;

	public int OrderProduct;

	public int OrderCount;

	public DateTime RefreshTime;

	public IReactiveProperty<int> RemainRefreshTime;

	public int Idx { get; private set; }

	public int CharacterIconIdx { get; private set; }

	public int CharacterTalkIdx { get; private set; }

	public FactoryOrderSlotData(int idx, bool open, int product, int count, DateTime time)
	{
	}

	public void SetOrderCharacter(int characterIconIdx, int characterTalkIdx)
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
