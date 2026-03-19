using System;
using UniRx;
using Treeplla;

public class AnyViewAdMission : SingleMissionBase
{
	private Action<bool> OnRewardedAdEvent;

	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		// Event subscription handled by ContentsMissionSystem (ad system dependent)
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
