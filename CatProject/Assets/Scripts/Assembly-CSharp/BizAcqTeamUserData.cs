using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class BizAcqTeamUserData
{
	public List<int> TeamCeoIdxList { get; set; }

	public void Set(BizAcqTeamData teamData)
	{
	}

	public bool IsAssignedManager(int managerIdx)
	{
		return false;
	}

	public void FromFlatBuffer(Treeplla.Data.BizAcqTeamData? teamData)
	{
	}

	public static Offset<Treeplla.Data.BizAcqTeamData> ToFlatBuffer(FlatBufferBuilder builder, BizAcqTeamUserData data)
	{
		return default(Offset<Treeplla.Data.BizAcqTeamData>);
	}
}
