using System.Collections.Generic;

public class SingularAdData : Dictionary<string, object>
{
	public static class AdPlatforms
	{
		public static readonly string MOPUB;
	}

	private const string ADMON_IS_ADMON_REVENUE = "is_admon_revenue";

	private const string ADMON_AD_PLATFORM = "ad_platform";

	private const string ADMON_CURRENCY = "ad_currency";

	private const string ADMON_REVENUE = "ad_revenue";

	private const string ADMON_NETWORK_NAME = "ad_mediation_platform";

	private const string ADMON_AD_TYPE = "ad_type";

	private const string ADMON_AD_GROUP_TYPE = "ad_group_type";

	private const string ADMON_IMPRESSION_ID = "ad_impression_id";

	private const string ADMON_AD_PLACEMENT_NAME = "ad_placement_name";

	private const string ADMON_AD_UNIT_ID = "ad_unit_id";

	private const string ADMON_AD_UNIT_NAME = "ad_unit_name";

	private const string ADMON_AD_GROUP_ID = "ad_group_id";

	private const string ADMON_AD_GROUP_NAME = "ad_group_name";

	private const string ADMON_AD_GROUP_PRIORITY = "ad_group_priority";

	private const string ADMON_PRECISION = "ad_precision";

	private const string ADMON_PLACEMENT_ID = "ad_placement_id";

	private const string IS_REVENUE_EVENT_KEY = "is_revenue_event";

	private const string REVENUE_AMOUNT_KEY = "r";

	private const string REVENUE_CURRENCY_KEY = "pcc";

	private readonly string[] RequiredParams;

	public SingularAdData(string adPlatform, string currency, double revenue)
	{
		SetValue(ADMON_AD_PLATFORM, adPlatform);
		SetValue(REVENUE_CURRENCY_KEY, currency);
		SetValue(REVENUE_AMOUNT_KEY, revenue);
		SetValue(ADMON_IS_ADMON_REVENUE, true);
		SetValue(IS_REVENUE_EVENT_KEY, true);
	}

	public SingularAdData WithNetworkName(string networkName)
	{
		return null;
	}

	public SingularAdData WithAdType(string adType)
	{
		return null;
	}

	public SingularAdData WithAdGroupType(string adGroupType)
	{
		return null;
	}

	public SingularAdData WithImpressionId(string impressionId)
	{
		return null;
	}

	public SingularAdData WithAdPlacmentName(string adPlacementName)
	{
		return null;
	}

	public SingularAdData WithAdUnitId(string adUnitId)
	{
		return null;
	}

	public SingularAdData WithAdUnitName(string adUnitName)
	{
		return null;
	}

	public SingularAdData WithAdGroupId(string adGroupId)
	{
		return null;
	}

	public SingularAdData WithAdGroupName(string adGroupName)
	{
		return null;
	}

	public SingularAdData WithAdGroupPriority(string adGroupPriority)
	{
		return null;
	}

	public SingularAdData WithPrecision(string precision)
	{
		return null;
	}

	public SingularAdData WithPlacementId(string placementId)
	{
		return null;
	}

	private void SetValue(string key, object value)
	{
	}

	public bool HasRequiredParams()
	{
		return false;
	}
}
