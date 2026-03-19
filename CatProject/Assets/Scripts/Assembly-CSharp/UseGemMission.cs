using UniRx;
using Treeplla;

public class UseGemMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (gem usage tracking)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
