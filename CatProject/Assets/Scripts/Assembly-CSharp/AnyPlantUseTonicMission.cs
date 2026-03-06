using System.Collections.Generic;

public class AnyPlantUseTonicMission : SingleMissionBase
{
	private int RewardType;

	private List<int> TonicItemIds;

	protected override void OnInitAfter()
	{
		base.OnInitAfter();
	}

	public override void Subscribe()
	{
		// Subscribe to mission events
	}

	public override string GetMissionDescriptionText()
	{
		return null;
	}
}
