using System.Collections.Generic;

namespace KWCore.SaveData
{
	public class BucketJigsaw : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_JIGSAW";

		[KeyBool]
		public const string JIGSAW_PUZZLE_UNLOCKED = "jigsaw_puzzle_unlocked";

		[SubkeyList(typeof(int))]
		public const string COLLECTED_PIECES_BITS = "collected_pieces_bits";

		[SubkeyList(typeof(int))]
		public const string VISITED_PIECES_BITS = "visited_pieces_bits";

		[SubkeyBool]
		public const string CLAIMED = "claimed";

		[KeyList(typeof(string))]
		public const string EVENT_IDS = "event_ids";

		[SubkeyBool]
		public const string IS_EVENT_ACTIVE = "is_event_active";

		[SubkeyBool]
		public const string GRAND_PRIZE_CLAIMED = "grand_prize_claimed";

		[SubkeyBool]
		public const string SHOWN_START_POPUP = "shown_start_popup";

		[SubkeyList(typeof(string))]
		public const string PUZZLE_IDS = "puzzle_ids";

		[SubkeyString]
		public const string EVENT_NAME = "event_name";

		[KeyBool]
		public const string HAS_SEEN_IAP = "has_seen_iap";

		[SubkeyBool]
		public const string HAS_SEEN_IAP_FLOW = "has_seen_iap_flow";

		[KeyInt]
		public const string TIER_COUNT = "tier_count";

		[KeyLong]
		public const string FIRST_RV_PURCHASE_TIME = "first_rv_purchase_time";

		[SubkeyBool]
		public const string HAS_PUZZLE_BEEN_OFFERED_TO_FINISH = "has_puzzle_been_offered_to_finish";

		[KeyBool]
		public const string IS_JIGSAW_FTUE_HAND_ACTIVE = "is_jigsaw_ftue_hand_active";

		[KeyBool]
		public const string JIGSAW_GRAND_PRIZE_REWARD_MIGRATION_COMPlETED = "jigsaw_grand_prize_reward_migration_completed";

		private static BucketJigsaw s_bucketjigsaw;

		public static bool JigsawPuzzleUnlocked
		{
			get { return GetBucket().GetBool(JIGSAW_PUZZLE_UNLOCKED); }
			set { GetBucket().SetBool(JIGSAW_PUZZLE_UNLOCKED, value); }
		}

		public static List<string> EventIds
		{
			get { return GetBucket().GetList<string>(EVENT_IDS); }
			set { GetBucket().SetList(EVENT_IDS, value); }
		}

		public static bool HasSeenIap
		{
			get { return GetBucket().GetBool(HAS_SEEN_IAP); }
			set { GetBucket().SetBool(HAS_SEEN_IAP, value); }
		}

		public static int TierCount
		{
			get { return GetBucket().GetInt(TIER_COUNT); }
			set { GetBucket().SetInt(TIER_COUNT, value); }
		}

		public static long FirstRvPurchaseTime
		{
			get { return GetBucket().GetLong(FIRST_RV_PURCHASE_TIME); }
			set { GetBucket().SetLong(FIRST_RV_PURCHASE_TIME, value); }
		}

		public static bool IsJigsawFtueHandActive
		{
			get { return GetBucket().GetBool(IS_JIGSAW_FTUE_HAND_ACTIVE); }
			set { GetBucket().SetBool(IS_JIGSAW_FTUE_HAND_ACTIVE, value); }
		}

		public static bool JigsawGrandPrizeRewardMigrationCompleted
		{
			get { return GetBucket().GetBool(JIGSAW_GRAND_PRIZE_REWARD_MIGRATION_COMPlETED); }
			set { GetBucket().SetBool(JIGSAW_GRAND_PRIZE_REWARD_MIGRATION_COMPlETED, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketJigsaw GetBucket()
		{
			if (s_bucketjigsaw == null)
			{
				s_bucketjigsaw = new BucketJigsaw();
				s_bucketjigsaw.LoadFromDisk();
			}
			return s_bucketjigsaw;
		}

		public static bool GetJigsawPuzzleUnlocked(bool defaultValue = false)
		{
			return GetBucket().GetBool(JIGSAW_PUZZLE_UNLOCKED, defaultValue);
		}

		public static void SetJigsawPuzzleUnlocked(bool value)
		{
			GetBucket().SetBool(JIGSAW_PUZZLE_UNLOCKED, value);
			GetBucket().SaveToDisk();
		}

		public static List<int> GetCollectedPiecesBits(string subkey)
		{
			return GetBucket().GetList<int>(COLLECTED_PIECES_BITS, subkey);
		}

		public static void SetCollectedPiecesBits(string subkey, List<int> value)
		{
			GetBucket().SetList(COLLECTED_PIECES_BITS, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static List<int> GetVisitedPiecesBits(string subkey)
		{
			return GetBucket().GetList<int>(VISITED_PIECES_BITS, subkey);
		}

		public static void SetVisitedPiecesBits(string subkey, List<int> value)
		{
			GetBucket().SetList(VISITED_PIECES_BITS, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetClaimed(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(CLAIMED, defaultValue, subkey);
		}

		public static void SetClaimed(string subkey, bool value)
		{
			GetBucket().SetBool(CLAIMED, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static List<string> GetEventIds()
		{
			return GetBucket().GetList<string>(EVENT_IDS);
		}

		public static void SetEventIds(List<string> value)
		{
			GetBucket().SetList(EVENT_IDS, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetIsEventActive(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(IS_EVENT_ACTIVE, defaultValue, subkey);
		}

		public static void SetIsEventActive(string subkey, bool value)
		{
			GetBucket().SetBool(IS_EVENT_ACTIVE, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetGrandPrizeClaimed(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(GRAND_PRIZE_CLAIMED, defaultValue, subkey);
		}

		public static void SetGrandPrizeClaimed(string subkey, bool value)
		{
			GetBucket().SetBool(GRAND_PRIZE_CLAIMED, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetShownStartPopup(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(SHOWN_START_POPUP, defaultValue, subkey);
		}

		public static void SetShownStartPopup(string subkey, bool value)
		{
			GetBucket().SetBool(SHOWN_START_POPUP, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static List<string> GetPuzzleIds(string subkey)
		{
			return GetBucket().GetList<string>(PUZZLE_IDS, subkey);
		}

		public static void SetPuzzleIds(string subkey, List<string> value)
		{
			GetBucket().SetList(PUZZLE_IDS, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static string GetEventName(string subkey, string defaultValue = null)
		{
			return GetBucket().GetString(EVENT_NAME, defaultValue, subkey);
		}

		public static void SetEventName(string subkey, string value)
		{
			GetBucket().SetString(EVENT_NAME, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetHasSeenIap(bool defaultValue = false)
		{
			return GetBucket().GetBool(HAS_SEEN_IAP, defaultValue);
		}

		public static void SetHasSeenIap(bool value)
		{
			GetBucket().SetBool(HAS_SEEN_IAP, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetHasSeenIapFlow(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(HAS_SEEN_IAP_FLOW, defaultValue, subkey);
		}

		public static void SetHasSeenIapFlow(string subkey, bool value)
		{
			GetBucket().SetBool(HAS_SEEN_IAP_FLOW, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static int GetTierCount(int defaultValue = 0)
		{
			return GetBucket().GetInt(TIER_COUNT, defaultValue);
		}

		public static void SetTierCount(int value)
		{
			GetBucket().SetInt(TIER_COUNT, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetTierCount(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(TIER_COUNT, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static long GetFirstRvPurchaseTime(long defaultValue = 0L)
		{
			return GetBucket().GetLong(FIRST_RV_PURCHASE_TIME, defaultValue);
		}

		public static void SetFirstRvPurchaseTime(long value)
		{
			GetBucket().SetLong(FIRST_RV_PURCHASE_TIME, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetHasPuzzleBeenOfferedToFinish(string subkey, bool defaultValue = false)
		{
			return GetBucket().GetBool(HAS_PUZZLE_BEEN_OFFERED_TO_FINISH, defaultValue, subkey);
		}

		public static void SetHasPuzzleBeenOfferedToFinish(string subkey, bool value)
		{
			GetBucket().SetBool(HAS_PUZZLE_BEEN_OFFERED_TO_FINISH, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static bool GetIsJigsawFtueHandActive(bool defaultValue = false)
		{
			return GetBucket().GetBool(IS_JIGSAW_FTUE_HAND_ACTIVE, defaultValue);
		}

		public static void SetIsJigsawFtueHandActive(bool value)
		{
			GetBucket().SetBool(IS_JIGSAW_FTUE_HAND_ACTIVE, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetJigsawGrandPrizeRewardMigrationCompleted(bool defaultValue = false)
		{
			return GetBucket().GetBool(JIGSAW_GRAND_PRIZE_REWARD_MIGRATION_COMPlETED, defaultValue);
		}

		public static void SetJigsawGrandPrizeRewardMigrationCompleted(bool value)
		{
			GetBucket().SetBool(JIGSAW_GRAND_PRIZE_REWARD_MIGRATION_COMPlETED, value);
			GetBucket().SaveToDisk();
		}
	}
}
