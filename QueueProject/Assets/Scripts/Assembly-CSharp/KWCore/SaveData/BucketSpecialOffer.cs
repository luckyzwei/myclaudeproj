namespace KWCore.SaveData
{
	public class BucketSpecialOffer : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_SPECIAL_OFFER";

		[KeyBool]
		private const string MIGRATION_DONE = "migration_done";

		[KeyLong]
		private const string NEXT_OFFER_COOLDOWN = "next_offer_cooldown";

		[KeyLong]
		private const string LAST_DISCOUNT_TRIGGER_TIME = "last_discount_trigger_time";

		[KeyString]
		private const string ACTIVE_SPECIAL_OFFER_ID = "active_special_offer_id";

		[KeyBool]
		private const string ALL_SKINS_OFFER_AVAILABLE = "all_skins_offer_available";

		[KeyBool]
		private const string ALL_SKINS_OFFER_SEEN = "all_skins_offer_seen";

		[KeyInt]
		private const string SPECIAL_OFFER_INDEX = "special_offer_index";

		[KeyLong]
		private const string SPECIAL_OFFER_AVAILABLE_START_TIME = "special_offer_available_start_time";

		[KeyLong]
		private const string SPECIAL_OFFER_AVAILABLE_TIME = "special_offer_available_time";

		[KeyLong]
		private const string NEXT_OFFER_COOLDOWN_START_TIME = "next_offer_cooldown_start_time";

		private static BucketSpecialOffer s_bucketspecialoffer;

		public static bool MigrationDone
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static long NextOfferCooldown
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long LastDiscountTriggerTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static string ActiveSpecialOfferId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool AllSkinsOfferAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool AllSkinsOfferSeen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int SpecialOfferIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long SpecialOfferAvailableStartTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long SpecialOfferAvailableTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long NextOfferCooldownStartTime
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

		private static BucketSpecialOffer GetBucket()
		{
			return null;
		}

		public static bool GetMigrationDone(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMigrationDone(bool value)
		{
		}

		public static long GetNextOfferCooldown(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetNextOfferCooldown(long value)
		{
		}

		public static long GetLastDiscountTriggerTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetLastDiscountTriggerTime(long value)
		{
		}

		public static string GetActiveSpecialOfferId(string defaultValue = null)
		{
			return null;
		}

		public static void SetActiveSpecialOfferId(string value)
		{
		}

		public static bool GetAllSkinsOfferAvailable(bool defaultValue = false)
		{
			return false;
		}

		public static void SetAllSkinsOfferAvailable(bool value)
		{
		}

		public static bool GetAllSkinsOfferSeen(bool defaultValue = false)
		{
			return false;
		}

		public static void SetAllSkinsOfferSeen(bool value)
		{
		}

		public static int GetSpecialOfferIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetSpecialOfferIndex(int value)
		{
		}

		public static int IncrementAndSetSpecialOfferIndex(int increment = 1)
		{
			return 0;
		}

		public static long GetSpecialOfferAvailableStartTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetSpecialOfferAvailableStartTime(long value)
		{
		}

		public static long GetSpecialOfferAvailableTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetSpecialOfferAvailableTime(long value)
		{
		}

		public static long GetNextOfferCooldownStartTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetNextOfferCooldownStartTime(long value)
		{
		}
	}
}
