public static class CrossPromotionHelper
{
	private static string MY_CAMPAIGN_NAME;

	private static void SetMyCampaignName()
	{
		MY_CAMPAIGN_NAME = "catproject";
	}

	public static void OpenCrossPromotionPage()
	{
	}

	public static bool CheckPossibleClaimReward(Config.E_INHOUSE_RESERVATION reservationType)
	{
		if (IsLinkRewarded(reservationType)) return false;
		return true;
	}

	public static bool IsLinkRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	public static bool IsLinkRewarded(PageCrossPromotion.APP_IDX appIdx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	public static bool IsShareRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	public static void SetLinkRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public static void SetShareRewarded(Config.E_INHOUSE_RESERVATION reservationType)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public static PageCrossPromotion.APP_IDX GetCrossPromotionAppIdx(Config.E_INHOUSE_RESERVATION reservationType)
	{
		return (PageCrossPromotion.APP_IDX)(int)reservationType;
	}

	public static string GenerateUserInviteLink(PageCrossPromotion.APP_IDX appIdx)
	{
		if (string.IsNullOrEmpty(MY_CAMPAIGN_NAME))
			SetMyCampaignName();
		return GenerateUserInviteLink("", MY_CAMPAIGN_NAME, appIdx.ToString());
	}

	private static string GenerateUserInviteLink(string origin, string templete_id, string chaanel)
	{
		return $"https://link.treeplla.com/{templete_id}?channel={chaanel}";
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
