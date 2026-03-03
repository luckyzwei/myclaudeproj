using System.Collections.Generic;
using System.Numerics;
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
	}

	private void OnDestroy()
	{
	}

	public void SetBuildingInfo(in int buildingIdx)
	{
	}

	private void OnClickedPrevBuildingBtn()
	{
	}

	private void OnClickedNextBuildingBtn()
	{
	}

	private void OnClickedBuildingUpgradeMenuOpenBtn()
	{
	}

	private void OnClickedManagerLevelUpBtn()
	{
	}

	private void OnClosedBuildingUpgradeMenu()
	{
	}

	private void OnLevelUpFacility()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void SetBuildingInfo(string name, int level)
	{
	}

	private void SetFacilityInfos(SeasonalBuildingData buildingData)
	{
	}

	private bool CheckCanBeHireWorker()
	{
		return false;
	}

	private void SetDormitoryWorker(int maxWorkerCnt, int activeWorkerCnt)
	{
	}

	private void SetProductIcon(List<int> productIdxList, GameObject productBox, ref List<ItemWorkshopResource> resourceList, bool isCost)
	{
	}

	private void SetManagerInfo(SeasonalWorkshopManagerData managerData, string abilityIconKey)
	{
	}

	private void SetManagerLevelText(int level, bool bMaxLv)
	{
	}

	private void SetManagerAbilityText(BigInteger abilityValue)
	{
	}

	private void SetBuildingUpgradeMenu(SeasonalBuildingData buildingData)
	{
	}

	private void OnChangeBuildingConstruction(bool inConstruction)
	{
	}

	private void OnChangeManagerLevel()
	{
	}

	private void OnChangeFacilityLevel(int facilityLevel, int facilityIdx, E_BuildingFacilityAbilityType abilityType)
	{
	}

	private void OnChangeHiredWorkerCount(int hiredCount)
	{
	}

	private void UpdateBuildingUpgradeInfo(int facilityLevel)
	{
	}

	private void UpdateProductionCostValue(SeasonalWorkshopData workshopData)
	{
	}

	private void UpdateProductionListValues(List<ItemWorkshopResource> resourceList, List<BigInteger> productionValues_PerMile)
	{
	}

	private void UpdateProductionCoolTime(long productionCoolTimeMs)
	{
	}

	private void UpdateManagerLevelUpRedDot()
	{
	}

	private void SubscribeEvents(SeasonalBuildingData buildingData)
	{
	}

	private void ActiveReadyObjectCount(List<ItemWorkshopResource> resourceObjects, int needCount)
	{
	}

	public void ShowUpgradeMenuBtnHighLight()
	{
	}

	public void ShowProductionCostHighlight()
	{
	}

	private void UpdateUpgradeMenuBtnReddot()
	{
	}

	public int GetBuildingIdx()
	{
		return 0;
	}

	public Transform GetFirstFacilityUpgradeBtn()
	{
		return null;
	}
}
