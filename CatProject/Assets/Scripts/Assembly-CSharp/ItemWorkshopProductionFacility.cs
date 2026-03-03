using System.Numerics;
using SeasonalDef;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemWorkshopProductionFacility : MonoBehaviour
{
	[SerializeField]
	private Text NameText;

	[SerializeField]
	private Image MainImage;

	[SerializeField]
	private Text LevelText;

	[SerializeField]
	private Image LevelAbilityIcon;

	[SerializeField]
	private Text LevelAbilityValueText;

	[SerializeField]
	private Image MilestoneAbilityIcon;

	[SerializeField]
	private Text MilestoneAbilityValueText;

	[SerializeField]
	private Image UpgradeCostIconImage;

	[SerializeField]
	private ProgressText UpgradeCostText;

	[SerializeField]
	private ButtonPressed UpgradeBtn;

	[SerializeField]
	private Button UpgradeBlockBtn;

	[SerializeField]
	private Slider UpgradeProgressSlider;

	[SerializeField]
	private GameObject MaxLevelOverlayObj;

	private readonly int PROGRESS_ONE_STEP_LEVEL;

	private int BuildingIdx;

	private E_BuildingType BuildingType;

	private int BuildingNumber;

	private int BuildingLevel;

	private int ManagerLevel;

	private int FacilityIdx;

	private int FacilityLevel;

	private E_BuildingFacilityAbilityType FacilityAbilityType;

	private int FacilityCurStepMaxLevel;

	private int FacilityMaxLevel;

	private SeasonalProductionMassIncInfo NextMassIncInfo;

	private string MainNameKeyStr;

	private CompositeDisposable Disposables;

	public UnityAction OnLevelUpFacility;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetFacilityInfo(in int buildingIdx, in int facilityIdx)
	{
	}

	private void SubscribeEvents(SeasonalBuildingFacilityData facilityData)
	{
	}

	private void OnUpdateManagerLevel(int level)
	{
	}

	private void UpdateFacilityLevel(int level)
	{
	}

	private void UpdateLevelUpCondition()
	{
	}

	private void UpdateMilestoneInfo()
	{
	}

	private void UpdateMilestoneInfoVisibility(int nextLevel, float upgradeRatio)
	{
	}

	private void SetActiveCostInfo(bool active)
	{
	}

	private void SetNameText(string nameKey)
	{
	}

	private void SetNextLevelAbilityValueText(BigInteger value_PerMile)
	{
	}

	private void SetFacilityAbilityIcon(string iconKey)
	{
	}

	private void SetFacilityIconImage(string iconKey)
	{
	}

	private void SetMilestoneAbilityIcon(string iconKey)
	{
	}

	private void SetMilestoneAbilityValueText(float value, E_ValueSignType valueSignType, E_BuildingFacilityAbilityType milestoneAbilityType)
	{
	}

	private void SetUpgradeCostIconImage(string iconKey)
	{
	}

	private void SetUpgradeCostValueText(BigInteger needValue_PerMile, BigInteger hasValue_PerMile)
	{
	}

	private void SetLevelText(int level)
	{
	}

	private void SetUpgradeProgressSlider(float progressRatio)
	{
	}

	private void SetUpgradeButtonInteractable(bool interactable)
	{
	}

	private void SetMaxLevelOverlayObj()
	{
	}

	private void OnClickedUpgradeBtn()
	{
	}

	private void OnClickedUpgradeBlockBtn()
	{
	}

	private bool IsCurStepMaxLevel(int level)
	{
		return false;
	}

	private bool IsMaxLevel(int level)
	{
		return false;
	}

	private bool IsNeedShowMilestoneInfo(int nextLevel)
	{
		return false;
	}

	private bool IsShowBuildingFacilityAbilityType()
	{
		return false;
	}

	private void Reset()
	{
	}

	public Transform GetUpgradeBtnTransform()
	{
		return null;
	}
}
