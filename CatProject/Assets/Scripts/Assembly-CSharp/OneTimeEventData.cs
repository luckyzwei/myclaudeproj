using System;
using UniRx;

public class OneTimeEventData : IClientData
{
	public IReactiveProperty<int> OneTimeIdx;

	public IReactiveProperty<int> OneTimeCurrency;

	public int OneTimeLevel;

	public int OneTimeLevelExp;

	public int OneTimeReceiveLevel;

	public int OneTimeCompanyResetCount;

	public DateTime OneTimeCompanyResetTime;

	public bool IsActiveBonusOneTime;

	public void Init(int idx)
	{
		OneTimeIdx = new ReactiveProperty<int>(idx);
		OneTimeCurrency = new ReactiveProperty<int>(0);
		OneTimeLevel = 0;
		OneTimeLevelExp = 0;
		OneTimeReceiveLevel = 0;
		OneTimeCompanyResetCount = 0;
		OneTimeCompanyResetTime = DateTime.MinValue;
		IsActiveBonusOneTime = false;
	}
}
