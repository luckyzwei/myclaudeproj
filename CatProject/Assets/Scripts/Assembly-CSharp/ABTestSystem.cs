using System.Collections.Generic;
using Treeplla;

public class ABTestSystem
{
	public enum E_ABTestType
	{
		None = -1,
		RemoveAds = 0,
		LoadingAd = 1,
		LoadingAd2 = 2,
		DailyLoadingAd = 3,
		St1Ads = 4,
		Build1sec = 5,
		Build1sec2 = 6,
		SeasonalPeriod = 7,
		Build1Sec3 = 8,
		AdsupplyTime = 9,
		CompanyListAdTest = 10,
		OfficeItemLevelUpAll = 11
	}

	private Dictionary<int, int> activeABTests;

	private static readonly string removeads = "removeads";
	private static readonly string loadingad = "loadingad";
	private static readonly string loadingad2 = "loadingad2";
	private static readonly string dailyloadingad = "dailyloadingad";
	private static readonly string st1ads = "st1ads";
	private static readonly string str_build1sec = "build1sec";
	private static readonly string str_build1sec2 = "build1sec2";
	private static readonly string str_seasonalPeriod = "seasonalPeriod";
	private static readonly string str_build1sec3 = "build1sec3";
	private static readonly string str_adsupplyTime = "adsupplyTime";
	private static readonly string str_listAdmissionTest = "listAdmissionTest";
	private static readonly string str_officeItemLevelUpAll = "officeItemLevelUpAll";

	private Dictionary<E_ABTestType, string> ABTestTypeKeyMap;

	public List<TpParameter> ABTestParameters { get; }

	public void Init()
	{
		activeABTests = new Dictionary<int, int>();
		ABTestTypeKeyMap = new Dictionary<E_ABTestType, string>
		{
			{ E_ABTestType.RemoveAds, removeads },
			{ E_ABTestType.LoadingAd, loadingad },
			{ E_ABTestType.LoadingAd2, loadingad2 },
			{ E_ABTestType.DailyLoadingAd, dailyloadingad },
			{ E_ABTestType.St1Ads, st1ads },
			{ E_ABTestType.Build1sec, str_build1sec },
			{ E_ABTestType.Build1sec2, str_build1sec2 },
			{ E_ABTestType.SeasonalPeriod, str_seasonalPeriod },
			{ E_ABTestType.Build1Sec3, str_build1sec3 },
			{ E_ABTestType.AdsupplyTime, str_adsupplyTime },
			{ E_ABTestType.CompanyListAdTest, str_listAdmissionTest },
			{ E_ABTestType.OfficeItemLevelUpAll, str_officeItemLevelUpAll }
		};

		SetABTestInfo(removeads, (int)E_ABTestType.RemoveAds, false);
		SetABTestInfo(loadingad, (int)E_ABTestType.LoadingAd, false);
		SetABTestInfo(loadingad2, (int)E_ABTestType.LoadingAd2, false);
		SetABTestInfo(dailyloadingad, (int)E_ABTestType.DailyLoadingAd, false);
		SetABTestInfo(st1ads, (int)E_ABTestType.St1Ads, false);
		SetABTestInfo(str_build1sec, (int)E_ABTestType.Build1sec, false);
		SetABTestInfo(str_build1sec2, (int)E_ABTestType.Build1sec2, false);
		SetABTestInfo(str_seasonalPeriod, (int)E_ABTestType.SeasonalPeriod, false);
		SetABTestInfo(str_build1sec3, (int)E_ABTestType.Build1Sec3, false);
		SetABTestInfo(str_adsupplyTime, (int)E_ABTestType.AdsupplyTime, false);
		SetABTestInfo(str_listAdmissionTest, (int)E_ABTestType.CompanyListAdTest, false);
		SetABTestInfo(str_officeItemLevelUpAll, (int)E_ABTestType.OfficeItemLevelUpAll, false);
	}

	private void SetABTestInfo(string testNameKey, int testRecordKey, bool bForceInitABValue, bool bOnlyNewUser = false)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		long recordValue = root.UserData.GetRecordValue((Config.RecordKeys)testRecordKey);
		if (bForceInitABValue || recordValue == 0)
		{
			int abValue = UnityEngine.Random.Range(0, 2);
			root.UserData.SetRecordValue((Config.RecordKeys)testRecordKey, abValue);
			recordValue = abValue;
		}

		activeABTests[testRecordKey] = (int)recordValue;
	}

	private string GetLogString(int value)
	{
		return value == 1 ? "B" : "A";
	}

	public bool GetABTestType(E_ABTestType testType)
	{
		int key = (int)testType;
		if (activeABTests != null && activeABTests.TryGetValue(key, out int value))
		{
			return value == 1;
		}
		return false;
	}

	public bool IsABTestOn(E_ABTestType testType)
	{
		return GetABTestType(testType);
	}
}
