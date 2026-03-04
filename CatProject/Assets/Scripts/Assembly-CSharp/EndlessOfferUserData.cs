using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class EndlessOfferUserData
{
	public int EndlessIdx;

	public int CurOrderIdx;

	public DateTime EndTime;

	public DateTime LastAutoShowTime;

	public int BuyCount;

	public Subject<bool> OnResetEndlessOffer;

	public static EndlessOfferUserData FromFlatBuffer(EndlessOfferData data)
	{
		var result = new EndlessOfferUserData();
		return result;
	}

	private static Offset<EndlessOfferData> ToFlatBuffer(FlatBufferBuilder builder, EndlessOfferUserData data)
	{
		return default(Offset<EndlessOfferData>);
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, Dictionary<int, EndlessOfferUserData> dataList)
	{
		return default(VectorOffset);
	}
}
