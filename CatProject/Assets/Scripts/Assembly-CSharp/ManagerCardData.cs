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
		return 0;
	}

	public static ManagerCardData FromFlatBuffer(ManagerData? managerData)
	{
		if (!managerData.HasValue) return null;
		var d = managerData.Value;
		var result = new ManagerCardData();
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<ManagerCardData> managerDataList)
	{
		return default(VectorOffset);
	}
}
