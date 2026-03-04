using System;
using Google.FlatBuffers;
using Treeplla.Data;

public class AdsViewUserData
{
	public int ItemIdx { get; private set; }

	public int ViewCount { get; private set; }

	public DateTime LastViewTime { get; private set; }

	public AdsViewUserData(int itemIdx, int viewCount, DateTime lastViewTime)
	{
		ItemIdx = itemIdx;
		ViewCount = viewCount;
		LastViewTime = lastViewTime;
	}

	public void OnViewAds()
	{
	}

	public static AdsViewUserData FromFlatBuffer(AdsFreeViewData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = (AdsViewUserData)new AdsViewUserData(0, 0, default(DateTime)).MemberwiseClone();
		return result;
	}

	public static Offset<AdsFreeViewData> ToFlatBuffer(FlatBufferBuilder builder, AdsViewUserData userData)
	{
		return default(Offset<AdsFreeViewData>);
	}
}
