using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Seasonal/SeasonalRoomOpen", true)]
[FloatingDepth(11)]
public class InGameBuildingInConstructionUI : InGameFloatingUI
{
	[SerializeField]
	private GameObject DefaultBgObject;

	[SerializeField]
	private GameObject ConstructCompleteObj;

	[SerializeField]
	private GameObject ConstructionObj;

	[SerializeField]
	private GameObject UpgradableObj;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button BuildingFastBtn;

	private int BuildingIdx;

	private int NowFacilityLevel;

	private BigInteger NowHasCost_PerMile;

	private int UpgradeNeedFacilityLevel;

	private BigInteger UpgradeNeedCost_Origin;

	private bool bSatisfyUpgradeCost;

	private DateTime ConstructionCompleteDateTime;

	private int TotalConstructTime;

	private List<GameObject> ConstructionGameObjectList;

	private CompositeDisposable Disposables;

	public void Awake()
	{
		Disposables = new CompositeDisposable();
		ConstructionGameObjectList = new List<GameObject>();
		if (BuildingFastBtn != null)
			BuildingFastBtn.onClick.AddListener(OnClickedBuildingFastBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void SetBuildingInfo(in int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null) return;
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null) return;
		if (!buildingDataMap.TryGetValue(buildingIdx, out var buildingData)) return;

		bool isConstruction = buildingData.IsConstruction != null && buildingData.IsConstruction.Value;
		bool isOpen = buildingData.IsOpen != null && buildingData.IsOpen.Value;
		ConstructionCompleteDateTime = buildingData.ConstructionCompleteDateTime;

		if (isOpen)
		{
			UpdateUpgradeCondition();
		}
		else
		{
			UpdateViewState(isConstruction);
		}
	}

	public void HideCompleteNotice()
	{
		if (ConstructCompleteObj != null) ConstructCompleteObj.SetActive(false);
	}

	private void UpdateViewState(bool isConstruction)
	{
		if (ConstructionObj != null) ConstructionObj.SetActive(isConstruction);
		if (ConstructCompleteObj != null) ConstructCompleteObj.SetActive(false);
		if (UpgradableObj != null) UpgradableObj.SetActive(false);
	}

	protected override void Update()
	{
		base.Update();
		UpdateTimeText();
	}

	private void UpdateTimeText()
	{
		if (RemainTimeText == null) return;
		var remain = ConstructionCompleteDateTime - DateTime.UtcNow;
		if (remain.TotalSeconds <= 0)
		{
			RemainTimeText.text = "00:00";
			if (ConstructCompleteObj != null) ConstructCompleteObj.SetActive(true);
			if (ConstructionObj != null) ConstructionObj.SetActive(false);
		}
		else
		{
			RemainTimeText.text = string.Format("{0:D2}:{1:D2}", (int)remain.TotalMinutes, remain.Seconds);
		}
	}

	private void UpdateBuildingCondition(int facilityLevel)
	{
		NowFacilityLevel = facilityLevel;
		UpdateUpgradeCondition();
	}

	private void UpdateUpgradeCondition()
	{
		bSatisfyUpgradeCost = NowHasCost_PerMile >= UpgradeNeedCost_Origin;
		bool canUpgrade = bSatisfyUpgradeCost && NowFacilityLevel >= UpgradeNeedFacilityLevel;
		if (UpgradableObj != null) UpgradableObj.SetActive(canUpgrade);
	}

	private void OnClickedBuildingFastBtn()
	{
		// Show fast complete confirmation popup
	}

	private void OnConfirmedFastOpen()
	{
		// Fast complete construction via gem spending
	}
}
