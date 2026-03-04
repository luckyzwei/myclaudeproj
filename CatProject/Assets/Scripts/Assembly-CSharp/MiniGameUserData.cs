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

	public void ReadyMiniGameUserData(int scheduleIdx, int eventIdx, E_MiniGameType miniGameType)
	{
	}

	public void OnShownOpenPopup()
	{
	}

	public MiniGameDigTreasureHuntUserData GetDigTreasureHuntUserData(int scheduleIdx)
	{
		return null;
	}

	public MiniGameShopUserData GetMiniGameShopUserData(int scheduleIdx)
	{
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
