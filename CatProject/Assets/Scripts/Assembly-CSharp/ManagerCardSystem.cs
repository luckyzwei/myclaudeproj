using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;

public class ManagerCardSystem
{
	[Flags]
	public enum E_RedDotCondition
	{
		None = 0,
		EnableLevelUp = 1,
		Reinforce = 2,
		SkillUp = 4
	}

	public const int LEGEND_MANAGER_START_IDX = 3000;

	private Dictionary<int, int> managerByMaxLevel;

	private Dictionary<int, List<int>> managerByCategory;

	private Dictionary<int, List<int>> managerByGrade;

	public Subject<int> OnManagerHired;

	public Subject<int> OnManagerFired;

	public Subject<int> OnManagerLevelUp;

	public Subject<int> OnUpdateManagerInfo;

	public int REINFORCE_RESET_COST_GEM_COUNT { get; private set; }

	public Dictionary<int, List<int>> ManagerByCategory => null;

	public List<int> NewManagers { get; set; }

	public void Init()
	{
	}

	public void OnChangeScene()
	{
	}

	public void AddManager(int idx, int count = 1)
	{
	}

	public bool CheckManagerMaxLevel(int idx, int level)
	{
		return false;
	}

	public int GetManagerNeedCard(int idx, int level)
	{
		return 0;
	}

	public bool CheckManagerRedDot(int managerIdx, E_RedDotCondition condition)
	{
		return false;
	}

	public bool CheckManagerEnableLevelUp(int idx, int level)
	{
		return false;
	}

	public bool CheckManagerReinforce(int managerIdx, int managerCardLv, int managerReinforceLv)
	{
		return false;
	}

	public bool CheckManagerSkillUp(int managerIdx, int managerCardLv, int managerReinforceLv, int curSkillLv)
	{
		return false;
	}

	public bool CheckManagerUnSatisfy()
	{
		return false;
	}

	public bool CheckManagerEnableEquip()
	{
		return false;
	}

	public static bool CheckManagerMaxReinforceLevel(int idx, int level)
	{
		return false;
	}

	public static ManagerForceData GetManagerCurSkillUpData(int managerIdx, int curSkillLv)
	{
		return null;
	}

	public static int GetManagerSkillUpStoneItemIdx(int managerIdx)
	{
		return 0;
	}

	public static int GetLegendManagerIdxBySkillUpStoneIdx(int skillUpStoneIdx)
	{
		return 0;
	}

	public static bool IsStageUnlockManager(int managerIdx)
	{
		return false;
	}

	public int GetManagerTableAbilityValue(int managerIdx, int managerLevel)
	{
		return 0;
	}

	public int GetManagerInGameAbilityValue(int managerIdx, int managerLevel)
	{
		return 0;
	}

	public static int GetManagerGrade(int idx)
	{
		return 0;
	}

	public Color GetManagerGradeColorByGrade(int grade)
	{
		return default(Color);
	}

	public Color GetManagerGradeColorByManagerIdx(int managerIdx)
	{
		return default(Color);
	}

	public Sprite GetManagerGradeCardIcon(int idx)
	{
		return null;
	}

	public string GetManagerGradeName(int idx)
	{
		return null;
	}

	public static ManagerForceData GetManagerForceTable(int managerIdx, int reinforceLv)
	{
		return null;
	}

	public ManagerCardData GetManagerData(int managerIdx)
	{
		return null;
	}

	public int GetOffice(int managerIdx)
	{
		return 0;
	}

	public int GetOffice(int managerIdx, out int regionIdx)
	{
		regionIdx = default(int);
		return 0;
	}

	public int GetOffice(int managerIdx, out int regionIdx, out int stageIdx)
	{
		regionIdx = default(int);
		stageIdx = default(int);
		return 0;
	}

	public bool CheckManagerDeskLevel(int managerIdx, int officeIdx = -1, bool showToast = false)
	{
		return false;
	}

	public int SearchMinManagerDeskLevel(int managerIdx)
	{
		return 0;
	}

	public string SearchMinManagerDeskName(int managerIdx)
	{
		return null;
	}

	public void HireManager(int managerIdx, int officeIdx, int regionIdx = -1)
	{
	}

	public void FireManager(int officeIdx, int regionIdx = -1, bool updatePages = true, bool updateFindUI = true)
	{
	}

	public bool LevelUpManager(int managerIdx)
	{
		return false;
	}

	public bool ReinforceManager(int managerIdx)
	{
		return false;
	}

	public int ResetReinforceManager(int managerIdx)
	{
		return 0;
	}

	public bool SkillUpManager(int managerIdx)
	{
		return false;
	}

	public List<Config.RewardItemData> GetRandomManagers(int rewardType, int rewardIdx, int rewardValue, int maxVariety, int exceptIdx = -1)
	{
		return null;
	}

	public List<ManagerCardData> GetAuctionPlayableManager()
	{
		return null;
	}

	public void UpdateAllFindManagerUI()
	{
	}

	public BigInteger CalculateManagerAddRewardBuff(BigInteger value, int managerIdx)
	{
		return default(BigInteger);
	}

	public int CalculateManagerCompanyExpBuff(int value, int managerIdx)
	{
		return 0;
	}

	public int GetManagerOfficeSkillBuffValue(Config.ManagerSkillType skillType, Config.ManagerSkillActivationType activationType)
	{
		return 0;
	}

	public BigInteger CalculateManagerSkillBuff(Config.ManagerSkillType skillType, BigInteger baseValue, int officeIdx, int regionIdx)
	{
		return default(BigInteger);
	}

	private void OnSkillContentsOpen()
	{
	}

	private void UpdateManagerSkillBuff(int managerIdx)
	{
	}

	public void UpdateManagerPopups(int officeIdx = -1, int regionIdx = -1, bool showUpgradeArrow = false)
	{
	}

	public string GetOutlineColor(int region)
	{
		return null;
	}

	public (float, float) GetManagerAverage()
	{
		return default((float, float));
	}

	public void LogManagerUnlock(int managerIdx)
	{
	}

	public void LogManagerUpgrade(int managerIdx, int resultLevel)
	{
	}

	public void LogSuitCasseBuy(int buyType, int buyCount)
	{
	}

	public void LogManagerSpecs(int clearStageIdx)
	{
	}

	private void LogManagerSpec(int clearStageIdx, Config.ManagerGrade grade, AbilitySystem.AbilityType abilityType)
	{
	}
}
