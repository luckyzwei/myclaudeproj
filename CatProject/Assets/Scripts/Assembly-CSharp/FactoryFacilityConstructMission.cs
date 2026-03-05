public class FactoryFacilityConstructMission : SingleMissionBase
{
	private int TargetFacilityIdx;

	protected override void OnInitAfter()
	{
		if (Args != null && Args.Length >= 1)
			TargetFacilityIdx = (int)Args[0];
	}

	public override void Subscribe()
	{
		if (Disposables == null) return;
		// Subscribe to factory facility construction events
	}

	public override string GetMissionDescriptionText()
	{
		if (string.IsNullOrEmpty(MissionDescriptionKey)) return string.Empty;
		return MissionDescriptionKey;
	}
}
