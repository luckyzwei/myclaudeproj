using System;
using UniRx;

public class AdPassSystem
{
	public IReactiveProperty<bool> isOpen;

	public IReactiveProperty<int> ResetRemainTime;

	public int supply_ad_add_money { get; private set; }

	public void Init()
	{
	}

	public void InitData()
	{
	}

	private void ResetData()
	{
	}

	public void IncreaseAdViewCount()
	{
	}

	public void GetAdPassReward(int idx, Action Cb)
	{
	}

	public void UpdateOneSecond()
	{
	}
}
