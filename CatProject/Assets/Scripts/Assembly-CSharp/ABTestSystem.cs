using System.Collections.Generic;

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

	private static readonly string removeads;

	private static readonly string loadingad;

	private static readonly string loadingad2;

	private static readonly string dailyloadingad;

	private static readonly string st1ads;

	private static readonly string str_build1sec;

	private static readonly string str_build1sec2;

	private static readonly string str_seasonalPeriod;

	private static readonly string str_build1sec3;

	private static readonly string str_adsupplyTime;

	private static readonly string str_listAdmissionTest;

	private static readonly string str_officeItemLevelUpAll;

	private Dictionary<E_ABTestType, string> ABTestTypeKeyMap;

	public List<TpParameter> ABTestParameters { get; }

	public void Init()
	{
	}

	private void SetABTestInfo(string testNameKey, int testRecordKey, bool bForceInitABValue, bool bOnlyNewUser = false)
	{
	}

	private string GetLogString(int value)
	{
		return null;
	}

	public bool GetABTestType(E_ABTestType testType)
	{
		return false;
	}

	public bool IsABTestOn(E_ABTestType testType)
	{
		return false;
	}
}
