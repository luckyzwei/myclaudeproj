using System.Collections.Generic;
using Treeplla;
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
		Disposables = new CompositeDisposable();
		WorkerSlots = new List<ItemWorkshopWorkerFacilitySlot>();
		NeedManagerLevelInfos = new List<int>();

		if (WorkerFireBtn != null) WorkerFireBtn.onClick.AddListener(OnClickedWorkerFireBtn);
		if (WorkerHireBtn != null) WorkerHireBtn.onClick.AddListener(OnClickedWorkerHireBtn);
		if (ManagerButton != null) ManagerButton.onClick.AddListener(OnClickedManagerButton);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void SetFacilityInfo(in int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		Refresh();
	}

	private void Refresh()
	{
		CreateAndSetWorkerSlots(HiredWorkerCount, MaxWorkerCount, ProductionWorkerCount);
		UpdateManagerLevelInfo();
		SetNewWorkerHireLayout();
	}

	public void ShowArrow()
	{
		if (ArrowObj != null) ArrowObj.SetActive(true);
	}

	private void CreateAndSetWorkerSlots(int hiredCnt, int maxCnt, int productionWorkerCnt)
	{
		WorkerSlots.Clear();
		if (WorkerSlotListObject == null || WorkerSlotPrefab == null) return;

		for (int i = WorkerSlotListObject.transform.childCount - 1; i >= 0; i--)
			Object.Destroy(WorkerSlotListObject.transform.GetChild(i).gameObject);

		for (int i = 0; i < maxCnt; i++)
		{
			GameObject slotObj = Object.Instantiate(WorkerSlotPrefab, WorkerSlotListObject.transform);
			var slot = slotObj.GetComponent<ItemWorkshopWorkerFacilitySlot>();
			if (slot != null) WorkerSlots.Add(slot);
		}
	}

	private void SetManagerIcon(string path)
	{
		if (NeedManagerIconImage == null) return;
		Sprite sprite = Resources.Load<Sprite>(path);
		if (sprite != null) NeedManagerIconImage.sprite = sprite;
	}

	private void SetNewWorkerHireLayout()
	{
		bool canHire = CanBeHireWorkerCnt > 0 && HiredWorkerCount < MaxWorkerCount;
		if (WorkerHireBtn != null) WorkerHireBtn.interactable = canHire;
		if (WorkerFireBtn != null) WorkerFireBtn.interactable = HiredWorkerCount > 0;
	}

	private void OnClickedWorkerFireBtn()
	{
		if (HiredWorkerCount <= 0) return;
		HireWorkerTryCount = -1;
		OnChangeWorkerCount(HiredWorkerCount - 1, MaxWorkerCount, ProductionWorkerCount);
	}

	private void OnClickedWorkerHireBtn()
	{
		if (CanBeHireWorkerCnt <= 0) return;
		if (HiredWorkerCount >= MaxWorkerCount) return;
		HireWorkerTryCount = 1;
		OnChangeWorkerCount(HiredWorkerCount + 1, MaxWorkerCount, ProductionWorkerCount);
	}

	private void OnClickedManagerButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickedPauseStateWorkerIcon(ItemWorkshopWorkerFacilitySlot.E_SlotState slotState)
	{
		if (slotState == ItemWorkshopWorkerFacilitySlot.E_SlotState.PauseProduction)
			Refresh();
	}

	private void OnChangeWorkerCount(int hiredWorkerCnt, int maxWorkerCnt, int productionWorkerCount)
	{
		HiredWorkerCount = hiredWorkerCnt;
		MaxWorkerCount = maxWorkerCnt;
		ProductionWorkerCount = productionWorkerCount;
		Refresh();
	}

	private void OnChangeManagerLevelInfo(int level)
	{
		ManagerLevel = level;
		UpdateManagerLevelInfo();
	}

	private void UpdateManagerLevelInfo()
	{
		if (NeedManagerConditionObject != null)
			NeedManagerConditionObject.SetActive(!bExistManager);
		if (NeedManagerLevelText != null)
			NeedManagerLevelText.text = "Lv." + ManagerLevel.ToString();
	}
}
