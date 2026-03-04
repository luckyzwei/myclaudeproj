using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class ContentsMissionUserData
{
	public E_ContentsMissionType ContentType;

	public DateTime MissionSetTime;

	public List<SingleMissionUserData> Missions;

	public bool IsRefreshed;

	public int MissionGroupIdx;

	public ContentsMissionUserData()
	{
	}

	public ContentsMissionUserData(ContentsMissionData contentsMissionData)
	{
		ContentType = contentsMissionData.ContentType;
	}

	public static ContentsMissionUserData FromFlatBuffer(Treeplla.Data.ContentsMissionData data)
	{
		var result = new ContentsMissionUserData();
		return result;
	}

	public static VectorOffset ToFlatBufferVector(Dictionary<E_ContentsMissionType, ContentsMissionUserData> source, FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}

	private static Offset<Treeplla.Data.ContentsMissionData> ToFlatBuffer(ContentsMissionUserData source, FlatBufferBuilder builder)
	{
		return default(Offset<Treeplla.Data.ContentsMissionData>);
	}
}
