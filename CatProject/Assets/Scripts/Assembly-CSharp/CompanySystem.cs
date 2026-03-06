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
		return company_list_show_count;
	}

	public void Init(bool init = false)
	{
		if (init)
			return;

		OnCompanyLevelUp = new Subject<int>();
		OnCompanyContract = new Subject<int>();
		OnCompanyReContract = new Subject<int>();
		OnOfficeItemUpgrade = new Subject<int>();

		RemainRefreshTime = new ReactiveProperty<int>(0);
		MeetingStatusList = new Dictionary<int, bool>();
		CompanyContractNeedCompanyConditionMap = new Dictionary<int, (int, int, int)>();
		RecommendCompanyInfoDataList = new List<CompanyInfoData>();

		company_list_renewal_cooltime = 1800;
		company_list_reset_gem_count = 10;
		company_cancel_cost_cash_value = 50;
		company_levelup_reward = 10;
		office_buildcost_skip_time = 300;
		office_buildcost_skip_cash = 10;
		officeitem_lv2_require_player_lv = 5;

		speachbubble_good_max_count = 3;
		speachbubble_bad_max_count = 3;
		speachbubble_duration_time = 5;
		speachbubble_view_percent = 30;
		speachbubble_type_1_rate = 50;
		speachbubble_type_2_rate = 50;
		speachbubble_roomopen_max_count = 3;
		waiting_speachbubble_cooltime = 60;

		company_exp_gauge_color_rate_red = 0.3f;
		company_exp_gauge_color_rate_yellow = 0.6f;
		company_exp_gauge_color_rate_green = 1.0f;

		upgrade_btn_show_info_count = 3;
		company_list_show_count = 5;

		meetingroom_use_duration = 60;
		meetingroom_use_time = 0;
		activity_starttime = 9;
		activity_endtime = 18;
		activity_probability = 30;
		activity_cooltime = 300;
		activity_employee_count = 1;

		EnableActivityTime = false;
		EnableMeetingTime = false;
		IsSawLongPressGuide = false;
	}

	public void CalcOfflineExp()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;

		var offlineData = curMode.RegionData?.OfflineData;
		if (offlineData == null) return;

		int offlineSeconds = offlineData.TotalOfflineTime;
		if (offlineSeconds <= 0) return;

		foreach (var kvp in stageData.Offices)
		{
			int officeIdx = kvp.Key;
			var office = kvp.Value;
			if (office == null) continue;
			if (office.IsOpen == null || !office.IsOpen.Value) continue;
			if (office.CompanyIdx == null || office.CompanyIdx.Value <= 0) continue;

			int companyIdx = office.CompanyIdx.Value;
			var companies = stageData.Companies;
			if (companies == null) continue;

			CompanyData companyData = null;
			for (int i = 0; i < companies.Count; i++)
			{
				if (companies[i] != null && companies[i].Idx == companyIdx)
				{
					companyData = companies[i];
					break;
				}
			}

			if (companyData == null || companyData.IsMaxLevel()) continue;

			int expPerTick = CalcCompanyExp(officeIdx);
			int totalExp = expPerTick * offlineSeconds;
			if (totalExp > 0)
			{
				companyData.UpdateExp();
			}
		}
	}

	public int CalcCompanyExp(int officeIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return 0;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return 0;

		if (!stageData.Offices.TryGetValue(officeIdx, out var office)) return 0;
		if (office == null || office.CompanyIdx == null || office.CompanyIdx.Value <= 0) return 0;

		int companyIdx = office.CompanyIdx.Value;
		CompanyData companyData = null;
		if (stageData.Companies != null)
		{
			for (int i = 0; i < stageData.Companies.Count; i++)
			{
				if (stageData.Companies[i] != null && stageData.Companies[i].Idx == companyIdx)
				{
					companyData = stageData.Companies[i];
					break;
				}
			}
		}

		if (companyData == null) return 0;

		int baseExp = 1 + companyData.Level;
		int gradeBonus = companyData.Grade;
		int exp = baseExp + gradeBonus;

		if (gameRoot.BuffSystem != null)
		{
			float buffValue = gameRoot.BuffSystem.GetValueTarget(BuffSystem.BuffType.ManagerFacilityValue, BuffSystem.BuffTarget.AllUpgrade);
			if (buffValue > 0)
			{
				exp = (int)(exp * (1f + buffValue / 100f));
			}
		}

		return exp;
	}

	public void UpdateStatus()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.DaySystem == null) return;

		int curHour = (int)gameRoot.DaySystem.DayTime;

		bool wasActivityEnabled = EnableActivityTime;
		EnableActivityTime = (curHour >= activity_starttime && curHour < activity_endtime);

		if (EnableActivityTime && !wasActivityEnabled)
		{
			StartActivity();
		}

		bool wasMeetingEnabled = EnableMeetingTime;
		if (meetingroom_use_time > 0)
		{
			meetingroom_use_time--;
			if (meetingroom_use_time <= 0)
			{
				EnableMeetingTime = false;
			}
		}
	}

	public void StartActivity()
	{
		EnableActivityTime = true;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		for (int i = 0; i < activity_employee_count; i++)
		{
			Employee employee = FindNextActivityEmployee();
			if (employee == null) break;
		}
	}

	public Employee FindNextActivityEmployee()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return null;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return null;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return null;

		foreach (var kvp in stageData.Offices)
		{
			var office = kvp.Value;
			if (office == null) continue;
			if (office.IsOpen == null || !office.IsOpen.Value) continue;
			if (office.CompanyIdx == null || office.CompanyIdx.Value <= 0) continue;
			if (office.Employees == null) continue;

			for (int i = 0; i < office.Employees.Count; i++)
			{
				var empData = office.Employees[i];
				if (empData == null) continue;
				// Return first available employee found
				return null; // Would return actual Employee object from InGame scene
			}
		}

		return null;
	}

	public void StartOpen(int office)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;

		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null) return;

		officeData.IsOpen.Value = true;
		officeData.OpenCompleteTime = DateTime.Now.AddSeconds(office_buildcost_skip_time);
		officeData.OpenRemainTime.Value = office_buildcost_skip_time;

		CreateOfficeEmployess(office);

		gameRoot.UserData.Save();
	}

	public void StartMeeting()
	{
		EnableMeetingTime = true;
		meetingroom_use_time = meetingroom_use_duration;
	}

	public bool IsMeetingDone(int office)
	{
		if (MeetingStatusList == null) return false;
		if (MeetingStatusList.TryGetValue(office, out bool done))
			return done;
		return false;
	}

	public void ResetMeetingDone()
	{
		if (MeetingStatusList == null) return;

		var keys = new List<int>(MeetingStatusList.Keys);
		foreach (var key in keys)
		{
			MeetingStatusList[key] = false;
		}
	}

	private void CreateOfficeEmployess(int office)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null) return;

		if (officeData.Employees == null)
			officeData.Employees = new List<EmployeeData>();
		else
			officeData.Employees.Clear();

		int seatCount = 4; // default seats per office
		for (int i = 0; i < seatCount; i++)
		{
			var empData = new EmployeeData();
			empData.Idx = i;
			empData.Seat = i;
			empData.ViewIdx = i;
			empData.Create();
			officeData.Employees.Add(empData);
		}
	}

	public BigInteger CalcCompanyContractPrice(int officeIdx, int regionIdx, int companyIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return BigInteger.Zero;

		BigInteger basePrice = 100;
		BigInteger regionMultiplier = (BigInteger)(1 + regionIdx);
		BigInteger companyMultiplier = (BigInteger)(1 + companyIdx / 10);

		BigInteger price = basePrice * regionMultiplier * companyMultiplier;

		if (gameRoot.BuffSystem != null)
		{
			float discountBuff = gameRoot.BuffSystem.GetValueTarget(BuffSystem.BuffType.StageUpgradePrice, BuffSystem.BuffTarget.AllUpgrade);
			if (discountBuff > 0)
			{
				price = price * (100 - (int)discountBuff) / 100;
				if (price < BigInteger.One)
					price = BigInteger.One;
			}
		}

		return price;
	}

	public void ContractCompany(int office, int company)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null) return;

		officeData.CompanyIdx.Value = company;

		if (stageData.Companies != null)
		{
			bool found = false;
			for (int i = 0; i < stageData.Companies.Count; i++)
			{
				if (stageData.Companies[i] != null && stageData.Companies[i].Idx == company)
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				var newCompany = new CompanyData(company, 1, BigInteger.Zero, false);
				newCompany.Create();
				stageData.Companies.Add(newCompany);
			}
		}

		CreateOfficeEmployess(office);

		if (OnCompanyContract != null)
			OnCompanyContract.OnNext(office);

		gameRoot.UserData.Save();
	}

	public void ReContractCompany(int office)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null) return;

		int companyIdx = officeData.CompanyIdx.Value;
		if (companyIdx <= 0) return;

		if (stageData.Companies != null)
		{
			for (int i = 0; i < stageData.Companies.Count; i++)
			{
				if (stageData.Companies[i] != null && stageData.Companies[i].Idx == companyIdx)
				{
					stageData.Companies[i].MaxReward = false;
					break;
				}
			}
		}

		if (OnCompanyReContract != null)
			OnCompanyReContract.OnNext(office);

		gameRoot.UserData.Save();
	}

	public void OutCompany(int office, bool isListPage)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null) return;

		officeData.CompanyIdx.Value = 0;

		if (officeData.Employees != null)
			officeData.Employees.Clear();

		if (officeData.OnEndCompanyContract != null)
			officeData.OnEndCompanyContract.OnNext(isListPage);

		gameRoot.UserData.Save();
	}

	public void CompanyLevelUp(int company, bool maxOpenRecontract, Action onEndLevelUp)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Companies == null) return;

		CompanyData companyData = null;
		for (int i = 0; i < stageData.Companies.Count; i++)
		{
			if (stageData.Companies[i] != null && stageData.Companies[i].Idx == company)
			{
				companyData = stageData.Companies[i];
				break;
			}
		}

		if (companyData == null) return;
		if (!companyData.IsEnableLevelUp()) return;

		companyData.UpdateExp();

		if (companyData.IsMaxLevel() && maxOpenRecontract)
		{
			companyData.MaxReward = true;
		}

		if (OnCompanyLevelUp != null)
			OnCompanyLevelUp.OnNext(company);

		gameRoot.UserData.Save();

		if (onEndLevelUp != null)
			onEndLevelUp.Invoke();
	}

	public void LevelUpItem(int office, int type, int idx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(office, out var officeData)) return;
		if (officeData == null || officeData.Items == null) return;

		for (int i = 0; i < officeData.Items.Count; i++)
		{
			var item = officeData.Items[i];
			if (item != null && item.Type == type && item.Idx == idx)
			{
				// Level up the item (would need setter or internal method)
				if (item.LevelProperty != null)
					item.LevelProperty.Value = item.Level + 1;
				break;
			}
		}

		if (OnOfficeItemUpgrade != null)
			OnOfficeItemUpgrade.OnNext(office);

		gameRoot.UserData.Save();
	}

	public void RefreshCompanyList(int office, int deskcount)
	{
		RefreshCompanyList(deskcount, false, false);
	}

	public void RefreshCompanyList(int deskcount, bool isGradeFix, bool isOrder = false)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		int curRegion = curMode.ActiveRegion;
		int curStage = curMode.StageData.StageIdx;
		int maxGrade = (gameRoot.UserData.Level != null) ? gameRoot.UserData.Level.Value / 10 : 0;

		List<CompanyInfoData> pool = MakeStageContractableCompanyList(curRegion, curStage, maxGrade);
		if (pool == null)
			pool = new List<CompanyInfoData>();

		int pickCount = deskcount > 0 ? deskcount : company_list_show_count;
		RecommendCompanyInfoDataList = MakeCommonContractList(pool, pickCount);

		RemainRefreshTime.Value = company_list_renewal_cooltime;
		curMode.CompanyRefreshTime = DateTime.Now.AddSeconds(company_list_renewal_cooltime);

		gameRoot.UserData.Save();
	}

	public int RefreshNoAdsRecommendCompany(int deskcount)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var refreshData = gameRoot.UserData.CompanyListRefreshData;
		if (refreshData == null) return 0;

		if (refreshData.RemainCnt <= 0)
			return 0;

		refreshData.UseRefresh();
		RefreshCompanyList(deskcount, false, false);

		return refreshData.RemainCnt;
	}

	public bool IsExistStageIAPFreeUnlockableCompanyList(int deskcount)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return false;

		int curRegion = curMode.ActiveRegion;
		int curStage = curMode.StageData.StageIdx;
		int maxGrade = (gameRoot.UserData.Level != null) ? gameRoot.UserData.Level.Value / 10 : 0;

		var list = MakeStageIAPFreeUnlockableCompanyList(curRegion, curStage, maxGrade);
		return list != null && list.Count > 0;
	}

	public List<CompanyInfoData> GetCurStageUnconditionalCompanyList(int regionIdx, int stageIdx, int maxGrade)
	{
		var result = new List<CompanyInfoData>();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return result;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return result;

		var stageData = curMode.StageData;
		if (stageData.CompanyList == null) return result;

		foreach (var companyIdx in stageData.CompanyList)
		{
			if (IsUnlockCompany(companyIdx, regionIdx, stageIdx))
			{
				var info = new CompanyInfoData();
				result.Add(info);
			}
		}

		return result;
	}

	public List<CompanyInfoData> MakeStageContractableCompanyList(int curRegion, int curStage, int maxGrade)
	{
		var result = new List<CompanyInfoData>();

		var unconditionalList = GetCurStageUnconditionalCompanyList(curRegion, curStage, maxGrade);
		if (unconditionalList != null)
			result.AddRange(unconditionalList);

		return result;
	}

	public List<CompanyInfoData> MakeCommonContractList(List<CompanyInfoData> companyPool, int pickCount)
	{
		var result = new List<CompanyInfoData>();
		if (companyPool == null || companyPool.Count == 0) return result;

		if (companyPool.Count <= pickCount)
		{
			result.AddRange(companyPool);
			return result;
		}

		var tempPool = new List<CompanyInfoData>(companyPool);
		var random = new Random();
		for (int i = 0; i < pickCount && tempPool.Count > 0; i++)
		{
			int idx = random.Next(tempPool.Count);
			result.Add(tempPool[idx]);
			tempPool.RemoveAt(idx);
		}

		return result;
	}

	public List<CompanyInfoData> MakeStageIAPFreeUnlockableCompanyList(int curRegion, int curStage, int maxGrade)
	{
		var result = new List<CompanyInfoData>();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return result;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return result;

		var stageData = curMode.StageData;
		if (stageData.CompanyList == null) return result;

		foreach (var companyIdx in stageData.CompanyList)
		{
			// Check if this is an IAP-free unlockable company
			if (!IsUnlockCompany(companyIdx, curRegion, curStage))
				continue;

			if (ProjectUtility.IsSpecialCompany(companyIdx))
				continue;

			var info = new CompanyInfoData();
			result.Add(info);
		}

		return result;
	}

	public bool IsUnlockCompany(int companyIdx, int curRegion, int curStage)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return false;

		var stageData = curMode.StageData;

		if (stageData.UnLockCompanyList != null)
		{
			for (int i = 0; i < stageData.UnLockCompanyList.Count; i++)
			{
				if (stageData.UnLockCompanyList[i] == companyIdx)
					return true;
			}
		}

		if (CompanyContractNeedCompanyConditionMap != null &&
			CompanyContractNeedCompanyConditionMap.TryGetValue(companyIdx, out var condition))
		{
			int needGrade = condition.needGrade;
			int needLevel = condition.needLevel;
			int needCount = condition.needCount;

			// Count companies meeting grade/level requirements
			int meetCount = 0;
			if (stageData.Companies != null)
			{
				for (int i = 0; i < stageData.Companies.Count; i++)
				{
					var comp = stageData.Companies[i];
					if (comp != null && comp.Grade >= needGrade && comp.Level >= needLevel)
						meetCount++;
				}
			}

			return meetCount >= needCount;
		}

		return true;
	}

	public void OpenCompany(int officeIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		if (gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;
		if (!stageData.Offices.TryGetValue(officeIdx, out var officeData)) return;
		if (officeData == null) return;

		if (gameRoot.UISystem != null)
		{
			// UI would be opened here via UISystem
		}
	}

	private void UnLockSpecialCompany()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.CompanyList == null || stageData.UnLockCompanyList == null) return;

		foreach (var companyIdx in stageData.CompanyList)
		{
			if (!ProjectUtility.IsSpecialCompany(companyIdx))
				continue;

			bool alreadyUnlocked = false;
			for (int i = 0; i < stageData.UnLockCompanyList.Count; i++)
			{
				if (stageData.UnLockCompanyList[i] == companyIdx)
				{
					alreadyUnlocked = true;
					break;
				}
			}

			if (!alreadyUnlocked)
			{
				if (IsUnlockCompany(companyIdx, curMode.ActiveRegion, stageData.StageIdx))
				{
					stageData.UnLockCompanyList.Add(companyIdx);
				}
			}
		}
	}

	public void UpdateOneSecond()
	{
		if (RemainRefreshTime != null && RemainRefreshTime.Value > 0)
		{
			RemainRefreshTime.Value = RemainRefreshTime.Value - 1;
		}

		if (EnableMeetingTime && meetingroom_use_time > 0)
		{
			meetingroom_use_time--;
			if (meetingroom_use_time <= 0)
			{
				EnableMeetingTime = false;
			}
		}

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		var stageData = curMode.StageData;
		if (stageData.Offices == null) return;

		foreach (var kvp in stageData.Offices)
		{
			var office = kvp.Value;
			if (office == null) continue;

			if (office.OpenRemainTime != null && office.OpenRemainTime.Value > 0)
			{
				office.OpenRemainTime.Value = office.OpenRemainTime.Value - 1;
			}

			if (office.CompanyRemainTime != null && office.CompanyRemainTime.Value > 0)
			{
				office.CompanyRemainTime.Value = office.CompanyRemainTime.Value - 1;
			}

			if (office.MaintenanceRemainTime != null && office.MaintenanceRemainTime.Value > 0)
			{
				office.MaintenanceRemainTime.Value = office.MaintenanceRemainTime.Value - 1;
			}

			if (office.RepaireGuardRemainTime != null && office.RepaireGuardRemainTime.Value > 0)
			{
				office.RepaireGuardRemainTime.Value = office.RepaireGuardRemainTime.Value - 1;
			}
		}

		UnLockSpecialCompany();
	}

	public bool CheckCompanyExpRewardEnable(int regionType, bool bShowAlertToast, bool bShowRecontract)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return false;

		var stageData = curMode.StageData;
		if (stageData.Companies == null) return false;

		for (int i = 0; i < stageData.Companies.Count; i++)
		{
			var comp = stageData.Companies[i];
			if (comp == null) continue;

			if (comp.IsMaxLevel() && !comp.MaxReward)
			{
				return true;
			}

			if (bShowRecontract && comp.IsMaxLevel() && comp.MaxReward)
			{
				return true;
			}
		}

		return false;
	}

	public int CalcCompanyLevelUpGem(int companyIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return 0;

		var stageData = curMode.StageData;
		if (stageData.Companies == null) return 0;

		CompanyData companyData = null;
		for (int i = 0; i < stageData.Companies.Count; i++)
		{
			if (stageData.Companies[i] != null && stageData.Companies[i].Idx == companyIdx)
			{
				companyData = stageData.Companies[i];
				break;
			}
		}

		if (companyData == null) return 0;
		if (companyData.IsMaxLevel()) return 0;

		int baseCost = company_list_reset_gem_count;
		int levelMultiplier = 1 + companyData.Level / 5;
		return baseCost * levelMultiplier;
	}

	public bool CompanyLevelUpByGem(int companyIdx, bool openInsufficientShop, TpAnalyticsProp.LogCostCashPlace place)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		int gemCost = CalcCompanyLevelUpGem(companyIdx);
		if (gemCost <= 0) return false;

		int currentCash = gameRoot.UserData.Cash != null ? gameRoot.UserData.Cash.Value : 0;
		if (currentCash < gemCost)
		{
			if (openInsufficientShop)
			{
				// Would open shop UI for purchasing gems
			}
			return false;
		}

		gameRoot.UserData.Cash.Value = currentCash - gemCost;
		if (gameRoot.UserData.HUDCash != null)
			gameRoot.UserData.HUDCash.Value = gameRoot.UserData.Cash.Value;

		CompanyLevelUp(companyIdx, false, null);

		return true;
	}
}
