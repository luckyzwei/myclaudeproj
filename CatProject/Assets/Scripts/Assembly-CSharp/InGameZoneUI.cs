using System;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/ZoneUI", true)]
[FloatingDepth(12)]
public class InGameZoneUI : InGameFloatingUI
{
	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private GameObject NeedLevelObj;

	[SerializeField]
	private Slider NeedLevelProgress;

	[SerializeField]
	private ProgressText NeedLevelProgressText;

	[SerializeField]
	private Text NeedLevelText;

	[SerializeField]
	private Button LockBtn;

	[SerializeField]
	private GameObject ArrowNoti;

	[SerializeField]
	private float ArrowNotiShowTime;

	private int _zoneIdx;

	private Action OpenCb;

	private CompositeDisposable disposables;

	public int ZoneIdx { get { return 0; } }

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
	}

	public void Set(int zoneIdx, Action openCb)
	{
	}

	private void OnClickOpen()
	{
	}

	private void OnClickLock()
	{
	}

	public void SetArrowNoti()
	{
	}

	private void OnDestroy()
	{
	}
}
