using UniRx;
using Treeplla;

public class AnyCarSellMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (no confirmed car sell event)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
