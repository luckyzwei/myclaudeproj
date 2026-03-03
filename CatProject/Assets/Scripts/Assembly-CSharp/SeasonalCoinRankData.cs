using System;
using System.Collections.Generic;
using UniRx;

public class SeasonalCoinRankData : IClientData
{
	public DateTime StartRankTime;

	public DateTime EndRankTime;

	public DateTime RefreshTime;

	public IReactiveProperty<int> RemainTime;

	public int accumulateCnt;

	public List<SeasonalCoinRankUserData> UserList;

	public bool End;
}
