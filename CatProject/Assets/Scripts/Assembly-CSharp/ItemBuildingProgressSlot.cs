using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBuildingProgressSlot : MonoBehaviour
{
	[SerializeField]
	private Text BuildingNameText;

	[SerializeField]
	private Image BuildingImage;

	[Header("Level")]
	[SerializeField]
	private Text BuildingPrevLvText;

	[SerializeField]
	private Text BuildingNextLvText;

	[SerializeField]
	private GameObject BuildingLvArrowObj;

	[Header("Time")]
	[SerializeField]
	private Text BuildingRemainTimeText;

	[SerializeField]
	private Slider BuildingProgressSlider;

	[Header("Cost")]
	[SerializeField]
	private Button BuildingImmediatelyCompleteBtn;

	[SerializeField]
	private Text BuildingImmediatelyCompleteCostText;

	[Header("State")]
	[SerializeField]
	private GameObject ConstructionObj;

	[SerializeField]
	private GameObject ConstructWaitingObj;

	[SerializeField]
	private GameObject LockedObj;

	private DateTime ConstructionCompleteDateTime;

	private int TotalConstructTimeSec;

	private int ImmediatelyCompleteCostValue;

	private List<GameObject> SlotStateObjList;

	public int BuildingIdx { get; private set; }

	private void Awake()
	{
		SlotStateObjList = new List<GameObject> { ConstructionObj, ConstructWaitingObj, LockedObj };
		if (BuildingImmediatelyCompleteBtn != null)
			BuildingImmediatelyCompleteBtn.onClick.AddListener(OnClickedBuildingImmediatelyCompleteBtn);
	}

	private void Update()
	{
		if (ConstructionObj != null && ConstructionObj.activeSelf)
			UpdateTimeText();
	}

	public void SetConstructBuilding(int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		SetSlotState(ConstructionObj);
	}

	public void SetConstructWaiting()
	{
		SetSlotState(ConstructWaitingObj);
	}

	public void SetLocked()
	{
		SetSlotState(LockedObj);
	}

	private void SetSlotState(GameObject activeObj)
	{
		if (SlotStateObjList != null)
		{
			for (int i = 0; i < SlotStateObjList.Count; i++)
			{
				if (SlotStateObjList[i] != null)
					SlotStateObjList[i].SetActive(SlotStateObjList[i] == activeObj);
			}
		}
	}

	private void SetBuildingNameText(string nameKey)
	{
		if (BuildingNameText != null)
			BuildingNameText.text = nameKey;
	}

	private void SetBuildingImg(string imgKey)
	{
		// Set building image sprite by key
	}

	private void SetBuildingLevelInfo(int prevLv, int nextLv)
	{
		if (BuildingPrevLvText != null)
			BuildingPrevLvText.text = "Lv." + prevLv;
		if (BuildingNextLvText != null)
			BuildingNextLvText.text = "Lv." + nextLv;
		if (BuildingLvArrowObj != null)
			BuildingLvArrowObj.SetActive(true);
	}

	private void OnClickedBuildingImmediatelyCompleteBtn()
	{
		// Instantly complete construction with gem cost
	}

	private void UpdateTimeText()
	{
		if (ConstructionCompleteDateTime <= DateTime.MinValue) return;
		int remainSec = (int)(ConstructionCompleteDateTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec <= 0)
		{
			if (BuildingRemainTimeText != null)
				BuildingRemainTimeText.text = "00:00:00";
			if (BuildingProgressSlider != null)
				BuildingProgressSlider.value = 1f;
			return;
		}
		if (BuildingRemainTimeText != null)
		{
			var ts = TimeSpan.FromSeconds(remainSec);
			BuildingRemainTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
		}
		if (BuildingProgressSlider != null && TotalConstructTimeSec > 0)
			BuildingProgressSlider.value = 1f - (float)remainSec / TotalConstructTimeSec;
	}
}
