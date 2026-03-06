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
		disposables = new CompositeDisposable();
		if (OpenBtn != null) OpenBtn.onClick.AddListener(OnClickOpen);
		if (SkipTimeBtn != null) SkipTimeBtn.onClick.AddListener(OnClickSkip);
	}

	public override void Init(Transform parent, GameType type = GameType.Factory)
	{
		base.Init(parent, type);
	}

	public void SetFactory(int factory)
	{
		FactoryIdx = factory;
		if (OpenObj != null) OpenObj.SetActive(true);
		if (TimeObj != null) TimeObj.SetActive(false);
	}

	private void OnClickOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Open factory
	}

	private void OnClickSkip()
	{
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
