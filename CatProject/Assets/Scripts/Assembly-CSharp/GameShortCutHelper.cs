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
		resultCallBack?.Invoke(false);
		endCallBack?.Invoke();
	}

	public static void ShortCutContents(E_GameShortCutType shortCutType, object[] args, Action<bool> resultCallBack, Action endCallBack)
	{
		switch (shortCutType)
		{
			case E_GameShortCutType.Acq_Main:
			case E_GameShortCutType.Acq_Battle:
				GoToBizAcqStage(resultCallBack);
				break;
			case E_GameShortCutType.Factory:
			case E_GameShortCutType.FactoryProduction:
				if (args != null && args.Length > 0 && GetArgs<int>(args, 0, out var factoryIdx))
					FocusFactory(factoryIdx, () => endCallBack?.Invoke());
				else
					resultCallBack?.Invoke(false);
				break;
			default:
				resultCallBack?.Invoke(false);
				endCallBack?.Invoke();
				break;
		}
	}

	public static bool GoToActiveRegionHouse(Action<bool> endCallBack)
	{
		endCallBack?.Invoke(true);
		return true;
	}

	public static void GoToBizAcqStage(Action<bool> endCallBack)
	{
		endCallBack?.Invoke(true);
	}

	public static void GoToBizAcqBattleStart(Action<bool> endCallBack)
	{
		endCallBack?.Invoke(true);
	}

	public static void FocusFactory(int factoryIdx, Action endCallBack)
	{
		endCallBack?.Invoke();
	}

	public static void FocusFactoryFacility(int factoryIdx, bool isUpgrade, Action endCallBack)
	{
		endCallBack?.Invoke();
	}

	private static int FindLevelUpTargetCompany(List<CompanyData> companyList, int minGrade, int needLv)
	{
		if (companyList == null) return -1;
		for (int i = 0; i < companyList.Count; i++)
		{
			var company = companyList[i];
			if (company == null) continue;
			if (company.Grade >= minGrade && company.Level >= needLv)
				return i;
		}
		return -1;
	}

	private static bool CheckItemContentsOpen(int rewardType, int rewardIdx)
	{
		return true;
	}

	private static bool GetArgs<T>(object[] args, int index, out T value)
	{
		value = default(T);
		if (args == null || index < 0 || index >= args.Length) return false;
		if (args[index] is T t)
		{
			value = t;
			return true;
		}
		return false;
	}

	private static void ShowContentsNotOpen()
	{
		PopupToastmessage.OpenToast("contents_not_open");
	}

	private static void ShowHasNoCarStore()
	{
		PopupToastmessage.OpenToast("has_no_car_store");
	}

	private static void ShowHasNoCar()
	{
		PopupToastmessage.OpenToast("has_no_car");
	}

	private static void ShowTarotCoolTime()
	{
		PopupToastmessage.OpenToast("tarot_cooltime");
	}

	private static void ShowHasNoUpgradeOfficeItem()
	{
		PopupToastmessage.OpenToast("has_no_upgrade_office_item");
	}

	private static void ShowHasNoUpgradeCompany()
	{
		PopupToastmessage.OpenToast("has_no_upgrade_company");
	}
}
