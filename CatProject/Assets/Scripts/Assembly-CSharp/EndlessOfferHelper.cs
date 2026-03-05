using System;
using Treeplla;

public static class EndlessOfferHelper
{
	public static string GetHudImageName(EndlessOfferInfoData offerInfo)
	{
		if (offerInfo == null) return string.Empty;
		return string.Empty;
	}

	public static string GetMainImageName(EndlessOfferInfoData offerInfo)
	{
		if (offerInfo == null) return string.Empty;
		return string.Empty;
	}

	public static int GetMainImageIndex(DateTime startTime, DateTime nowTime, int imgCount)
	{
		if (imgCount <= 0) return 0;
		var elapsed = nowTime - startTime;
		int days = (int)elapsed.TotalDays;
		return days % imgCount;
	}
}
