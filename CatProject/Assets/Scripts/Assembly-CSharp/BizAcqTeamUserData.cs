using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class BizAcqTeamUserData
{
	public List<int> TeamCeoIdxList { get; set; }

	public void Set(global::BizAcqTeamData teamData)
	{
		if (teamData == null) return;
		if (TeamCeoIdxList == null)
			TeamCeoIdxList = new List<int>();
		TeamCeoIdxList.Clear();

		var characters = teamData.Characters;
		if (characters != null)
		{
			for (int i = 0; i < characters.Count; i++)
			{
				if (characters[i] != null)
					TeamCeoIdxList.Add(characters[i].CeoIdx);
			}
		}
	}

	public bool IsAssignedManager(int managerIdx)
	{
		if (TeamCeoIdxList == null) return false;
		return TeamCeoIdxList.Contains(managerIdx);
	}

	public void FromFlatBuffer(Treeplla.Data.BizAcqTeamData? teamData)
	{
		if (!teamData.HasValue) return;
		var d = teamData.Value;
		if (TeamCeoIdxList == null)
			TeamCeoIdxList = new List<int>();
		TeamCeoIdxList.Clear();
	}

	public static Offset<Treeplla.Data.BizAcqTeamData> ToFlatBuffer(FlatBufferBuilder builder, BizAcqTeamUserData data)
	{
		return default(Offset<Treeplla.Data.BizAcqTeamData>);
	}
}
