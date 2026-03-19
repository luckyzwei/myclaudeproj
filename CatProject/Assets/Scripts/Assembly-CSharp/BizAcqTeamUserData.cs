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
		for (int i = 0; i < d.TeamceoidxlistLength; i++)
			TeamCeoIdxList.Add(d.Teamceoidxlist(i));
	}

	public static Offset<Treeplla.Data.BizAcqTeamData> ToFlatBuffer(FlatBufferBuilder builder, BizAcqTeamUserData data)
	{
		if (data == null) return default(Offset<Treeplla.Data.BizAcqTeamData>);
		VectorOffset teamVecOffset = default(VectorOffset);
		if (data.TeamCeoIdxList != null && data.TeamCeoIdxList.Count > 0)
			teamVecOffset = Treeplla.Data.BizAcqTeamData.CreateTeamceoidxlistVector(builder, data.TeamCeoIdxList.ToArray());
		return Treeplla.Data.BizAcqTeamData.CreateBizAcqTeamData(builder, teamVecOffset);
	}
}
