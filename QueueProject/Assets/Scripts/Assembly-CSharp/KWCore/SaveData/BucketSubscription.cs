namespace KWCore.SaveData
{
	public class BucketSubscription : BucketBase
	{
		[KeyInt]
		private const string BOOT_POPUP_TIMES_SHOWN = "BOOT_POPUP_TIMES_SHOWN";

		[KeyInt]
		private const string BOOT_POPUP_BOOT_COUNT_LAST_SHOWN = "BOOT_POPUP_BOOT_COUNT_LAST_SHOWN";

		[KeyInt]
		private const string GAME_POPUP_TIMES_SHOWN = "GAME_POPUP_TIMES_SHOWN";

		[KeyBool]
		private const string SUB_REWARDS_REVOKED = "SUB_REWARDS_REVOKED";

		[KeyLong]
		private const string WEEKLY_REWARD_VIP = "weekly_reward_vip";

		private static BucketSubscription s_bucketsubscription;

		public static int BootPopupTimesShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int BootPopupBootCountLastShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int GamePopupTimesShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool SubRewardsRevoked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static long WeeklyRewardVip
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static BucketSubscription GetBucket()
		{
			return null;
		}

		public static int GetBootPopupTimesShown(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetBootPopupTimesShown(int value)
		{
		}

		public static int IncrementAndSetBootPopupTimesShown(int increment = 1)
		{
			return 0;
		}

		public static int GetBootPopupBootCountLastShown(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetBootPopupBootCountLastShown(int value)
		{
		}

		public static int IncrementAndSetBootPopupBootCountLastShown(int increment = 1)
		{
			return 0;
		}

		public static int GetGamePopupTimesShown(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetGamePopupTimesShown(int value)
		{
		}

		public static int IncrementAndSetGamePopupTimesShown(int increment = 1)
		{
			return 0;
		}

		public static bool GetSubRewardsRevoked(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSubRewardsRevoked(bool value)
		{
		}

		public static long GetWeeklyRewardVip(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetWeeklyRewardVip(long value)
		{
		}
	}
}
