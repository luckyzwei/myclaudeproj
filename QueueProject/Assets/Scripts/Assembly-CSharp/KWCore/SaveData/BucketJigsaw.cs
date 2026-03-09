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
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<string> EventIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool HasSeenIap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int TierCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long FirstRvPurchaseTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static bool IsJigsawFtueHandActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool JigsawGrandPrizeRewardMigrationCompleted
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

		private static BucketJigsaw GetBucket()
		{
			return null;
		}

		public static bool GetJigsawPuzzleUnlocked(bool defaultValue = false)
		{
			return false;
		}

		public static void SetJigsawPuzzleUnlocked(bool value)
		{
		}

		public static List<int> GetCollectedPiecesBits(string subkey)
		{
			return null;
		}

		public static void SetCollectedPiecesBits(string subkey, List<int> value)
		{
		}

		public static List<int> GetVisitedPiecesBits(string subkey)
		{
			return null;
		}

		public static void SetVisitedPiecesBits(string subkey, List<int> value)
		{
		}

		public static bool GetClaimed(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetClaimed(string subkey, bool value)
		{
		}

		public static List<string> GetEventIds()
		{
			return null;
		}

		public static void SetEventIds(List<string> value)
		{
		}

		public static bool GetIsEventActive(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetIsEventActive(string subkey, bool value)
		{
		}

		public static bool GetGrandPrizeClaimed(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetGrandPrizeClaimed(string subkey, bool value)
		{
		}

		public static bool GetShownStartPopup(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetShownStartPopup(string subkey, bool value)
		{
		}

		public static List<string> GetPuzzleIds(string subkey)
		{
			return null;
		}

		public static void SetPuzzleIds(string subkey, List<string> value)
		{
		}

		public static string GetEventName(string subkey, string defaultValue = null)
		{
			return null;
		}

		public static void SetEventName(string subkey, string value)
		{
		}

		public static bool GetHasSeenIap(bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasSeenIap(bool value)
		{
		}

		public static bool GetHasSeenIapFlow(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasSeenIapFlow(string subkey, bool value)
		{
		}

		public static int GetTierCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetTierCount(int value)
		{
		}

		public static int IncrementAndSetTierCount(int increment = 1)
		{
			return 0;
		}

		public static long GetFirstRvPurchaseTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetFirstRvPurchaseTime(long value)
		{
		}

		public static bool GetHasPuzzleBeenOfferedToFinish(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasPuzzleBeenOfferedToFinish(string subkey, bool value)
		{
		}

		public static bool GetIsJigsawFtueHandActive(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIsJigsawFtueHandActive(bool value)
		{
		}

		public static bool GetJigsawGrandPrizeRewardMigrationCompleted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetJigsawGrandPrizeRewardMigrationCompleted(bool value)
		{
		}
	}
}
