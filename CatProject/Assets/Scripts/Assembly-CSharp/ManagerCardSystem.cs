using System;
using System.Collections.Generic;
using System.Linq;
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

	public Dictionary<int, List<int>> ManagerByCategory => managerByCategory;

	public List<int> NewManagers { get; set; }

	public void Init()
	{
		managerByMaxLevel = new Dictionary<int, int>();
		managerByCategory = new Dictionary<int, List<int>>();
		managerByGrade = new Dictionary<int, List<int>>();
		OnManagerHired = new Subject<int>();
		OnManagerFired = new Subject<int>();
		OnManagerLevelUp = new Subject<int>();
		OnUpdateManagerInfo = new Subject<int>();
		NewManagers = new List<int>();
		REINFORCE_RESET_COST_GEM_COUNT = 50;
	}

	public void OnChangeScene()
	{
	}

	public void AddManager(int idx, int count = 1)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		var managerData = GetManagerData(idx);
		if (managerData != null)
		{
			managerData.ManagerCount += count;
		}
		else
		{
			var newData = new ManagerCardData(idx, 1);
			newData.ManagerCount = count;
			userData.ManagerData.Add(newData);
		}
		if (NewManagers != null && !NewManagers.Contains(idx))
		{
			NewManagers.Add(idx);
		}
		OnUpdateManagerInfo.OnNext(idx);
	}

	public bool CheckManagerMaxLevel(int idx, int level)
	{
		if (managerByMaxLevel != null && managerByMaxLevel.TryGetValue(idx, out int maxLevel))
		{
			return level >= maxLevel;
		}
		return false;
	}

	public int GetManagerNeedCard(int idx, int level)
	{
		// Card cost typically scales with level: level + 1 cards needed
		return level + 1;
	}

	public bool CheckManagerRedDot(int managerIdx, E_RedDotCondition condition)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return false;

		bool result = false;
		int level = managerData.ManagerLevel.Value;

		if ((condition & E_RedDotCondition.EnableLevelUp) != 0)
		{
			result |= CheckManagerEnableLevelUp(managerIdx, level);
		}
		if ((condition & E_RedDotCondition.Reinforce) != 0)
		{
			result |= CheckManagerReinforce(managerIdx, level, managerData.ReinforceLevel);
		}
		if ((condition & E_RedDotCondition.SkillUp) != 0)
		{
			result |= CheckManagerSkillUp(managerIdx, level, managerData.ReinforceLevel, managerData.SkillLevel);
		}
		return result;
	}

	public bool CheckManagerEnableLevelUp(int idx, int level)
	{
		if (CheckManagerMaxLevel(idx, level))
			return false;

		var managerData = GetManagerData(idx);
		if (managerData == null)
			return false;

		int needCard = GetManagerNeedCard(idx, level);
		return managerData.ManagerCount >= needCard;
	}

	public bool CheckManagerReinforce(int managerIdx, int managerCardLv, int managerReinforceLv)
	{
		if (CheckManagerMaxReinforceLevel(managerIdx, managerReinforceLv))
			return false;

		// Reinforce requires minimum card level
		var forceData = GetManagerForceTable(managerIdx, managerReinforceLv + 1);
		if (forceData == null)
			return false;

		return managerCardLv >= forceData.Level;
	}

	public bool CheckManagerSkillUp(int managerIdx, int managerCardLv, int managerReinforceLv, int curSkillLv)
	{
		if (managerIdx < LEGEND_MANAGER_START_IDX)
			return false;

		var skillUpData = GetManagerCurSkillUpData(managerIdx, curSkillLv + 1);
		if (skillUpData == null)
			return false;

		return managerCardLv >= skillUpData.Level;
	}

	public bool CheckManagerUnSatisfy()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null)
			return false;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerCount > 0 && data.ManagerLevel.Value == 0)
				return true;
		}
		return false;
	}

	public bool CheckManagerEnableEquip()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null)
			return false;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerLevel.Value > 0)
				return true;
		}
		return false;
	}

	public static bool CheckManagerMaxReinforceLevel(int idx, int level)
	{
		// Typical max reinforce level: 5 for normal, 10 for legend
		int maxReinforce = idx >= LEGEND_MANAGER_START_IDX ? 10 : 5;
		return level >= maxReinforce;
	}

	public static ManagerForceData GetManagerCurSkillUpData(int managerIdx, int curSkillLv)
	{
		// Would look up from table data - return null for missing data
		return null;
	}

	public static int GetManagerSkillUpStoneItemIdx(int managerIdx)
	{
		// Legend managers have unique skill-up stone items
		if (managerIdx >= LEGEND_MANAGER_START_IDX)
		{
			return 90000 + (managerIdx - LEGEND_MANAGER_START_IDX);
		}
		return 0;
	}

	public static int GetLegendManagerIdxBySkillUpStoneIdx(int skillUpStoneIdx)
	{
		if (skillUpStoneIdx >= 90000)
		{
			return LEGEND_MANAGER_START_IDX + (skillUpStoneIdx - 90000);
		}
		return 0;
	}

	public static bool IsStageUnlockManager(int managerIdx)
	{
		// Legend managers (idx >= 3000) are stage-unlock managers
		return managerIdx >= LEGEND_MANAGER_START_IDX;
	}

	public int GetManagerTableAbilityValue(int managerIdx, int managerLevel)
	{
		// Base ability value from table data, scaled by level
		return managerLevel;
	}

	public int GetManagerInGameAbilityValue(int managerIdx, int managerLevel)
	{
		int baseValue = GetManagerTableAbilityValue(managerIdx, managerLevel);
		var managerData = GetManagerData(managerIdx);
		if (managerData != null && managerData.ReinforceLevel > 0)
		{
			var forceData = GetManagerForceTable(managerIdx, managerData.ReinforceLevel);
			if (forceData != null)
			{
				baseValue += forceData.AbilityValue;
			}
		}
		return baseValue;
	}

	public static int GetManagerGrade(int idx)
	{
		// Grade determined by index range
		if (idx >= LEGEND_MANAGER_START_IDX) return (int)Config.ManagerGrade.Legend;
		if (idx >= 2000) return (int)Config.ManagerGrade.Epic;
		if (idx >= 1000) return (int)Config.ManagerGrade.Rare;
		if (idx >= 500) return (int)Config.ManagerGrade.Uncommon;
		return (int)Config.ManagerGrade.Common;
	}

	public Color GetManagerGradeColorByGrade(int grade)
	{
		switch ((Config.ManagerGrade)grade)
		{
			case Config.ManagerGrade.Common: return new Color(0.7f, 0.7f, 0.7f);
			case Config.ManagerGrade.Uncommon: return new Color(0.2f, 0.8f, 0.2f);
			case Config.ManagerGrade.Rare: return new Color(0.2f, 0.4f, 1f);
			case Config.ManagerGrade.Epic: return new Color(0.6f, 0.2f, 0.8f);
			case Config.ManagerGrade.Legend: return new Color(1f, 0.8f, 0f);
			case Config.ManagerGrade.Special: return new Color(1f, 0.4f, 0.4f);
			default: return Color.white;
		}
	}

	public Color GetManagerGradeColorByManagerIdx(int managerIdx)
	{
		return GetManagerGradeColorByGrade(GetManagerGrade(managerIdx));
	}

	public Sprite GetManagerGradeCardIcon(int idx)
	{
		// Would load from Resources based on grade
		return null;
	}

	public string GetManagerGradeName(int idx)
	{
		int grade = GetManagerGrade(idx);
		switch ((Config.ManagerGrade)grade)
		{
			case Config.ManagerGrade.Common: return "Common";
			case Config.ManagerGrade.Uncommon: return "Uncommon";
			case Config.ManagerGrade.Rare: return "Rare";
			case Config.ManagerGrade.Epic: return "Epic";
			case Config.ManagerGrade.Legend: return "Legend";
			case Config.ManagerGrade.Special: return "Special";
			default: return "";
		}
	}

	public static ManagerForceData GetManagerForceTable(int managerIdx, int reinforceLv)
	{
		// Would look up from table data
		return null;
	}

	public ManagerCardData GetManagerData(int managerIdx)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null)
			return null;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerIdx == managerIdx)
				return data;
		}
		return null;
	}

	public int GetOffice(int managerIdx)
	{
		int regionIdx;
		return GetOffice(managerIdx, out regionIdx);
	}

	public int GetOffice(int managerIdx, out int regionIdx)
	{
		int stageIdx;
		return GetOffice(managerIdx, out regionIdx, out stageIdx);
	}

	public int GetOffice(int managerIdx, out int regionIdx, out int stageIdx)
	{
		regionIdx = -1;
		stageIdx = -1;
		// Would search all offices for assigned manager
		return -1;
	}

	public bool CheckManagerDeskLevel(int managerIdx, int officeIdx = -1, bool showToast = false)
	{
		int minDeskLevel = SearchMinManagerDeskLevel(managerIdx);
		return minDeskLevel > 0;
	}

	public int SearchMinManagerDeskLevel(int managerIdx)
	{
		int grade = GetManagerGrade(managerIdx);
		// Higher grade managers require higher desk levels
		return grade + 1;
	}

	public string SearchMinManagerDeskName(int managerIdx)
	{
		int level = SearchMinManagerDeskLevel(managerIdx);
		return $"Desk Lv.{level}";
	}

	public void HireManager(int managerIdx, int officeIdx, int regionIdx = -1)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return;

		OnManagerHired.OnNext(managerIdx);
		OnUpdateManagerInfo.OnNext(managerIdx);
	}

	public void FireManager(int officeIdx, int regionIdx = -1, bool updatePages = true, bool updateFindUI = true)
	{
		OnManagerFired.OnNext(officeIdx);
	}

	public bool LevelUpManager(int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return false;

		int curLevel = managerData.ManagerLevel.Value;
		if (CheckManagerMaxLevel(managerIdx, curLevel))
			return false;

		int needCard = GetManagerNeedCard(managerIdx, curLevel);
		if (managerData.ManagerCount < needCard)
			return false;

		managerData.ManagerCount -= needCard;
		managerData.ManagerLevel.Value = curLevel + 1;

		OnManagerLevelUp.OnNext(managerIdx);
		OnUpdateManagerInfo.OnNext(managerIdx);
		UpdateManagerSkillBuff(managerIdx);

		return true;
	}

	public bool ReinforceManager(int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return false;

		if (CheckManagerMaxReinforceLevel(managerIdx, managerData.ReinforceLevel))
			return false;

		if (!CheckManagerReinforce(managerIdx, managerData.ManagerLevel.Value, managerData.ReinforceLevel))
			return false;

		managerData.ReinforceLevel++;
		OnUpdateManagerInfo.OnNext(managerIdx);
		UpdateManagerSkillBuff(managerIdx);

		return true;
	}

	public int ResetReinforceManager(int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return 0;

		int prevLevel = managerData.ReinforceLevel;
		managerData.ReinforceLevel = 0;
		managerData.LastReinforceResetTime = DateTime.UtcNow;

		OnUpdateManagerInfo.OnNext(managerIdx);
		UpdateManagerSkillBuff(managerIdx);

		return prevLevel;
	}

	public bool SkillUpManager(int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null)
			return false;

		if (!CheckManagerSkillUp(managerIdx, managerData.ManagerLevel.Value, managerData.ReinforceLevel, managerData.SkillLevel))
			return false;

		managerData.SkillLevel++;
		OnUpdateManagerInfo.OnNext(managerIdx);
		UpdateManagerSkillBuff(managerIdx);

		return true;
	}

	public List<Config.RewardItemData> GetRandomManagers(int rewardType, int rewardIdx, int rewardValue, int maxVariety, int exceptIdx = -1)
	{
		var result = new List<Config.RewardItemData>();
		// Would generate random manager rewards based on gacha/reward tables
		return result;
	}

	public List<ManagerCardData> GetAuctionPlayableManager()
	{
		var result = new List<ManagerCardData>();
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null)
			return result;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerLevel.Value > 0)
			{
				result.Add(data);
			}
		}
		return result;
	}

	public void UpdateAllFindManagerUI()
	{
	}

	public BigInteger CalculateManagerAddRewardBuff(BigInteger value, int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null || managerData.ManagerLevel.Value <= 0)
			return value;

		int abilityValue = GetManagerInGameAbilityValue(managerIdx, managerData.ManagerLevel.Value);
		if (abilityValue <= 0)
			return value;

		// Apply percentage buff: value * (100 + abilityValue) / 100
		return value * (100 + abilityValue) / 100;
	}

	public int CalculateManagerCompanyExpBuff(int value, int managerIdx)
	{
		var managerData = GetManagerData(managerIdx);
		if (managerData == null || managerData.ManagerLevel.Value <= 0)
			return value;

		int abilityValue = GetManagerInGameAbilityValue(managerIdx, managerData.ManagerLevel.Value);
		if (abilityValue <= 0)
			return value;

		return value * (100 + abilityValue) / 100;
	}

	public int GetManagerOfficeSkillBuffValue(Config.ManagerSkillType skillType, Config.ManagerSkillActivationType activationType)
	{
		int totalBuff = 0;
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null)
			return totalBuff;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerLevel.Value <= 0)
				continue;

			var skillData = data.OfficeSkillData;
			if (skillData != null && skillData.SkillType == skillType && skillData.SkillActivationType == activationType)
			{
				totalBuff += data.SkillLevel;
			}
		}
		return totalBuff;
	}

	public BigInteger CalculateManagerSkillBuff(Config.ManagerSkillType skillType, BigInteger baseValue, int officeIdx, int regionIdx)
	{
		int buffValue = GetManagerOfficeSkillBuffValue(skillType, Config.ManagerSkillActivationType.Passive);
		if (buffValue <= 0)
			return baseValue;

		return baseValue * (100 + buffValue) / 100;
	}

	private void OnSkillContentsOpen()
	{
	}

	private void UpdateManagerSkillBuff(int managerIdx)
	{
		OnUpdateManagerInfo.OnNext(managerIdx);
	}

	public void UpdateManagerPopups(int officeIdx = -1, int regionIdx = -1, bool showUpgradeArrow = false)
	{
	}

	public string GetOutlineColor(int region)
	{
		switch (region)
		{
			case 0: return "#FFFFFF";
			case 1: return "#4CAF50";
			case 2: return "#2196F3";
			case 3: return "#9C27B0";
			case 4: return "#FF9800";
			default: return "#FFFFFF";
		}
	}

	public (float, float) GetManagerAverage()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.ManagerData == null || userData.ManagerData.Count == 0)
			return (0f, 0f);

		float totalLevel = 0;
		float totalReinforce = 0;
		int count = 0;

		foreach (var data in userData.ManagerData)
		{
			if (data.ManagerLevel.Value > 0)
			{
				totalLevel += data.ManagerLevel.Value;
				totalReinforce += data.ReinforceLevel;
				count++;
			}
		}

		if (count == 0)
			return (0f, 0f);

		return (totalLevel / count, totalReinforce / count);
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
