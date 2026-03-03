using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/ParkingUI", true)]
[FloatingDepth(12)]
public class InGameParkingUI : InGameFloatingUI
{
	[Header("NeedLevel")]
	[SerializeField]
	private GameObject NeedLevelObj;

	[SerializeField]
	private Image RichPointIcon;

	[SerializeField]
	private Text RichPointText;

	[SerializeField]
	private Slider RichPointProgress;

	private CompositeDisposable disposables;

	public override void Init(Transform parent, GameType type = GameType.House)
	{
	}
}
