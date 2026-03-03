using System;
using System.Collections.Generic;

public static class GameShortCutHelper
{
	public enum E_GameShortCutType
	{
		None = 0,
		Acq_Main = 1000,
		Acq_Battle = 1001,
		Acq_IdleReward = 1002,
		Acq_WeeklyShop = 1003,
		Acq_JewelryBox = 1004,
		Acq_Pass = 1005,
		Acq_Endless = 1006,
		Acq_AllInOne = 1007,
		Seasonal_Enter = 1008,
		DailyQuest = 1009,
		MainPackage = 1010,
		Factory = 1011,
		FactoryProduction = 1012,
		MissionMilestone = 1013,
		Roulette = 1014,
		WeeklyReward = 1015,
		PiggyBank = 1016,
		Starter = 1017,
		Anniversary = 1018,
		OneTime = 1019,
		Tarot = 1020
	}

	public static void ShortCutContents(MissionSystem.E_MissionType missionType, object[] args, Action<bool> resultCallBack, Action endCallBack)
	{
	}

	public static void ShortCutContents(E_GameShortCutType shortCutType, object[] args, Action<bool> resultCallBack, Action endCallBack)
	{
	}

	public static bool GoToActiveRegionHouse(Action<bool> endCallBack)
	{
		return false;
	}

	public static void GoToBizAcqStage(Action<bool> endCallBack)
	{
	}

	public static void GoToBizAcqBattleStart(Action<bool> endCallBack)
	{
	}

	public static void FocusFactory(int factoryIdx, Action endCallBack)
	{
	}

	public static void FocusFactoryFacility(int factoryIdx, bool isUpgrade, Action endCallBack)
	{
	}

	private static int FindLevelUpTargetCompany(List<CompanyData> companyList, int minGrade, int needLv)
	{
		return 0;
	}

	private static bool CheckItemContentsOpen(int rewardType, int rewardIdx)
	{
		return false;
	}

	private static bool GetArgs<T>(object[] args, int index, out T value)
	{
		value = default(T);
		return false;
	}

	private static void ShowContentsNotOpen()
	{
	}

	private static void ShowHasNoCarStore()
	{
	}

	private static void ShowHasNoCar()
	{
	}

	private static void ShowTarotCoolTime()
	{
	}

	private static void ShowHasNoUpgradeOfficeItem()
	{
	}

	private static void ShowHasNoUpgradeCompany()
	{
	}
}
