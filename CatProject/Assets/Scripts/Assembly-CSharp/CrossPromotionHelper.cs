public static class CrossPromotionHelper
{
	private static string MY_CAMPAIGN_NAME;

	private static void SetMyCampaignName()
	{
	}

	public static void OpenCrossPromotionPage()
	{
	}

	public static bool CheckPossibleClaimReward(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return false;
	}

	public static bool IsLinkRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return false;
	}

	public static bool IsLinkRewarded(PageCrossPromotion.APP_IDX appIdx)
	{
		return false;
	}

	public static bool IsShareRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return false;
	}

	public static void SetLinkRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
	}

	public static void SetShareRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
	}

	public static PageCrossPromotion.APP_IDX GetCrossPromotionAppIdx(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return default(PageCrossPromotion.APP_IDX);
	}

	public static string GenerateUserInviteLink(PageCrossPromotion.APP_IDX appIdx)
	{
		return null;
	}

	private static string GenerateUserInviteLink(string origin, string templete_id, string chaanel)
	{
		return null;
	}

	public static bool IsShowRedDot()
	{
		return false;
	}

	public static bool IsPreRegister(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return false;
	}
}
