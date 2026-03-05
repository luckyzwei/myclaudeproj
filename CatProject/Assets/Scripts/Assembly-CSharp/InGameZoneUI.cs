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

	public int ZoneIdx { get { return _zoneIdx; } }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (OpenBtn != null)
			OpenBtn.onClick.AddListener(OnClickOpen);
		if (LockBtn != null)
			LockBtn.onClick.AddListener(OnClickLock);
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
		base.Init(parent, type);
	}

	public void Set(int zoneIdx, Action openCb)
	{
		_zoneIdx = zoneIdx;
		OpenCb = openCb;

		// Check if zone is unlockable
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		bool canOpen = true; // Determined by level requirements
		if (OpenBtn != null)
			OpenBtn.gameObject.SetActive(canOpen);
		if (NeedLevelObj != null)
			NeedLevelObj.SetActive(!canOpen);
	}

	private void OnClickOpen()
	{
		OpenCb?.Invoke();
	}

	private void OnClickLock()
	{
		// Show locked zone info (level requirement)
	}

	public void SetArrowNoti()
	{
		if (ArrowNoti != null)
		{
			ArrowNoti.SetActive(true);
			CancelInvoke(nameof(HideArrowNoti));
			Invoke(nameof(HideArrowNoti), ArrowNotiShowTime);
		}
	}

	private void HideArrowNoti()
	{
		if (ArrowNoti != null)
			ArrowNoti.SetActive(false);
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
