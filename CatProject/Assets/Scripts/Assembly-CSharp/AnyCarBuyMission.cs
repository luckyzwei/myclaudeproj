using UniRx;
using Treeplla;

public class AnyCarBuyMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (no confirmed car buy event)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
