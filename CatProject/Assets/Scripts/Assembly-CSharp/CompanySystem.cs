using System;
using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UniRx;

public class CompanySystem
{
	private int company_list_show_count;

	public Dictionary<int, (int needGrade, int needLevel, int needCount)> CompanyContractNeedCompanyConditionMap;

	public List<CompanyInfoData> RecommendCompanyInfoDataList;

	public IReactiveProperty<int> RemainRefreshTime;

	public Dictionary<int, bool> MeetingStatusList;

	public bool IsSawLongPressGuide;

	public Subject<int> OnCompanyLevelUp;

	public Subject<int> OnCompanyContract;

	public Subject<int> OnCompanyReContract;

	public Subject<int> OnOfficeItemUpgrade;

	public int company_list_renewal_cooltime { get; private set; }

	public int company_list_reset_gem_count { get; private set; }

	public int company_cancel_cost_cash_value { get; private set; }

	public int company_levelup_reward { get; private set; }

	public int office_buildcost_skip_time { get; private set; }

	public int office_buildcost_skip_cash { get; private set; }

	public int officeitem_lv2_require_player_lv { get; private set; }

	public int speachbubble_good_max_count { get; private set; }

	public int speachbubble_bad_max_count { get; private set; }

	public int speachbubble_duration_time { get; private set; }

	public int speachbubble_view_percent { get; private set; }

	public int speachbubble_type_1_rate { get; private set; }

	public int speachbubble_type_2_rate { get; private set; }

	public int speachbubble_roomopen_max_count { get; private set; }

	public int waiting_speachbubble_cooltime { get; private set; }

	public float company_exp_gauge_color_rate_red { get; private set; }

	public float company_exp_gauge_color_rate_yellow { get; private set; }

	public float company_exp_gauge_color_rate_green { get; private set; }

	public int upgrade_btn_show_info_count { get; private set; }

	private bool EnableActivityTime { get; set; }

	private bool EnableMeetingTime { get; set; }

	public int meetingroom_use_duration { get; private set; }

	private int meetingroom_use_time { get; set; }

	private int activity_starttime { get; set; }

	private int activity_endtime { get; set; }

	public int activity_probability { get; private set; }

	public int activity_cooltime { get; private set; }

	private int activity_employee_count { get; set; }

	public int GetCompanyListShowCount()
	{
		return 0;
	}

	public void Init(bool init = false)
	{
	}

	public void CalcOfflineExp()
	{
	}

	public int CalcCompanyExp(int officeIdx)
	{
		return 0;
	}

	public void UpdateStatus()
	{
	}

	public void StartActivity()
	{
	}

	public Employee FindNextActivityEmployee()
	{
		return null;
	}

	public void StartOpen(int office)
	{
	}

	public void StartMeeting()
	{
	}

	public bool IsMeetingDone(int office)
	{
		return false;
	}

	public void ResetMeetingDone()
	{
	}

	private void CreateOfficeEmployess(int office)
	{
	}

	public BigInteger CalcCompanyContractPrice(int officeIdx, int regionIdx, int companyIdx)
	{
		return default(BigInteger);
	}

	public void ContractCompany(int office, int company)
	{
	}

	public void ReContractCompany(int office)
	{
	}

	public void OutCompany(int office, bool isListPage)
	{
	}

	public void CompanyLevelUp(int company, bool maxOpenRecontract, Action onEndLevelUp)
	{
	}

	public void LevelUpItem(int office, int type, int idx)
	{
	}

	public void RefreshCompanyList(int office, int deskcount)
	{
	}

	public void RefreshCompanyList(int deskcount, bool isGradeFix, bool isOrder = false)
	{
	}

	public int RefreshNoAdsRecommendCompany(int deskcount)
	{
		return 0;
	}

	public bool IsExistStageIAPFreeUnlockableCompanyList(int deskcount)
	{
		return false;
	}

	public List<CompanyInfoData> GetCurStageUnconditionalCompanyList(int regionIdx, int stageIdx, int maxGrade)
	{
		return null;
	}

	public List<CompanyInfoData> MakeStageContractableCompanyList(int curRegion, int curStage, int maxGrade)
	{
		return null;
	}

	public List<CompanyInfoData> MakeCommonContractList(List<CompanyInfoData> companyPool, int pickCount)
	{
		return null;
	}

	public List<CompanyInfoData> MakeStageIAPFreeUnlockableCompanyList(int curRegion, int curStage, int maxGrade)
	{
		return null;
	}

	public bool IsUnlockCompany(int companyIdx, int curRegion, int curStage)
	{
		return false;
	}

	public void OpenCompany(int officeIdx)
	{
	}

	private void UnLockSpecialCompany()
	{
	}

	public void UpdateOneSecond()
	{
	}

	public bool CheckCompanyExpRewardEnable(int regionType, bool bShowAlertToast, bool bShowRecontract)
	{
		return false;
	}

	public int CalcCompanyLevelUpGem(int companyIdx)
	{
		return 0;
	}

	public bool CompanyLevelUpByGem(int companyIdx, bool openInsufficientShop, TpAnalyticsProp.LogCostCashPlace place)
	{
		return false;
	}
}
