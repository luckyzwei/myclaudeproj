using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupItemProduction", false, false)]
public class PopupWorkshopMenu : UIBase
{
	[SerializeField]
	private Text BuildingNameText;

	[SerializeField]
	private Text BuildingLevelText;

	[SerializeField]
	private Button PrevBuildingBtn;

	[SerializeField]
	private Button NextBuildingBtn;

	[SerializeField]
	private GameObject WorkshopHeaderObj;

	[SerializeField]
	private GameObject DormitoryHeaderObj;

	[Header("Dormitory Header")]
	[SerializeField]
	private GameObject DormitoryWorkerIconListObj;

	[SerializeField]
	private GameObject DormitoryWorkerIconPrefab;

	[SerializeField]
	private Text DormitoryWorkerCountText;

	[Header("Production Header")]
	[SerializeField]
	private GameObject ProductionCostBox;

	[SerializeField]
	private GameObject ProductionOutputBox;

	[SerializeField]
	private ItemWorkshopResource ProductionNeedTime;

	[Header("Manager")]
	[SerializeField]
	private GameObject ManagerObj;

	[SerializeField]
	private Button ManagerLevelUpBtn;

	[SerializeField]
	private Image ManagerIconImage;

	[SerializeField]
	private Text ManagerLevelText;

	[SerializeField]
	private Image ManagerAbilityIconImage;

	[SerializeField]
	private Text ManagerAbilityText;

	[SerializeField]
	private GameObject ManagerRedDot;

	[SerializeField]
	private GameObject ManagerInnerObj;

	[Header("Upgrade")]
	[SerializeField]
	private Button BuildingUpgradeMenuOpenBtn;

	[SerializeField]
	private GameObject BuildingUpgradeReddot;

	[SerializeField]
	private GameObject BuildingUpgradeHighLight;

	[SerializeField]
	private Slider BuildingUpgradeGauge;

	[SerializeField]
	private ItemWorkshopUpgradeMenu BuildingUpgradeMenu;

	[SerializeField]
	private List<ItemWorkshopProductionFacility> ProductionFacilities;

	[SerializeField]
	private ItemWorkshopWorkerFacility WorkerFacility;

	[SerializeField]
	private ItemWorkshopRestaurantFacility RestaurantFacility;

	[Header("ProductInfoBox")]
	[SerializeField]
	private ItemWorkshopProductInfoBox ProductInfoBox;

	private List<ItemWorkshopResource> ProductionCostResources;

	private List<ItemWorkshopResource> ProductionOutputResources;

	private List<Image> DormitoryWorkerSlots;

	private int BuildingIdx;

	private int BuildingLevel;

	private int ManagerLevel;

	private int MainFacilityIdx;

	private KeyValuePair<int, int> UpgradeConditionFacilityLvRange;

	private CompositeDisposable Disposables;

	public int SavedPiggyCount { get; set; }

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		ProductionCostResources = new List<ItemWorkshopResource>();
		ProductionOutputResources = new List<ItemWorkshopResource>();
		DormitoryWorkerSlots = new List<Image>();
		SavedPiggyCount = 0;

		if (PrevBuildingBtn != null) PrevBuildingBtn.onClick.AddListener(OnClickedPrevBuildingBtn);
		if (NextBuildingBtn != null) NextBuildingBtn.onClick.AddListener(OnClickedNextBuildingBtn);
		if (BuildingUpgradeMenuOpenBtn != null) BuildingUpgradeMenuOpenBtn.onClick.AddListener(OnClickedBuildingUpgradeMenuOpenBtn);
		if (ManagerLevelUpBtn != null) ManagerLevelUpBtn.onClick.AddListener(OnClickedManagerLevelUpBtn);
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Get building data from UserData
		SetBuildingInfo("", 1);
	}

	private void OnClickedPrevBuildingBtn()
	{
		if (BuildingIdx > 0)
			SetBuildingInfo(BuildingIdx - 1);
	}

	private void OnClickedNextBuildingBtn()
	{
		SetBuildingInfo(BuildingIdx + 1);
	}

	private void OnClickedBuildingUpgradeMenuOpenBtn()
	{
		if (BuildingUpgradeMenu != null)
			BuildingUpgradeMenu.gameObject.SetActive(true);
	}

	private void OnClickedManagerLevelUpBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupManagerLevelUp>();
	}

	private void OnClosedBuildingUpgradeMenu()
	{
		if (BuildingUpgradeMenu != null)
			BuildingUpgradeMenu.gameObject.SetActive(false);
	}

	private void OnLevelUpFacility()
	{
		SetBuildingInfo(BuildingIdx);
		UpdateUpgradeMenuBtnReddot();
	}

	public override void OnHideBefore()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void SetBuildingInfo(string name, int level)
	{
		BuildingLevel = level;
		if (BuildingNameText != null) BuildingNameText.text = name;
		if (BuildingLevelText != null) BuildingLevelText.text = "Lv." + level;
	}

	private void SetFacilityInfos(SeasonalBuildingData buildingData)
	{
		if (buildingData == null || ProductionFacilities == null) return;
		// Set production facilities info
		bool isDormitory = buildingData.BuildingType == E_BuildingType.Dormitory;
		if (WorkshopHeaderObj != null) WorkshopHeaderObj.SetActive(!isDormitory);
		if (DormitoryHeaderObj != null) DormitoryHeaderObj.SetActive(isDormitory);
	}

	private bool CheckCanBeHireWorker()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	private void SetDormitoryWorker(int maxWorkerCnt, int activeWorkerCnt)
	{
		if (DormitoryWorkerCountText != null)
			DormitoryWorkerCountText.text = activeWorkerCnt + "/" + maxWorkerCnt;
		// Create/update worker icon slots
		if (DormitoryWorkerIconListObj == null || DormitoryWorkerIconPrefab == null) return;
	}

	private void SetProductIcon(List<int> productIdxList, GameObject productBox, ref List<ItemWorkshopResource> resourceList, bool isCost)
	{
		if (productIdxList == null || productBox == null) return;
		if (resourceList == null) resourceList = new List<ItemWorkshopResource>();
		// Create resource icons for each product
	}

	private void SetManagerInfo(SeasonalWorkshopManagerData managerData, string abilityIconKey)
	{
		if (ManagerObj == null) return;
		if (managerData == null)
		{
			ManagerObj.SetActive(false);
			return;
		}
		ManagerObj.SetActive(true);
		ManagerLevel = managerData.Level.Value;
		SetManagerLevelText(managerData.Level.Value, false);
		if (ManagerAbilityIconImage != null)
		{
			// Set ability icon
		}
	}

	private void SetManagerLevelText(int level, bool bMaxLv)
	{
		if (ManagerLevelText != null)
			ManagerLevelText.text = bMaxLv ? "MAX" : "Lv." + level;
	}

	private void SetManagerAbilityText(BigInteger abilityValue)
	{
		if (ManagerAbilityText != null)
			ManagerAbilityText.text = ProjectUtility.GetThousandCommaText(abilityValue);
	}

	private void SetBuildingUpgradeMenu(SeasonalBuildingData buildingData)
	{
		if (BuildingUpgradeMenu == null || buildingData == null) return;
		// Initialize building upgrade menu with building data
		UpdateUpgradeMenuBtnReddot();
	}

	private void OnChangeBuildingConstruction(bool inConstruction)
	{
	}

	private void OnChangeManagerLevel()
	{
		UpdateManagerLevelUpRedDot();
	}

	private void OnChangeFacilityLevel(int facilityLevel, int facilityIdx, E_BuildingFacilityAbilityType abilityType)
	{
		UpdateBuildingUpgradeInfo(facilityLevel);
	}

	private void OnChangeHiredWorkerCount(int hiredCount)
	{
	}

	private void UpdateBuildingUpgradeInfo(int facilityLevel)
	{
		if (BuildingUpgradeGauge != null)
		{
			// Update upgrade progress gauge
		}
		UpdateUpgradeMenuBtnReddot();
	}

	private void UpdateProductionCostValue(SeasonalWorkshopData workshopData)
	{
		if (workshopData == null) return;
		// Update production cost display values
	}

	private void UpdateProductionListValues(List<ItemWorkshopResource> resourceList, List<BigInteger> productionValues_PerMile)
	{
		if (resourceList == null || productionValues_PerMile == null) return;
		for (int i = 0; i < resourceList.Count && i < productionValues_PerMile.Count; i++)
		{
			if (resourceList[i] != null)
			{
				// Update resource display value
			}
		}
	}

	private void UpdateProductionCoolTime(long productionCoolTimeMs)
	{
		if (ProductionNeedTime == null) return;
		// Update production cooldown time display
	}

	private void UpdateManagerLevelUpRedDot()
	{
		if (ManagerRedDot == null) return;
		ManagerRedDot.SetActive(false);
		// Check if manager can be leveled up
	}

	private void SubscribeEvents(SeasonalBuildingData buildingData)
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
		if (buildingData == null) return;
		// Subscribe to building data change events
	}

	private void ActiveReadyObjectCount(List<ItemWorkshopResource> resourceObjects, int needCount)
	{
		if (resourceObjects == null) return;
		for (int i = 0; i < resourceObjects.Count; i++)
		{
			if (resourceObjects[i] != null)
				resourceObjects[i].gameObject.SetActive(i < needCount);
		}
	}

	public void ShowUpgradeMenuBtnHighLight()
	{
		if (BuildingUpgradeHighLight != null) BuildingUpgradeHighLight.SetActive(true);
	}

	public void ShowProductionCostHighlight()
	{
		if (ProductionCostBox != null)
		{
			// Highlight production cost area
		}
	}

	private void UpdateUpgradeMenuBtnReddot()
	{
		if (BuildingUpgradeReddot == null) return;
		BuildingUpgradeReddot.SetActive(false);
		// Check if any facility can be upgraded
	}

	public int GetBuildingIdx()
	{
		return BuildingIdx;
	}

	public Transform GetFirstFacilityUpgradeBtn()
	{
		if (ProductionFacilities != null && ProductionFacilities.Count > 0 && ProductionFacilities[0] != null)
			return ProductionFacilities[0].transform;
		return null;
	}
}
