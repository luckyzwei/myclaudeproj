using System;

public class AnyViewAdMission : SingleMissionBase
{
	private Action<bool> OnRewardedAdEvent;

	public override void Subscribe()
	{
		base.Subscribe();
	}

	public override string GetMissionDescriptionText()
	{
		return null;
	}
}
