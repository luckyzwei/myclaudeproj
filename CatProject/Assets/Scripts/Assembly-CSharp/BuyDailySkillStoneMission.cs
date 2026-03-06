using System.Collections.Generic;

public class BuyDailySkillStoneMission : SingleMissionBase
{
	private List<int> SkillStoneProductIdxList;

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
