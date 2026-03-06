using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Seasonal/SeasonalWorkerBubble", true)]
[FloatingDepth(11)]
public class InGameSeasonalWorkerBubbleUI : InGameFloatingUI
{
	[SerializeField]
	private GameObject RootObject;

	[SerializeField]
	private GameObject ActivateWorkerObj;

	[SerializeField]
	private Text ActivateWorkerCountText;

	[SerializeField]
	private GameObject CanBeHireWorkerObj;

	[SerializeField]
	private GameObject LockIcon;

	private int BuildingIdx;

	private E_BuildingType BuildingType;

	private int ActivateWorkerCount;

	private CompositeDisposable Disposables;

	public void SetBuildingInfo(int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		Disposables = new CompositeDisposable();
		if (RootObject != null) RootObject.SetActive(true);
	}

	public void OnReleaseBuilding()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
		if (RootObject != null) RootObject.SetActive(false);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void CheckCanBeHireWorker()
	{
		if (CanBeHireWorkerObj != null) CanBeHireWorkerObj.SetActive(false);
	}

	private void OnAddNewActiveWorker(int prevCnt, int curCnt)
	{
		ActivateWorkerCount = curCnt;
		if (ActivateWorkerCountText != null)
			ActivateWorkerCountText.text = curCnt.ToString();
	}
}
