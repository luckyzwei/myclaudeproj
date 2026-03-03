using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/Factory/OpenFactory", false)]
[FloatingDepth(1)]
public class InGameOpenFactory : InGameFloatingUI
{
	[SerializeField]
	private GameObject OpenObj;

	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private GameObject TimeObj;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button SkipTimeBtn;

	private CompositeDisposable disposables;

	private int FactoryIdx;

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.Factory)
	{
	}

	public void SetFactory(int factory)
	{
	}

	private void OnClickOpen()
	{
	}

	private void OnClickSkip()
	{
	}

	private void OnDestroy()
	{
	}
}
