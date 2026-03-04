using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using UniRx;
using UnityEngine;

public class ConstructableBuildingBase : BuildingBase
{
	[Header("Building")]
	[SerializeField]
	private GameObject UnConstructObj;

	[SerializeField]
	protected GameObject ConstructObj;

	[SerializeField]
	protected GameObject ConstructFxObj;

	[SerializeField]
	protected GameObject BuildingPreviewObj;

	[SerializeField]
	protected GameObject InConstructionObj;

	[SerializeField]
	protected GameObject BuildingObj;

	[SerializeField]
	private GameObject BuildingOpenFx;

	[SerializeField]
	protected Transform ConstructionUITransform;

	[SerializeField]
	protected List<GameObject> BuildingDoorObjs;

	[Header("Facility")]
	[SerializeField]
	protected GameObject CharTransParentsObj;

	[Header("Sound")]
	[SerializeField]
	protected string BuildingConstructSoundName;

	[SerializeField]
	protected string BuildingConstructCompleteSoundName;

	protected bool IsOpenable;

	protected bool IsOpen;

	private List<GameObject> BuildingViewObjects;

	protected List<BuildingFacility> SubFacilities;

	protected Dictionary<E_BuildingFacilityAbilityType, int> FacilityLevelIndex;

	protected InGameBuildingInConstructionUI BuildingInConstructionUI;

	protected InGameSeasonalWorkerBubbleUI WorkerBubbleUI;

	protected CompositeDisposable OpenableEventDisposables;

	protected CompositeDisposable Disposables;

	private bool isResourceInit;

	public E_BuildingState BuildingState { get; private set; }

	public List<Transform> CharTransObjList { get; protected set; }

	public List<BuildingFacility> WorkerFacilities { get; protected set; }

	protected virtual void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Init(in int buildingIdx)
	{
	}

	public override void OnSelectedBuilding(Action onSelectedBuilding)
	{
	}

	protected override void OnReleaseBuilding()
	{
	}

	public override void UnselectBuilding(bool bHideUI)
	{
	}

	public void ChangeBuildingState(in E_BuildingState newState)
	{
	}

	private E_BuildingState GetInitialBuildingState(in SeasonalBuildingData buildingData)
	{
		return default(E_BuildingState);
	}

	protected virtual void SubscribeSeasonalEvent()
	{
	}

	private void OnChangedOpenableBuildingIdx(int openableBuildingIdx)
	{
	}

	private void OnChangedOpenState(bool isOpen)
	{
	}

	private void OnChangedInConstruction(bool isConstruction)
	{
	}

	private void OnChangeHasMoneyValue(BigInteger hasMoney_PerMile)
	{
	}

	private void OpenUI_Construct(Action onOpened)
	{
	}

	protected virtual void OnOpenedBuilding()
	{
	}

	public virtual void OpenUI_BuildingMenu(Action onOpened)
	{
	}

	private void LoadConstructionUI()
	{
	}

	private void LoadWorkerBubbleUI()
	{
	}

	public void CheckAndHideCompleteNotice()
	{
	}

	private void SetConstructablePreview(in bool bSet)
	{
	}

	private void SetBlockAStarRoad(bool bBlock)
	{
	}

	private void OnChangeMaxWorkerCount(int hiredCount)
	{
	}

	private void OnChangeFacilityLevelup(int facilityIdx, E_BuildingFacilityAbilityType abilityType, int level)
	{
	}

	private void UpdateFacilityResources(int facilityIdx, E_BuildingFacilityAbilityType abilityType, int facilityLevelIndex)
	{
	}

	private void OnShowSmokeForResource()
	{
	}

	private void OnShowSmokeForAddFacility(Pair<int> hiredCount)
	{
	}

	protected void PlayBuildingConstructSound()
	{
	}

	protected void PlayBuildingConstructCompleteSound()
	{
	}
}
