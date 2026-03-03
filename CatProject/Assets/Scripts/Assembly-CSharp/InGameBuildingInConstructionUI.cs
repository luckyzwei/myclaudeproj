using System;
using System.Collections.Generic;
using System.Numerics;
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
	}

	private void OnDestroy()
	{
	}

	public void SetBuildingInfo(in int buildingIdx)
	{
	}

	public void HideCompleteNotice()
	{
	}

	private void UpdateViewState(bool isConstruction)
	{
	}

	protected override void Update()
	{
	}

	private void UpdateTimeText()
	{
	}

	private void UpdateBuildingCondition(int facilityLevel)
	{
	}

	private void UpdateUpgradeCondition()
	{
	}

	private void OnClickedBuildingFastBtn()
	{
	}

	private void OnConfirmedFastOpen()
	{
	}
}
