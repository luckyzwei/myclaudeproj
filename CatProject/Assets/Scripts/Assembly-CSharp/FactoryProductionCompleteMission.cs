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
	}

	public override void Subscribe()
	{
	}

	public override bool IsActiveMission()
	{
		return false;
	}

	public override bool IsExistOpenCondition()
	{
		return false;
	}

	public override string GetMissionDescriptionText()
	{
		return null;
	}
}
