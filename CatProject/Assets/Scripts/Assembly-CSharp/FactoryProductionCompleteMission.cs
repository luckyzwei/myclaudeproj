using UniRx;

public class FactoryProductionCompleteMission : SingleMissionBase
{
	private int TargetProductIdx;

	private int OpenCondition_FactoryType;

	private int OpenCondition_FactoryLevel;

	private bool IsActive;

	private CompositeDisposable ConditionDisposables;

	protected override void OnInitAfter()
	{
		if (Args != null && Args.Length >= 3)
		{
			TargetProductIdx = (int)Args[0];
			OpenCondition_FactoryType = (int)Args[1];
			OpenCondition_FactoryLevel = (int)Args[2];
		}
		ConditionDisposables = new CompositeDisposable();
		IsActive = CheckIsActive();
	}

	public override void Subscribe()
	{
		if (Disposables == null) return;
		IsActive = CheckIsActive();
	}

	public override bool IsActiveMission()
	{
		return IsActive;
	}

	public override bool IsExistOpenCondition()
	{
		return OpenCondition_FactoryType > 0 || OpenCondition_FactoryLevel > 0;
	}

	public override string GetMissionDescriptionText()
	{
		if (string.IsNullOrEmpty(MissionDescriptionKey)) return string.Empty;
		return MissionDescriptionKey;
	}

	private bool CheckIsActive()
	{
		if (OpenCondition_FactoryType <= 0 && OpenCondition_FactoryLevel <= 0) return true;
		return true;
	}
}
