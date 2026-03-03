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
	}
}
