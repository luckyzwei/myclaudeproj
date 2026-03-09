namespace KWCore.SaveData
{
	public class BucketQueensEvent : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_QUEENS_EVENT";

		[KeyBool]
		public const string IS_MIGRATED = "is_migrated";

		[KeyInt]
		public const string REWARD_SET_INDEX = "reward_set_index";

		[KeyLong]
		public const string CUSTOM_EVENT_FINISH_TIME = "custom_event_finish_time";

		[KeyString]
		public const string REWARDS_CLAIMED = "rewards_claimed";

		[KeyBool]
		public const string PLAYED_BEFORE = "played_before";

		private static BucketQueensEvent s_bucketqueensevent;

		public static bool IsMigrated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int RewardSetIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long CustomEventFinishTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static string RewardsClaimed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool PlayedBefore
		{
			get
			{
				return false;
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

		public static void TryMigrate()
		{
		}

		private static BucketQueensEvent GetBucket()
		{
			return null;
		}

		public static bool GetIsMigrated(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIsMigrated(bool value)
		{
		}

		public static int GetRewardSetIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetRewardSetIndex(int value)
		{
		}

		public static int IncrementAndSetRewardSetIndex(int increment = 1)
		{
			return 0;
		}

		public static long GetCustomEventFinishTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetCustomEventFinishTime(long value)
		{
		}

		public static string GetRewardsClaimed(string defaultValue = null)
		{
			return null;
		}

		public static void SetRewardsClaimed(string value)
		{
		}

		public static bool GetPlayedBefore(bool defaultValue = false)
		{
			return false;
		}

		public static void SetPlayedBefore(bool value)
		{
		}
	}
}
