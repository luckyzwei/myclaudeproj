using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorkShop : MonoBehaviour
{
	[Header("Elements")]
	[SerializeField]
	private Image img_workshop;

	[SerializeField]
	private Image img_currency_icon;

	[SerializeField]
	private Text text_workshop_name;

	[SerializeField]
	private Text text_worker_count;

	[SerializeField]
	private Button btn_plus;

	[SerializeField]
	private Button btn_minus;

	[Header("Worker Slot")]
	[SerializeField]
	private Transform area_slot;

	[SerializeField]
	private List<GameObject> list_slot;

	[Header("Manager")]
	[SerializeField]
	private GameObject ManagerLvLimitObj;

	[SerializeField]
	private Image ManagerIconImg;

	[SerializeField]
	private Text NeedManagerLvText;

	[SerializeField]
	private Button ManagerInfoBtn;

	private int BuildingIdx;

	private int MaxWorkerCount;

	private int HiredWorkerCount;

	private int CanBeHiredWorkerCount;

	private int ProductionWorkerCount;

	private int FacilityIdx;

	private bool bExistManager;

	private List<int> NeedManagerLevelInfos;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetInfo(int building_idx)
	{
	}

	private void SetBuildingName(string nameKey)
	{
	}

	private void SetWorkshopImage(string imgKey)
	{
	}

	private void SetProductIcon(string iconKey)
	{
	}

	private void SetWorkerCountText(int hiredWorkerCnt, int maxWorkerCnt)
	{
	}

	private void SetManagerIconImg(string imgKey)
	{
	}

	private void UpdateWorkerStateSlots()
	{
	}

	private void UpdateButtonState()
	{
	}

	private void UpdateManagerInfo()
	{
	}

	private void OnClickPlus()
	{
	}

	private void OnClickMinus()
	{
	}

	private void OnClickManagerInfo(ItemWorkshopWorkerFacilitySlot.E_SlotState slotState)
	{
	}

	private void OnChangedHiredWorkerCount(int hiredWorkerCount)
	{
	}

	private void OnChangedProductionWorkerCount(int productionWorkerCount)
	{
	}

	private void UpdateManagerLevelInfo(int level)
	{
	}
}
