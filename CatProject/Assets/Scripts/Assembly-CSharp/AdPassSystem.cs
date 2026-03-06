using System;
using UniRx;

public class AdPassSystem
{
	public IReactiveProperty<bool> isOpen;

	public IReactiveProperty<int> ResetRemainTime;

	public int supply_ad_add_money { get; private set; }

	public void Init()
	{
		isOpen = new ReactiveProperty<bool>(false);
		ResetRemainTime = new ReactiveProperty<int>(0);
		supply_ad_add_money = 0;
	}

	public void InitData()
	{
		ResetData();
	}

	private void ResetData()
	{
		isOpen.Value = false;
		ResetRemainTime.Value = 0;
		supply_ad_add_money = 0;
	}

	public void IncreaseAdViewCount()
	{
	}

	public void GetAdPassReward(int idx, Action Cb)
	{
		Cb?.Invoke();
	}

	public void UpdateOneSecond()
	{
		if (ResetRemainTime.Value > 0)
			ResetRemainTime.Value--;
		if (ResetRemainTime.Value <= 0)
			ResetData();
	}
}
