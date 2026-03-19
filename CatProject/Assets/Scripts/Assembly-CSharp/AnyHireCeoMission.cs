using System.Numerics;
using UniRx;
using Treeplla;

public class AnyHireCeoMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		var root = GameRoot.Instance;
		if (root == null) return;
		root.ManagerCardSystem?.OnManagerHired.Subscribe(_ => OnCurrentValueChanged(System.Numerics.BigInteger.One)).AddTo(Disposables);
	}

	public override string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}
}
