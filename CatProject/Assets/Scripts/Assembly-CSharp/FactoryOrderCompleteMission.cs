public class FactoryOrderCompleteMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) return;
	}

	public override string GetMissionDescriptionText()
	{
		if (string.IsNullOrEmpty(MissionDescriptionKey)) return string.Empty;
		return MissionDescriptionKey;
	}
}
