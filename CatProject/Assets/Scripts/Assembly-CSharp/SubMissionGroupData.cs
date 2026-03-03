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

	public bool bCompleteGroup => false;

	public SubMissionStepData CurMissionData => null;

	~SubMissionGroupData()
	{
	}

	public void DisposeSubscribe()
	{
	}
}
