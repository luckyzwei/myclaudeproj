using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class ManagerCardData
{
	public int ManagerIdx;

	public IReactiveProperty<int> ManagerLevel;

	public int ManagerCount;

	public int ReinforceLevel;

	public int SkillLevel;

	public DateTime LastReinforceResetTime;

	public Config.ManagerGrade ManagerGrade { get; private set; }

	public ManagerSkillData OfficeSkillData { get; private set; }

	public ManagerSkillData AcquisitionSkillData { get; private set; }

	public ManagerSkillData DispatchSkillData { get; private set; }

	private ManagerCardData() { }

	public ManagerCardData(int managerIdx, int managerLevel)
	{
		ManagerIdx = managerIdx;
		ManagerLevel = new ReactiveProperty<int>(managerLevel);
	}

	public int GetSkillIdx(Config.ManagerSkillContentsType skillContentsType)
	{
		switch (skillContentsType)
		{
			case Config.ManagerSkillContentsType.Office:
				return OfficeSkillData != null ? OfficeSkillData.SkillIdx : 0;
			case Config.ManagerSkillContentsType.Acquisition:
				return AcquisitionSkillData != null ? AcquisitionSkillData.SkillIdx : 0;
			case Config.ManagerSkillContentsType.Dispatch:
				return DispatchSkillData != null ? DispatchSkillData.SkillIdx : 0;
			default:
				return 0;
		}
	}

	public static ManagerCardData FromFlatBuffer(ManagerData? managerData)
	{
		if (!managerData.HasValue) return null;
		var d = managerData.Value;
		var result = new ManagerCardData();
		result.ManagerIdx = d.Idx;
		result.ManagerLevel = new ReactiveProperty<int>(d.Level);
		result.ManagerCount = d.Count;
		result.ReinforceLevel = d.Reinforcelevel;
		result.SkillLevel = d.Skilllevel;
		result.LastReinforceResetTime = d.Reinforceresetlasttime > 0
			? DateTimeOffset.FromUnixTimeSeconds(d.Reinforceresetlasttime).UtcDateTime
			: DateTime.MinValue;
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<ManagerCardData> managerDataList)
	{
		if (managerDataList == null || managerDataList.Count == 0)
			return default(VectorOffset);

		var offsets = new Offset<ManagerData>[managerDataList.Count];
		for (int i = 0; i < managerDataList.Count; i++)
		{
			var m = managerDataList[i];
			long resetTime = m.LastReinforceResetTime > DateTime.MinValue
				? new DateTimeOffset(m.LastReinforceResetTime).ToUnixTimeSeconds()
				: 0L;
			offsets[i] = ManagerData.CreateManagerData(
				builder,
				m.ManagerIdx,
				m.ManagerLevel.Value,
				m.ManagerCount,
				m.ReinforceLevel,
				m.SkillLevel,
				resetTime);
		}
		return builder.CreateVectorOfTables(offsets);
	}
}
