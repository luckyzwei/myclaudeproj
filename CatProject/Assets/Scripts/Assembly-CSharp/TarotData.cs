using System;
using System.Collections.Generic;
using UniRx;

public class TarotData : IClientData
{
	public IReactiveProperty<int> TarotBasicTicket;

	public IReactiveProperty<int> TarotSpecialTicket;

	public List<int> TarotRewardList;

	public Dictionary<int, TarotRegionData> TarotRegionDataList;

	public DateTime LastFreeRefreshTime;
}
