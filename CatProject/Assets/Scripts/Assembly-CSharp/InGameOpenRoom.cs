using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/OpenRoom", false)]
[FloatingDepth(11)]
public class InGameOpenRoom : InGameFloatingUI
{
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject NeedLevelObj;

	[SerializeField]
	private Slider NeedLevelProgress;

	[SerializeField]
	private ProgressText NeedLevelProgressText;

	[SerializeField]
	private Text NeedLevelText;

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

	[SerializeField]
	public GameObject TutorialObj;

	private CompositeDisposable disposables;

	private int OfficeIdx;

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (OpenBtn != null)
			OpenBtn.onClick.AddListener(OnClickOpen);
		if (SkipTimeBtn != null)
			SkipTimeBtn.onClick.AddListener(OnClickSkip);
	}

	public void SetOffice(int office)
	{
		OfficeIdx = office;
		if (LockObj != null) LockObj.SetActive(false);
		if (OpenObj != null) OpenObj.SetActive(true);
		if (TimeObj != null) TimeObj.SetActive(false);
		if (NeedLevelObj != null) NeedLevelObj.SetActive(false);
	}

	private void OnClickOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		// Open room purchase flow
	}

	private void OnClickSkip()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		// Skip construction timer via ad or cash
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}
}
