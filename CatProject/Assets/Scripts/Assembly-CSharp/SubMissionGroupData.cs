using System;
using System.Collections.Generic;

public class SubMissionGroupData
{
	public int MissionIdx;

	public int ShowPriority;

	public bool bRepeat;

	public int CurActiveMissionIndex;

	public List<SubMissionStepData> MissionData;

	public IDisposable Disposable_OpenCondition;

	public bool bCompleteGroup
	{
		get
		{
			if (MissionData == null || MissionData.Count == 0) return false;
			if (bRepeat) return false;
			return CurActiveMissionIndex >= MissionData.Count;
		}
	}

	public SubMissionStepData CurMissionData
	{
		get
		{
			if (MissionData == null || CurActiveMissionIndex < 0 || CurActiveMissionIndex >= MissionData.Count)
				return null;
			return MissionData[CurActiveMissionIndex];
		}
	}

	~SubMissionGroupData()
	{
		DisposeSubscribe();
	}

	public void DisposeSubscribe()
	{
		if (Disposable_OpenCondition != null)
		{
			Disposable_OpenCondition.Dispose();
			Disposable_OpenCondition = null;
		}
		if (MissionData != null)
		{
			for (int i = 0; i < MissionData.Count; i++)
			{
				if (MissionData[i] != null)
					MissionData[i].DisposeSubscribe();
			}
		}
	}
}
