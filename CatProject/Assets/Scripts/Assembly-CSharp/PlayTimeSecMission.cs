public class PlayTimeSecMission : SingleMissionBase
{
	public override void Subscribe()
	{
		base.Subscribe();
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? string.Empty;
	}

	public override string GetMissionProgressText_CurrentValue()
	{
		return CurrentValue != null ? CurrentValue.Value.ToString() : "0";
	}

	public override string GetMissionProgressText_TargetValue()
	{
		return TargetValue.ToString();
	}

	public override string GetMissionProgressText()
	{
		string cur = GetMissionProgressText_CurrentValue();
		string target = GetMissionProgressText_TargetValue();
		return cur + "/" + target;
	}
}
