using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using Treeplla;
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
		SubFacilities = new List<BuildingFacility>();
		FacilityLevelIndex = new Dictionary<E_BuildingFacilityAbilityType, int>();
		BuildingViewObjects = new List<GameObject>();
		CharTransObjList = new List<Transform>();
		WorkerFacilities = new List<BuildingFacility>();
		OpenableEventDisposables = new CompositeDisposable();
		Disposables = new CompositeDisposable();
	}

	private void OnDestroy()
	{
		if (OpenableEventDisposables != null) OpenableEventDisposables.Dispose();
		if (Disposables != null) Disposables.Dispose();
	}

	public override void Init(in int buildingIdx)
	{
		base.Init(buildingIdx);
		IsConstructableBuilding = true;
		IsOpen = false;
		IsOpenable = false;
		isResourceInit = false;
		SubscribeSeasonalEvent();
	}

	public override void OnSelectedBuilding(Action onSelectedBuilding)
	{
		base.OnSelectedBuilding(onSelectedBuilding);
		switch (BuildingState)
		{
			case E_BuildingState.Constructable:
				OpenUI_Construct(onSelectedBuilding);
				break;
			case E_BuildingState.Built:
			case E_BuildingState.Upgrade:
				OpenUI_BuildingMenu(onSelectedBuilding);
				break;
		}
	}

	protected override void OnReleaseBuilding()
	{
		base.OnReleaseBuilding();
		if (BuildingInConstructionUI != null)
			BuildingInConstructionUI.gameObject.SetActive(false);
		if (WorkerBubbleUI != null)
			WorkerBubbleUI.OnReleaseBuilding();
	}

	public override void UnselectBuilding(bool bHideUI)
	{
		base.UnselectBuilding(bHideUI);
		if (bHideUI)
		{
			if (BuildingInConstructionUI != null)
				BuildingInConstructionUI.Hide();
			if (WorkerBubbleUI != null)
				WorkerBubbleUI.Hide();
		}
	}

	public void ChangeBuildingState(in E_BuildingState newState)
	{
		if (BuildingState == newState) return;
		BuildingState = newState;
		bool showUnconstruct = newState == E_BuildingState.UnConstructable || newState == E_BuildingState.Constructable;
		bool showConstruction = newState == E_BuildingState.InConstruction;
		bool showBuilding = newState == E_BuildingState.Built || newState == E_BuildingState.Upgrade;
		if (UnConstructObj != null) UnConstructObj.SetActive(showUnconstruct);
		if (InConstructionObj != null) InConstructionObj.SetActive(showConstruction);
		if (BuildingObj != null) BuildingObj.SetActive(showBuilding);
		if (ConstructObj != null) ConstructObj.SetActive(newState == E_BuildingState.Constructable);
		if (BuildingPreviewObj != null) BuildingPreviewObj.SetActive(newState == E_BuildingState.Constructable);
	}

	private E_BuildingState GetInitialBuildingState(in SeasonalBuildingData buildingData)
	{
		if (buildingData == null) return E_BuildingState.UnConstructable;
		if (buildingData.IsOpen != null && buildingData.IsOpen.Value) return E_BuildingState.Built;
		if (buildingData.IsConstruction != null && buildingData.IsConstruction.Value) return E_BuildingState.InConstruction;
		if (IsOpenable) return E_BuildingState.Constructable;
		return E_BuildingState.UnConstructable;
	}

	protected virtual void SubscribeSeasonalEvent()
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null) return;

		if (!buildingDataMap.TryGetValue(BuildingIdx, out var buildingData))
			return;

		if (buildingData.IsOpen != null)
		{
			buildingData.IsOpen.Subscribe(isOpen => OnChangedOpenState(isOpen)).AddTo(Disposables);
		}

		if (buildingData.IsConstruction != null)
		{
			buildingData.IsConstruction.Subscribe(isConstruction => OnChangedInConstruction(isConstruction)).AddTo(Disposables);
		}

		if (buildingData.Level != null)
		{
			buildingData.Level.Subscribe(level =>
			{
				if (level > 0 && buildingData.FacilityDataMap != null)
				{
					foreach (var kvp in buildingData.FacilityDataMap)
					{
						var facilityData = kvp.Value;
						if (facilityData.Level != null)
						{
							OnChangeFacilityLevelup(facilityData.FacilityIdx, facilityData.FacilityAbilityType, facilityData.Level.Value);
						}
					}
				}
			}).AddTo(Disposables);
		}

		if (buildingData.FacilityDataMap != null)
		{
			foreach (var kvp in buildingData.FacilityDataMap)
			{
				var facilityData = kvp.Value;
				if (facilityData.Level != null)
				{
					int capturedFacilityIdx = facilityData.FacilityIdx;
					var capturedAbilityType = facilityData.FacilityAbilityType;
					facilityData.Level.Subscribe(level =>
					{
						OnChangeFacilityLevelup(capturedFacilityIdx, capturedAbilityType, level);
					}).AddTo(Disposables);
				}
			}
		}

		if (buildingData.WorkerData != null && buildingData.WorkerData.HiredWorkerCount != null)
		{
			buildingData.WorkerData.HiredWorkerCount.Subscribe(count =>
			{
				OnChangeMaxWorkerCount(count);
			}).AddTo(Disposables);
		}

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData?.OpenableBuildingIdxMap != null && stageData.OpenableBuildingIdxMap.TryGetValue(buildingData.BuildingType, out var openableProp))
		{
			openableProp.Subscribe(idx => OnChangedOpenableBuildingIdx(idx)).AddTo(OpenableEventDisposables);
		}

		var initialState = GetInitialBuildingState(buildingData);
		ChangeBuildingState(initialState);

		if (buildingData.IsOpen != null && buildingData.IsOpen.Value)
		{
			LoadConstructionUI();
			LoadWorkerBubbleUI();
		}
	}

	private void OnChangedOpenableBuildingIdx(int openableBuildingIdx)
	{
		IsOpenable = (openableBuildingIdx >= BuildingIdx);
		if (IsOpenable && BuildingState == E_BuildingState.UnConstructable)
			ChangeBuildingState(E_BuildingState.Constructable);
	}

	private void OnChangedOpenState(bool isOpen)
	{
		IsOpen = isOpen;
		if (isOpen)
		{
			ChangeBuildingState(E_BuildingState.Built);
			OnOpenedBuilding();
		}
	}

	private void OnChangedInConstruction(bool isConstruction)
	{
		if (isConstruction)
			ChangeBuildingState(E_BuildingState.InConstruction);
	}

	private void OnChangeHasMoneyValue(BigInteger hasMoney_PerMile)
	{
		if (BuildingInConstructionUI != null && BuildingState == E_BuildingState.Built)
		{
			// Trigger construction UI to re-evaluate upgrade conditions
			CheckAndHideCompleteNotice();
		}
	}

	private void OpenUI_Construct(Action onOpened)
	{
		PlayBuildingMenuSound();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupBuildingConstruct>((popup) =>
		{
			if (popup != null)
				popup.SetBuildingInfo(BuildingIdx);
			onOpened?.Invoke();
		});
	}

	protected virtual void OnOpenedBuilding()
	{
		if (BuildingOpenFx != null)
			BuildingOpenFx.SetActive(true);

		if (CharTransParentsObj != null)
			CharTransParentsObj.SetActive(true);

		LoadConstructionUI();
		LoadWorkerBubbleUI();

		PlayBuildingConstructCompleteSound();

		if (!isResourceInit)
		{
			isResourceInit = true;
			var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
			if (buildingDataMap != null && buildingDataMap.TryGetValue(BuildingIdx, out var buildingData))
			{
				if (buildingData.FacilityDataMap != null)
				{
					foreach (var kvp in buildingData.FacilityDataMap)
					{
						var facilityData = kvp.Value;
						int level = facilityData.Level != null ? facilityData.Level.Value : 1;
						OnChangeFacilityLevelup(facilityData.FacilityIdx, facilityData.FacilityAbilityType, level);
					}
				}
			}
		}
	}

	public virtual void OpenUI_BuildingMenu(Action onOpened)
	{
		PlayBuildingMenuSound();
		onOpened?.Invoke();
	}

	private void LoadConstructionUI()
	{
		if (BuildingInConstructionUI != null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/Seasonal/SeasonalRoomOpen");
		if (prefab == null) return;

		var go = Instantiate(prefab, transform);
		BuildingInConstructionUI = go.GetComponent<InGameBuildingInConstructionUI>();
		if (BuildingInConstructionUI != null)
		{
			BuildingInConstructionUI.Init(ConstructionUITransform != null ? ConstructionUITransform : transform, GameType.Seasonal);
			BuildingInConstructionUI.SetBuildingInfo(BuildingIdx);
		}
	}

	private void LoadWorkerBubbleUI()
	{
		if (WorkerBubbleUI != null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/Seasonal/SeasonalWorkerBubble");
		if (prefab == null) return;

		var go = Instantiate(prefab, transform);
		WorkerBubbleUI = go.GetComponent<InGameSeasonalWorkerBubbleUI>();
		if (WorkerBubbleUI != null)
		{
			WorkerBubbleUI.Init(ConstructionUITransform != null ? ConstructionUITransform : transform, GameType.Seasonal);
			WorkerBubbleUI.SetBuildingInfo(BuildingIdx);
		}
	}

	public void CheckAndHideCompleteNotice()
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null) return;

		if (!buildingDataMap.TryGetValue(BuildingIdx, out var buildingData))
			return;

		if (buildingData.bNeedCompleteNotice)
		{
			buildingData.bNeedCompleteNotice = false;
			if (BuildingInConstructionUI != null)
				BuildingInConstructionUI.HideCompleteNotice();
		}
	}

	private void SetConstructablePreview(in bool bSet)
	{
		if (BuildingPreviewObj != null)
			BuildingPreviewObj.SetActive(bSet);
		if (ConstructFxObj != null)
			ConstructFxObj.SetActive(bSet);
	}

	private void SetBlockAStarRoad(bool bBlock)
	{
	}

	private void OnChangeMaxWorkerCount(int hiredCount)
	{
		if (BuildingDoorObjs != null)
		{
			for (int i = 0; i < BuildingDoorObjs.Count; i++)
			{
				if (BuildingDoorObjs[i] != null)
					BuildingDoorObjs[i].SetActive(i < hiredCount);
			}
		}
	}

	private void OnChangeFacilityLevelup(int facilityIdx, E_BuildingFacilityAbilityType abilityType, int level)
	{
		if (level <= 0) return;

		var levelData = SeasonalTableHelper.GetFacilityLevelTable(BuildingIdx, facilityIdx);
		if (levelData == null) return;

		int maxLevel = levelData.MaxLevel;
		int facilityLevelIndex = 0;
		if (maxLevel > 0)
			facilityLevelIndex = (level - 1) * SubFacilities.Count / maxLevel;

		int prevLevelIndex = 0;
		if (FacilityLevelIndex.TryGetValue(abilityType, out int existingIndex))
			prevLevelIndex = existingIndex;

		if (facilityLevelIndex != prevLevelIndex || !isResourceInit)
		{
			FacilityLevelIndex[abilityType] = facilityLevelIndex;
			UpdateFacilityResources(facilityIdx, abilityType, facilityLevelIndex);

			if (isResourceInit)
				OnShowSmokeForResource();
		}
	}

	private void UpdateFacilityResources(int facilityIdx, E_BuildingFacilityAbilityType abilityType, int facilityLevelIndex)
	{
		if (SubFacilities == null) return;

		for (int i = 0; i < SubFacilities.Count; i++)
		{
			var facility = SubFacilities[i];
			if (facility != null)
			{
				facility.UpdateFacilityResources(facilityIdx, facilityLevelIndex);
			}
		}
	}

	private void OnShowSmokeForResource()
	{
		if (BuildingObj == null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/Fx_Seasonal_Object_Smoke");
		if (prefab == null) return;

		var go = Instantiate(prefab, BuildingObj.transform.position, UnityEngine.Quaternion.identity, transform);
		var smokeUI = go.GetComponent<Fx_Seasonal_Object_Smoke>();
		if (smokeUI != null)
		{
			smokeUI.Init(BuildingObj.transform, GameType.Seasonal);
			smokeUI.Show();
		}
	}

	private void OnShowSmokeForAddFacility(Pair<int> hiredCount)
	{
		if (hiredCount.Current <= hiredCount.Previous) return;

		if (BuildingObj == null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/Fx_Seasonal_Object_Smoke");
		if (prefab == null) return;

		var go = Instantiate(prefab, BuildingObj.transform.position, UnityEngine.Quaternion.identity, transform);
		var smokeUI = go.GetComponent<Fx_Seasonal_Object_Smoke>();
		if (smokeUI != null)
		{
			smokeUI.Init(BuildingObj.transform, GameType.Seasonal);
			smokeUI.Show();
		}
	}

	protected void PlayBuildingConstructSound()
	{
		if (string.IsNullOrEmpty(BuildingConstructSoundName)) return;
		var soundObj = gameObject.GetComponent<PlaySound>();
		if (soundObj == null)
			soundObj = gameObject.AddComponent<PlaySound>();
		soundObj.soundKey = BuildingConstructSoundName;
		soundObj.PlaySoundDirect();
	}

	protected void PlayBuildingConstructCompleteSound()
	{
		if (string.IsNullOrEmpty(BuildingConstructCompleteSoundName)) return;
		var soundObj = gameObject.GetComponent<PlaySound>();
		if (soundObj == null)
			soundObj = gameObject.AddComponent<PlaySound>();
		soundObj.soundKey = BuildingConstructCompleteSoundName;
		soundObj.PlaySoundDirect();
	}
}
