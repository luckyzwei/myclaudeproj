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
	}

	private void Update()
	{
	}

	public void SetConstructBuilding(int buildingIdx)
	{
	}

	public void SetConstructWaiting()
	{
	}

	public void SetLocked()
	{
	}

	private void SetBuildingNameText(string nameKey)
	{
	}

	private void SetBuildingImg(string imgKey)
	{
	}

	private void SetBuildingLevelInfo(int prevLv, int nextLv)
	{
	}

	private void OnClickedBuildingImmediatelyCompleteBtn()
	{
	}

	private void UpdateTimeText()
	{
	}
}
