using System;

public class AnyViewAdMission : SingleMissionBase
{
	private Action<bool> OnRewardedAdEvent;

	public override void Subscribe()
	{
		// Subscribe to mission events
	}

	public override string GetMissionDescriptionText()
	{
		return null;
	}
}
