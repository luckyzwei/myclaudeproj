using System.Collections.Generic;

public class AnyPlantUseTonicMission : SingleMissionBase
{
	private int RewardType;

	private List<int> TonicItemIds;

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
}
