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
	}

	public void OnViewAds()
	{
	}

	public static AdsViewUserData FromFlatBuffer(AdsFreeViewData? data)
	{
		return null;
	}

	public static Offset<AdsFreeViewData> ToFlatBuffer(FlatBufferBuilder builder, AdsViewUserData userData)
	{
		return default(Offset<AdsFreeViewData>);
	}
}
