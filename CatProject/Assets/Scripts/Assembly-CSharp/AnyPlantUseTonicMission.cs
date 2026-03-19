using System.Collections.Generic;
using UniRx;
using Treeplla;

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
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (no confirmed plant tonic event)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
