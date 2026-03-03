using Treeplla;
using UniRx;
using UnityEngine;

[FloatUIPath("UI/InGame/RealtorUI", true)]
[FloatingDepth(1)]
public class InGameRealtorUI : InGameFloatingUI
{
	private CompositeDisposable disposables;

	public override void Init(Transform parent, GameType type = GameType.House)
	{
	}

	private void OnDestroy()
	{
	}
}
