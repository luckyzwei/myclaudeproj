using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorkshopWorkerFacility : MonoBehaviour
{
	[SerializeField]
	private GameObject NeedManagerConditionObject;

	[SerializeField]
	private Image NeedManagerIconImage;

	[SerializeField]
	private Text NeedManagerLevelText;

	[SerializeField]
	private Button ManagerButton;

	[SerializeField]
	private Button WorkerFireBtn;

	[SerializeField]
	private Button WorkerHireBtn;

	[SerializeField]
	private GameObject WorkerSlotListObject;

	[SerializeField]
	private GameObject WorkerSlotPrefab;

	[SerializeField]
	private GameObject ArrowObj;

	private int BuildingIdx;

	private int FacilityIdx;

	private int MaxWorkerCount;

	private int HiredWorkerCount;

	private int ProductionWorkerCount;

	private int ManagerLevel;

	private bool bExistManager;

	private int CanBeHireWorkerCnt;

	private List<int> NeedManagerLevelInfos;

	private int HireWorkerTryCount;

	private List<ItemWorkshopWorkerFacilitySlot> WorkerSlots;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void SetFacilityInfo(in int buildingIdx)
	{
	}

	private void Refresh()
	{
	}

	public void ShowArrow()
	{
	}

	private void CreateAndSetWorkerSlots(int hiredCnt, int maxCnt, int productionWorkerCnt)
	{
	}

	private void SetManagerIcon(string path)
	{
	}

	private void SetNewWorkerHireLayout()
	{
	}

	private void OnClickedWorkerFireBtn()
	{
	}

	private void OnClickedWorkerHireBtn()
	{
	}

	private void OnClickedManagerButton()
	{
	}

	private void OnClickedPauseStateWorkerIcon(ItemWorkshopWorkerFacilitySlot.E_SlotState slotState)
	{
	}

	private void OnChangeWorkerCount(int hiredWorkerCnt, int maxWorkerCnt, int productionWorkerCount)
	{
	}

	private void OnChangeManagerLevelInfo(int level)
	{
	}

	private void UpdateManagerLevelInfo()
	{
	}
}
