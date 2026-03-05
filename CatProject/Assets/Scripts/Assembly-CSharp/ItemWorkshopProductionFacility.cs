using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		Disposables = new CompositeDisposable();
		if (UpgradeBtn != null)
			UpgradeBtn.OnPressed = OnClickedUpgradeBtn;
		if (UpgradeBlockBtn != null)
			UpgradeBlockBtn.onClick.AddListener(OnClickedUpgradeBlockBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void SetFacilityInfo(in int buildingIdx, in int facilityIdx)
	{
		BuildingIdx = buildingIdx;
		FacilityIdx = facilityIdx;
	}

	private void SubscribeEvents(SeasonalBuildingFacilityData facilityData)
	{
		if (facilityData == null) return;
		if (facilityData.Level != null)
		{
			facilityData.Level.Subscribe(level => UpdateFacilityLevel(level)).AddTo(Disposables);
		}
	}

	private void OnUpdateManagerLevel(int level)
	{
		ManagerLevel = level;
		UpdateLevelUpCondition();
	}

	private void UpdateFacilityLevel(int level)
	{
		FacilityLevel = level;
		SetLevelText(level);
		UpdateLevelUpCondition();
		UpdateMilestoneInfo();
	}

	private void UpdateLevelUpCondition()
	{
		bool isMax = IsMaxLevel(FacilityLevel);
		bool isCurStepMax = IsCurStepMaxLevel(FacilityLevel);
		SetActiveCostInfo(!isMax);
		SetUpgradeButtonInteractable(!isMax && !isCurStepMax);
		if (isMax)
			SetMaxLevelOverlayObj();
	}

	private void UpdateMilestoneInfo()
	{
		int nextLevel = FacilityLevel + 1;
		float upgradeRatio = (FacilityCurStepMaxLevel > 0) ? (float)FacilityLevel / FacilityCurStepMaxLevel : 0f;
		UpdateMilestoneInfoVisibility(nextLevel, upgradeRatio);
	}

	private void UpdateMilestoneInfoVisibility(int nextLevel, float upgradeRatio)
	{
		bool showMilestone = IsNeedShowMilestoneInfo(nextLevel);
		if (MilestoneAbilityIcon != null)
			MilestoneAbilityIcon.gameObject.SetActive(showMilestone);
		if (MilestoneAbilityValueText != null)
			MilestoneAbilityValueText.gameObject.SetActive(showMilestone);
		SetUpgradeProgressSlider(upgradeRatio);
	}

	private void SetActiveCostInfo(bool active)
	{
		if (UpgradeCostIconImage != null)
			UpgradeCostIconImage.gameObject.SetActive(active);
		if (UpgradeCostText != null)
			UpgradeCostText.gameObject.SetActive(active);
	}

	private void SetNameText(string nameKey)
	{
		if (NameText != null)
			NameText.text = nameKey;
	}

	private void SetNextLevelAbilityValueText(BigInteger value_PerMile)
	{
		if (LevelAbilityValueText != null)
			LevelAbilityValueText.text = ProjectUtility.GetThousandCommaText(value_PerMile);
	}

	private void SetFacilityAbilityIcon(string iconKey)
	{
		// Set facility ability icon sprite by key
	}

	private void SetFacilityIconImage(string iconKey)
	{
		// Set main facility image sprite by key
	}

	private void SetMilestoneAbilityIcon(string iconKey)
	{
		// Set milestone ability icon sprite by key
	}

	private void SetMilestoneAbilityValueText(float value, E_ValueSignType valueSignType, E_BuildingFacilityAbilityType milestoneAbilityType)
	{
		if (MilestoneAbilityValueText == null) return;
		string prefix = "";
		switch (valueSignType)
		{
			case E_ValueSignType.Multiply: prefix = "x"; break;
			case E_ValueSignType.Add: prefix = "+"; break;
			case E_ValueSignType.Subtraction: prefix = "-"; break;
		}
		MilestoneAbilityValueText.text = prefix + value.ToString("F1");
	}

	private void SetUpgradeCostIconImage(string iconKey)
	{
		// Set upgrade cost icon sprite by key
	}

	private void SetUpgradeCostValueText(BigInteger needValue_PerMile, BigInteger hasValue_PerMile)
	{
		// UpgradeCostText is ProgressText (DLL type) - set cost display
	}

	private void SetLevelText(int level)
	{
		if (LevelText != null)
			LevelText.text = "Lv." + level;
	}

	private void SetUpgradeProgressSlider(float progressRatio)
	{
		if (UpgradeProgressSlider != null)
			UpgradeProgressSlider.value = Mathf.Clamp01(progressRatio);
	}

	private void SetUpgradeButtonInteractable(bool interactable)
	{
		if (UpgradeBtn != null)
			UpgradeBtn.Interactable = interactable;
	}

	private void SetMaxLevelOverlayObj()
	{
		if (MaxLevelOverlayObj != null)
			MaxLevelOverlayObj.SetActive(true);
		if (UpgradeBtn != null)
			UpgradeBtn.gameObject.SetActive(false);
	}

	private void OnClickedUpgradeBtn()
	{
		if (IsMaxLevel(FacilityLevel)) return;
		OnLevelUpFacility?.Invoke();
	}

	private void OnClickedUpgradeBlockBtn()
	{
		// Show blocked upgrade info
	}

	private bool IsCurStepMaxLevel(int level)
	{
		return FacilityCurStepMaxLevel > 0 && level >= FacilityCurStepMaxLevel;
	}

	private bool IsMaxLevel(int level)
	{
		return FacilityMaxLevel > 0 && level >= FacilityMaxLevel;
	}

	private bool IsNeedShowMilestoneInfo(int nextLevel)
	{
		return PROGRESS_ONE_STEP_LEVEL > 0 && nextLevel % PROGRESS_ONE_STEP_LEVEL == 0;
	}

	private bool IsShowBuildingFacilityAbilityType()
	{
		return FacilityAbilityType != E_BuildingFacilityAbilityType.None;
	}

	private void Reset()
	{
		FacilityLevel = 0;
		ManagerLevel = 0;
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	public Transform GetUpgradeBtnTransform()
	{
		if (UpgradeBtn != null)
			return UpgradeBtn.transform;
		return null;
	}
}
