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
	}

	public void OnReleaseBuilding()
	{
	}

	private void OnDestroy()
	{
	}

	private void CheckCanBeHireWorker()
	{
	}

	private void OnAddNewActiveWorker(int prevCnt, int curCnt)
	{
	}
}
