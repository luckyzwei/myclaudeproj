using System.Collections.Generic;
using Treeplla;
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
		Disposables = new CompositeDisposable();
		NeedManagerLevelInfos = new List<int>();

		if (btn_plus != null) btn_plus.onClick.AddListener(OnClickPlus);
		if (btn_minus != null) btn_minus.onClick.AddListener(OnClickMinus);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void SetInfo(int building_idx)
	{
		BuildingIdx = building_idx;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateWorkerStateSlots();
		UpdateButtonState();
		UpdateManagerInfo();
	}

	private void SetBuildingName(string nameKey)
	{
		if (text_workshop_name != null) text_workshop_name.text = nameKey;
	}

	private void SetWorkshopImage(string imgKey)
	{
		if (img_workshop == null) return;
		Sprite sprite = Resources.Load<Sprite>(imgKey);
		if (sprite != null) img_workshop.sprite = sprite;
	}

	private void SetProductIcon(string iconKey)
	{
		if (img_currency_icon == null) return;
		Sprite sprite = Resources.Load<Sprite>(iconKey);
		if (sprite != null) img_currency_icon.sprite = sprite;
	}

	private void SetWorkerCountText(int hiredWorkerCnt, int maxWorkerCnt)
	{
		if (text_worker_count != null)
			text_worker_count.text = hiredWorkerCnt + "/" + maxWorkerCnt;
	}

	private void SetManagerIconImg(string imgKey)
	{
		if (ManagerIconImg == null) return;
		Sprite sprite = Resources.Load<Sprite>(imgKey);
		if (sprite != null) ManagerIconImg.sprite = sprite;
	}

	private void UpdateWorkerStateSlots()
	{
		if (list_slot == null) return;
		for (int i = 0; i < list_slot.Count; i++)
		{
			if (list_slot[i] == null) continue;
			list_slot[i].SetActive(i < MaxWorkerCount);
		}
	}

	private void UpdateButtonState()
	{
		bool canHire = CanBeHiredWorkerCount > 0 && HiredWorkerCount < MaxWorkerCount;
		bool canFire = HiredWorkerCount > 0;
		if (btn_plus != null) btn_plus.interactable = canHire;
		if (btn_minus != null) btn_minus.interactable = canFire;
	}

	private void UpdateManagerInfo()
	{
		if (ManagerLvLimitObj != null) ManagerLvLimitObj.SetActive(!bExistManager);
	}

	private void OnClickPlus()
	{
		if (HiredWorkerCount >= MaxWorkerCount) return;
		if (CanBeHiredWorkerCount <= 0) return;
		HiredWorkerCount++;
		CanBeHiredWorkerCount--;
		OnChangedHiredWorkerCount(HiredWorkerCount);
	}

	private void OnClickMinus()
	{
		if (HiredWorkerCount <= 0) return;
		HiredWorkerCount--;
		CanBeHiredWorkerCount++;
		OnChangedHiredWorkerCount(HiredWorkerCount);
	}

	private void OnClickManagerInfo(ItemWorkshopWorkerFacilitySlot.E_SlotState slotState)
	{
		// Handle click
	}

	private void OnChangedHiredWorkerCount(int hiredWorkerCount)
	{
		HiredWorkerCount = hiredWorkerCount;
		SetWorkerCountText(HiredWorkerCount, MaxWorkerCount);
		UpdateWorkerStateSlots();
		UpdateButtonState();
	}

	private void OnChangedProductionWorkerCount(int productionWorkerCount)
	{
		ProductionWorkerCount = productionWorkerCount;
		UpdateWorkerStateSlots();
	}

	private void UpdateManagerLevelInfo(int level)
	{
		if (NeedManagerLvText != null) NeedManagerLvText.text = "Lv." + level.ToString();
	}
}
