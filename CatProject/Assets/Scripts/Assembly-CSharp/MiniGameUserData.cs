using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameUserData
{
	private static readonly int MINIGAME_RECORD_COUNT_MAX;

	private List<MiniGameDigTreasureHuntUserData> DigTreasureHuntUserDataList;

	private List<MiniGameShopUserData> MiniGameShopUserDataList;

	public bool IsShownOpenPopup { get; private set; }

	public int LastPlayScheduleIdx { get; private set; }

	public MiniGameUserData()
	{
		DigTreasureHuntUserDataList = new List<MiniGameDigTreasureHuntUserData>();
		MiniGameShopUserDataList = new List<MiniGameShopUserData>();
	}

	public void ReadyMiniGameUserData(int scheduleIdx, int eventIdx, E_MiniGameType miniGameType)
	{
		LastPlayScheduleIdx = scheduleIdx;
		IsShownOpenPopup = false;
	}

	public void OnShownOpenPopup()
	{
		IsShownOpenPopup = true;
	}

	public MiniGameDigTreasureHuntUserData GetDigTreasureHuntUserData(int scheduleIdx)
	{
		if (DigTreasureHuntUserDataList == null) return null;
		for (int i = 0; i < DigTreasureHuntUserDataList.Count; i++)
		{
			if (DigTreasureHuntUserDataList[i] != null && DigTreasureHuntUserDataList[i].ScheduleIdx == scheduleIdx)
				return DigTreasureHuntUserDataList[i];
		}
		return null;
	}

	public MiniGameShopUserData GetMiniGameShopUserData(int scheduleIdx)
	{
		if (MiniGameShopUserDataList == null) return null;
		for (int i = 0; i < MiniGameShopUserDataList.Count; i++)
		{
			if (MiniGameShopUserDataList[i] != null && MiniGameShopUserDataList[i].ScheduleIdx == scheduleIdx)
				return MiniGameShopUserDataList[i];
		}
		return null;
	}

	public static MiniGameUserData FromFlatBuffer(MiniGameData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new MiniGameUserData();
		return result;
	}

	public static Offset<MiniGameData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameUserData userData)
	{
		return default(Offset<MiniGameData>);
	}
}
