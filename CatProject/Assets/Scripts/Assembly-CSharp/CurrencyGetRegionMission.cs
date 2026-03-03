public class CurrencyGetRegionMission : SingleMissionBase
{
	private int RegionIdx;

	private int RewardType;

	private int CurrencyIdx;

	private int RegionCurrencyIdx;

	protected override void OnInitAfter()
	{
	}

	public override void Subscribe()
	{
	}

	public override string GetMissionDescriptionText()
	{
		return null;
	}

	public override string GetMissionProgressText_CurrentValue()
	{
		return null;
	}

	public override string GetMissionProgressText_TargetValue()
	{
		return null;
	}

	public override bool IsPossibleShortCut()
	{
		return false;
	}
}
