using System;
using System.Collections.Generic;
using SeasonalDef;
using UniRx;

public class SeasonalMissionGroupData
{
	public int MissionIdx;

	public int ShowPriority;

	public E_MissionOpenCondition OpenCondition;

	public int OpenConditionValue;

	public IReactiveProperty<bool> bSatisfiedOpenCondition;

	public bool bRepeat;

	public int CurActiveMissionIndex;

	public List<SeasonalMissionData> MissionData;

	public IDisposable Disposable_OpenCondition;

	public bool bCompleteGroup => false;

	public SeasonalMissionData CurMissionData => null;

	~SeasonalMissionGroupData()
	{
	}

	public void DisposeSubscribe()
	{
	}
}
