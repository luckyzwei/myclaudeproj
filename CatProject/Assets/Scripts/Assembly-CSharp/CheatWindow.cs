using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatWindow : MonoBehaviour
{
	[SerializeField]
	private InputField inputField_Action;

	[SerializeField]
	private GameObject AuctionCheatObj;

	[SerializeField]
	private Text TimeText;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private InputField inputField2;

	[SerializeField]
	private InputField inputField_Seasonal;

	[SerializeField]
	private InputField inputField_BizAcq;

	[SerializeField]
	private GameObject MainCheatObj;

	[SerializeField]
	private GameObject MainCheat2Obj;

	[SerializeField]
	private GameObject SeasonalCheatObj;

	[SerializeField]
	private GameObject BizAcqCheatObj;

	[SerializeField]
	private GameObject SegmentCheatObj;

	[SerializeField]
	private Dropdown SeasonalCurrencyDropDown;

	public CanvasGroup cGroup_Main;

	public CanvasGroup cGroup_Event;

	[SerializeField]
	private InputField inputField_EventStart;

	[SerializeField]
	private InputField inputField_EventEnd;

	[SerializeField]
	private InputField inputField_Segment;

	[SerializeField]
	private Text ABStateText;

	[SerializeField]
	private GameObject EnemyTeamCheatObj;

	private List<List<InputField>> BizAcqEnemyStat;

	private bool ignorePower;

	[Header("MiniGame")]
	[SerializeField]
	private GameObject MiniGameCheatObj;

	[SerializeField]
	private InputField InputField_MiniGame;

	private void Awake_Action()
	{
	}

	public void ChangeAuctionCheat()
	{
	}

	public void OnClickAuctionReset()
	{
	}

	public void OnClickAuctionScoreSet()
	{
	}

	public void OnClickAuctionPassReset()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetMoney()
	{
	}

	public void SetCash()
	{
	}

	public void GetPiggyValue()
	{
	}

	public void GetLevel()
	{
	}

	public void GetExp()
	{
	}

	public void GetPower()
	{
	}

	public void GetPoint()
	{
	}

	public void GameSpeed()
	{
	}

	public void GotoStage()
	{
	}

	public void AllItemLevelUp()
	{
	}

	public void SetAllItemLevelUpPower()
	{
	}

	public void CompanyMaxLevel()
	{
	}

	public void OpenPopupListRecontract()
	{
	}

	public void Open1stEventIMain()
	{
	}

	public void SetVolume()
	{
	}

	public void ChangeLang()
	{
	}

	public void GetPlant()
	{
	}

	public void GetItem()
	{
	}

	public void SetLuckyDraw()
	{
	}

	public void SetDailyQuestResetTime()
	{
	}

	public void SetDailyQuestPoint()
	{
	}

	public void ShowTapjoy()
	{
	}

	public void SetIAAUser()
	{
	}

	public void SendSegment()
	{
	}

	public void SetAdPassReset()
	{
	}

	public void GetFactoryProduct()
	{
	}

	public void GetPlantExp()
	{
	}

	public void SetBankLevel()
	{
	}

	public void StartTutorial()
	{
	}

	public void SetOneTimeCurrency()
	{
	}

	public void SetOneTimeLevel()
	{
	}

	public void SetOneTimeReceiveLevel()
	{
	}

	public void SetOneTimeReset()
	{
	}

	public void SetBonusOneTime()
	{
	}

	public void TestMaxProp()
	{
	}

	public void SetInvestResetTime()
	{
	}

	public void CustomFunction2()
	{
	}

	public void CustomFunction()
	{
	}

	public void GetManager()
	{
	}

	public void ShowMoneySupplyReward()
	{
	}

	public void SetMission()
	{
	}

	public void SetMissionMilestoneCheat()
	{
	}

	public void SetInGameTime()
	{
	}

	public void AddReward()
	{
	}

	public void OnClickTimeChange()
	{
	}

	public void OnClickedResetBooster()
	{
	}

	public void OnClickBizAcqReset()
	{
	}

	public void ToggleSeasonalMode()
	{
	}

	public void ChangeSeasonalCheat()
	{
	}

	public void ChangeBizAcqCheat()
	{
	}

	public void ChangeMainCheat2()
	{
	}

	public void SuperStaffLevelClear()
	{
	}

	public void OnClickTarotCheat()
	{
	}

	public void OnClickLoadBinary()
	{
	}

	public void OnClickCheatPurchase()
	{
	}

	public void OnClickCheatRentalFeeGetToggle()
	{
	}

	public void ToggleCheatNoAds()
	{
	}

	public void OnClickAddPackage()
	{
	}

	public void OnClickManagerCardLevelReset()
	{
	}

	public void OnClickManagerReinforceLevelReset()
	{
	}

	public void OnClickManagerSkillLevelReset()
	{
	}

	public void OnClickBizAcqBattleSpeedOn()
	{
	}

	public void OnClickBizAcqStageMove()
	{
	}

	public void OnClickBizAcqCheatSkillTrigger()
	{
	}

	public void OnClickBizAcqSkillTriggerLog()
	{
	}

	public void OnClickBizAcqEnemyTeamLoad()
	{
	}

	public void OnClickBizAcqEnemyTeamSet()
	{
	}

	public void OnClickBizAcqEnemyTeamReset()
	{
	}

	public void OnClickBizAcqInvincibility()
	{
	}

	public void OnClickBizAcqJewelryBoxMax()
	{
	}

	public void ResetCurSeasonalData()
	{
	}

	public void OnClickedGetSeasonalCurrency()
	{
	}

	public void OnClickedResetSeasonalCurrency()
	{
	}

	public void OnClickedPrintManagerExpProductionFormula()
	{
	}

	public void OnClickedPrintWorkshopProductionFormula()
	{
	}

	public void OnClickedPrintDistributorSellingFormula()
	{
	}

	public void OnClickedPrintBuildingUpgradeCostFormula()
	{
	}

	public void OnClickedPrintBonusRevenueMoney()
	{
	}

	public void OnClickedPrintBonusRevenueManagerExp()
	{
	}

	public void OnClickedPrintOfflineRevenueTotal()
	{
	}

	public void OnClickedSeasonalDayAddOneHour()
	{
	}

	public void OnClick_Seasonal_RouletteCount()
	{
	}

	public void OnClick_Seasonal_CoinBank()
	{
	}

	public void OnClickSeasonalFacilityLevel()
	{
	}

	public void OnClickSeasonalAllBuildingOpen()
	{
	}

	public void OnClickWorkshopLevelUpCheat()
	{
	}

	public void OnClickSeasonalAddMissionPoint()
	{
	}

	public void OnClickOpenPopupSeasonalBuildingProgressList()
	{
	}

	public void OnClickSeasonalPackageActive()
	{
	}

	public void OnClick_Hide()
	{
	}

	public void OnClickAnzu()
	{
	}

	public void ToggleABTestOnOff()
	{
	}

	public void ToggleABTestType()
	{
	}

	private void UpdateABStateText()
	{
	}

	public void ChangeMiniGameCheat()
	{
	}

	public void MiniGame_ResetCurMiniGame()
	{
	}

	public void MiniGame_SetNextStage()
	{
	}

	public void MiniGame_GenerateNewMissions()
	{
	}

	public void MiniGame_AddUseCurrency()
	{
	}
}
