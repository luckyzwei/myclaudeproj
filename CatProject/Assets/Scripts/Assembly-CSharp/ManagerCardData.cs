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

	public ManagerCardData(int managerIdx, int managerLevel)
	{
	}

	public int GetSkillIdx(Config.ManagerSkillContentsType skillContentsType)
	{
		return 0;
	}

	public static ManagerCardData FromFlatBuffer(ManagerData? managerData)
	{
		return null;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<ManagerCardData> managerDataList)
	{
		return default(VectorOffset);
	}
}
