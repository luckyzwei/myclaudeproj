using System;
using System.Collections.Generic;

public class RichAchieveData : IClientData
{
	[Obsolete]
	public Dictionary<int, RichAchieveCount> dic_achieveCountDatas;

	public List<int> missionReceivedIdxs;

	public List<int> achieveReceivedIdxs;

	public bool isGuideShow;

	public bool isPageInfoShow;

	public void SetRichAchieveData(int[] missionReceivedIdxs, int[] achieveReceivedIds, bool isGuideShow, bool isPageInfoShow)
	{
	}
}
