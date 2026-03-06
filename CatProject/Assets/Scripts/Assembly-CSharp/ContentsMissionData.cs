using System;
using System.Collections.Generic;
using UniRx;

public class ContentsMissionData
{
	public int MissionCount;

	private CompositeDisposable Disposables;

	public Subject<(E_ContentsMissionType, int)> OnMissionComplete;

	public Subject<(E_ContentsMissionType, int)> OnMissionRewarded;

	public Subject<(E_ContentsMissionType, int)> OnMissionValueChanged;

	public Subject<(E_ContentsMissionType, int)> OnMissionActivate;

	public bool IsRefreshed;

	public E_ContentsMissionType ContentType { get; private set; }

	public int MissionGroupIdx { get; private set; }

	public Dictionary<int, SingleMissionBase> Missions { get; private set; }

	public DateTime MissionStartTime { get; private set; }

	public DateTime MissionEndTime { get; private set; }

	public DateTime MissionSetTime { get; private set; }

	public DateTime MissionNextResetTime { get; private set; }

	public int MissionResetHour { get; private set; }

	public int MissionResetCost { get; private set; }

	public ContentsMissionData(E_ContentsMissionType contentType, int missionGroupIdx, int missionCount, DateTime startTime, DateTime endTime, int resetHour, int resetCost)
	{
		ContentType = contentType;
		MissionGroupIdx = missionGroupIdx;
		MissionCount = missionCount;
		MissionStartTime = startTime;
		MissionEndTime = endTime;
		MissionResetHour = resetHour;
		MissionResetCost = resetCost;
	}

	public void SetMissionSetTime(DateTime setTime)
	{
		MissionSetTime = setTime;
		MissionNextResetTime = CalcMissionNextResetTime(setTime);
	}

	~ContentsMissionData()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void ClearMissions()
	{
		if (Missions != null) Missions.Clear();
		else Missions = new Dictionary<int, SingleMissionBase>();
	}

	public void PutNewMission(int slotId, SingleMissionBase mission)
	{
		if (Missions == null) Missions = new Dictionary<int, SingleMissionBase>();
		Missions[slotId] = mission;
	}

	public bool TryGetMission(int slotId, out SingleMissionBase mission)
	{
		mission = null;
		if (Missions == null) return false;
		return Missions.TryGetValue(slotId, out mission);
	}

	public List<SingleMissionBase> GetAllMissions()
	{
		if (Missions == null) return new List<SingleMissionBase>();
		return new List<SingleMissionBase>(Missions.Values);
	}

	private DateTime CalcMissionNextResetTime(DateTime baseTime)
	{
		var next = baseTime.Date.AddHours(MissionResetHour);
		if (next <= baseTime) next = next.AddDays(1);
		return next;
	}
}
