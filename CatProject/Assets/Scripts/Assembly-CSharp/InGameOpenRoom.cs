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
	}

	public void SetOffice(int office)
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
