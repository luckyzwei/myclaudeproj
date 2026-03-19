using System.Collections.Generic;
using UniRx;
using Treeplla;

public class BuyDailySkillStoneMission : SingleMissionBase
{
	private List<int> SkillStoneProductIdxList;

	protected override void OnInitAfter()
	{
		base.OnInitAfter();
	}

	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (shop system dependent)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
