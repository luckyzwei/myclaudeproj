using System.Numerics;
using UniRx;
using Treeplla;

public class CompanyInvestMission : SingleMissionBase
{
	public override void Subscribe()
	{
		if (Disposables == null) Disposables = new CompositeDisposable();
		var root = GameRoot.Instance;
		if (root == null) return;
		root.InvestSystem?.OnStartInvest.Subscribe(_ => OnCurrentValueChanged(System.Numerics.BigInteger.One)).AddTo(Disposables);
	}
}
