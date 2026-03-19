using System.Numerics;
using UniRx;
using Treeplla;

public class UseAnyBoosterMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		var root = GameRoot.Instance;
		if (root == null) return;
		root.AbilitySystem?.OnUseBooster.Subscribe(_ => OnCurrentValueChanged(System.Numerics.BigInteger.One)).AddTo(Disposables);
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
