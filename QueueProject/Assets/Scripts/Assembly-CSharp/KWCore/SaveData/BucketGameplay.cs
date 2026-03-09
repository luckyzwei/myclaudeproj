using System.Collections.Generic;

namespace KWCore.SaveData
{
	public class BucketGameplay : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_GAMEPLAY";

		[KeyBool]
		public const string MILESTONES_SENT = "milestones_sent";

		[KeyBool]
		public const string FTUE_GAMEPLAY_COMPLETED = "ftue_gameplay";

		[KeyInt]
		public const string NUM_QUEEN_EVENT_GEMS_COLLECTED = "num_queen_event_gems_collected";

		[KeyInt]
		public const string NUM_LAST_SEEN_GEMS = "num_last_seen_gems";

		[KeyString]
		public const string QUEEN_EVENT_REWARDS_CLAIMED = "queen_event_rewards_claimed";

		[KeyBool]
		public const string QUEEN_EVENT_INFO_SEEN = "queen_event_info_seen";

		[SubkeyInt]
		public const string DAILY_CHALLENGE_ATTEMPS = "daily_challenge_attempts";

		[KeyBool]
		public const string GEM_MIGRATION_COMPLETED = "gem_migration_completed";

		[KeyInt]
		public const string LAST_QUEENS_EVENT_START_DAY = "last_queens_event_start_day";

		[KeyInt]
		public const string LAST_QUEENS_START_POPUP_SEEN = "last_queens_event_start_popup_seen";

		[KeyInt]
		public const string GEMS_STARTING_THIS_EVENT = "gems_starting_this_event";

		[KeyBool]
		public const string FIRST_BOOT = "first_boot";

		[KeyString]
		public const string CONTROL_SCHEME_NAME = "control_scheme_name";

		[KeyInt]
		public const string LOSES_IN_ROW = "loses_in_row";

		[KeyInt]
		public const string SHOWN_TUTORIAL_AMOUNT = "shown_tutorial_amount";

		[KeyInt]
		public const string LAST_LEVEL_TUTORIAL_WAS_SHOWN = "last_level_tutorial_was_shown";

		[KeyInt]
		public const string JIGSAW_PIECES_TO_GIVE = "jigsaw_pieces_to_give";

		[KeyBool]
		public const string JIGSAW_FTUE = "jigsaw_ftue";

		[KeyString]
		public const string JIGSAW_EVENT_UNCLAIMED_REWARDS = "jigsaw_event_unclaimed_rewards";

		[KeyInt]
		public const string QUEENS_EVENT_REWARD_INDEX = "queens_event_reward_index";

		[KeyBool]
		public const string KILLED_DURING_AD = "killed_during_ad";

		[KeyInt]
		public const string CHECKOUT_VIP_TIMES = "checkout_vip_times";

		[KeyBool]
		public const string LAST_SEEN_DISCOUNTED = "last_seen_discounted";

		[KeyBool]
		public const string STARTING_PIECES_GIVEN = "starting_pieces_given";

		[KeyBool]
		public const string SEEN_JIGSAW_FTUE = "seen_jigsaw_ftue";

		[KeyBool]
		public const string SWIPE_TO_X_DISCOVERED = "swipe_to_x_discovered";

		[KeyBool]
		public const string HAS_COLLECTED_ALL_QUEENS_REWARDS = "collected_all_queen_rewards";

		[KeyString]
		public const string VISITED_COLLECTIONS = "visited_locations";

		[KeyInt]
		public const string FORCED_HOME_FEATURES = "forced_home_features";

		[KeyBool]
		public const string ACCESIBILITY_ON = "accesiblity_on";

		[KeyBool]
		public const string GRAND_PRIZE_MIGRATION_DONE = "grand_prize_mig";

		[KeyBool]
		public const string NAKAMA_SYNCED = "nakama_synced";

		[KeyBool]
		public const string SWIPE_TUTORIAL_DISPLAYED = "swipe_tutorial_displayed";

		[KeyInt]
		public const string LAST_LEVEL_PLAYER_SWIPED = "last_level_player_swiped";

		[KeyBool]
		public const string SWIPE_EVENT_SENT_OTHER_LEVELS = "swipe_event_sent_other_levels";

		[KeyString]
		public const string AVATARS_USED = "avatars_used";

		[KeyBool]
		public const string RV_DC_COMPLETED = "rv_dc_completed";

		[KeyInt]
		public const string RV_IAP_SUGGEST_DAY = "rv_iap_suggest_day";

		[KeyList(typeof(string))]
		public const string PROFILE_BG_ANALYTICS_SENT_FOR = "profile_bg_analytics_sent_for";

		[KeyBool]
		public const string SHOW_CONTROL_SCHEME_DEBUG = "show_control_scheme_debug";

		[KeyString]
		public const string DC_FREE_LEVEL = "dc_free_level";

		[KeyInt]
		public const string GAMEPLAY_FREE_LEVEL = "gameplay_free_level";

		[SubkeyBool]
		public const string FEATURE_UPDATE_SHOWN = "feature_update_shown";

		[KeyBool]
		public const string SEEN_SKIN_UNLOCK = "seen_skin_unlock";

		[KeyBool]
		public const string FREE_AUTO_X_USED = "free_auto_x_used";

		[KeyBool]
		public const string FREE_AUTO_X_MIGRATED = "free_auto_x_migrated";

		[KeyBool]
		public const string BALANCY_CARNIVAL_MIGRATED = "balancy_carnival_migrated";

		[KeyInt]
		public const string EXPERT_MODE_CURRENT_LEVEL = "expert_mode_current_level";

		private static BucketGameplay s_bucketgameplay;

		public static bool MilestonesSent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool FtueGameplayCompleted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int NumQueenEventGemsCollected
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int NumLastSeenGems
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string QueenEventRewardsClaimed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool QueenEventInfoSeen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool GemMigrationCompleted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LastQueensEventStartDay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastQueensStartPopupSeen
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int GemsStartingThisEvent
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool FirstBoot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string ControlSchemeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int LosesInRow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int ShownTutorialAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastLevelTutorialWasShown
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int JigsawPiecesToGive
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool JigsawFtue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string JigsawEventUnclaimedRewards
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int QueensEventRewardIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool KilledDuringAd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int CheckoutVipTimes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool LastSeenDiscounted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool StartingPiecesGiven
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SeenJigsawFtue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SwipeToXDiscovered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HasCollectedAllQueensRewards
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string VisitedCollections
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int ForcedHomeFeatures
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool AccesibilityOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool GrandPrizeMigrationDone
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool NakamaSynced
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SwipeTutorialDisplayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LastLevelPlayerSwiped
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool SwipeEventSentOtherLevels
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string AvatarsUsed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool RvDcCompleted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int RvIapSuggestDay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static List<string> ProfileBgAnalyticsSentFor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool ShowControlSchemeDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string DcFreeLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int GameplayFreeLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool SeenSkinUnlock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool FreeAutoXUsed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool FreeAutoXMigrated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool BalancyCarnivalMigrated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int ExpertModeCurrentLevel
		{
			get
			{
				return 0;
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

		private static BucketGameplay GetBucket()
		{
			return null;
		}

		public static bool GetMilestonesSent(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMilestonesSent(bool value)
		{
		}

		public static bool GetFtueGameplayCompleted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetFtueGameplayCompleted(bool value)
		{
		}

		public static int GetNumQueenEventGemsCollected(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetNumQueenEventGemsCollected(int value)
		{
		}

		public static int IncrementAndSetNumQueenEventGemsCollected(int increment = 1)
		{
			return 0;
		}

		public static int GetNumLastSeenGems(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetNumLastSeenGems(int value)
		{
		}

		public static int IncrementAndSetNumLastSeenGems(int increment = 1)
		{
			return 0;
		}

		public static string GetQueenEventRewardsClaimed(string defaultValue = null)
		{
			return null;
		}

		public static void SetQueenEventRewardsClaimed(string value)
		{
		}

		public static bool GetQueenEventInfoSeen(bool defaultValue = false)
		{
			return false;
		}

		public static void SetQueenEventInfoSeen(bool value)
		{
		}

		public static int GetDailyChallengeAttemps(string subkey, int defaultValue = 0)
		{
			return 0;
		}

		public static void SetDailyChallengeAttemps(string subkey, int value)
		{
		}

		public static int IncrementAndSetDailyChallengeAttemps(string subkey, int increment = 1)
		{
			return 0;
		}

		public static bool GetGemMigrationCompleted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetGemMigrationCompleted(bool value)
		{
		}

		public static int GetLastQueensEventStartDay(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastQueensEventStartDay(int value)
		{
		}

		public static int IncrementAndSetLastQueensEventStartDay(int increment = 1)
		{
			return 0;
		}

		public static int GetLastQueensStartPopupSeen(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastQueensStartPopupSeen(int value)
		{
		}

		public static int IncrementAndSetLastQueensStartPopupSeen(int increment = 1)
		{
			return 0;
		}

		public static int GetGemsStartingThisEvent(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetGemsStartingThisEvent(int value)
		{
		}

		public static int IncrementAndSetGemsStartingThisEvent(int increment = 1)
		{
			return 0;
		}

		public static bool GetFirstBoot(bool defaultValue = false)
		{
			return false;
		}

		public static void SetFirstBoot(bool value)
		{
		}

		public static string GetControlSchemeName(string defaultValue = null)
		{
			return null;
		}

		public static void SetControlSchemeName(string value)
		{
		}

		public static int GetLosesInRow(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLosesInRow(int value)
		{
		}

		public static int IncrementAndSetLosesInRow(int increment = 1)
		{
			return 0;
		}

		public static int GetShownTutorialAmount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetShownTutorialAmount(int value)
		{
		}

		public static int IncrementAndSetShownTutorialAmount(int increment = 1)
		{
			return 0;
		}

		public static int GetLastLevelTutorialWasShown(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastLevelTutorialWasShown(int value)
		{
		}

		public static int IncrementAndSetLastLevelTutorialWasShown(int increment = 1)
		{
			return 0;
		}

		public static int GetJigsawPiecesToGive(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetJigsawPiecesToGive(int value)
		{
		}

		public static int IncrementAndSetJigsawPiecesToGive(int increment = 1)
		{
			return 0;
		}

		public static bool GetJigsawFtue(bool defaultValue = false)
		{
			return false;
		}

		public static void SetJigsawFtue(bool value)
		{
		}

		public static string GetJigsawEventUnclaimedRewards(string defaultValue = null)
		{
			return null;
		}

		public static void SetJigsawEventUnclaimedRewards(string value)
		{
		}

		public static int GetQueensEventRewardIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetQueensEventRewardIndex(int value)
		{
		}

		public static int IncrementAndSetQueensEventRewardIndex(int increment = 1)
		{
			return 0;
		}

		public static bool GetKilledDuringAd(bool defaultValue = false)
		{
			return false;
		}

		public static void SetKilledDuringAd(bool value)
		{
		}

		public static int GetCheckoutVipTimes(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetCheckoutVipTimes(int value)
		{
		}

		public static int IncrementAndSetCheckoutVipTimes(int increment = 1)
		{
			return 0;
		}

		public static bool GetLastSeenDiscounted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetLastSeenDiscounted(bool value)
		{
		}

		public static bool GetStartingPiecesGiven(bool defaultValue = false)
		{
			return false;
		}

		public static void SetStartingPiecesGiven(bool value)
		{
		}

		public static bool GetSeenJigsawFtue(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSeenJigsawFtue(bool value)
		{
		}

		public static bool GetSwipeToXDiscovered(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSwipeToXDiscovered(bool value)
		{
		}

		public static bool GetHasCollectedAllQueensRewards(bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasCollectedAllQueensRewards(bool value)
		{
		}

		public static string GetVisitedCollections(string defaultValue = null)
		{
			return null;
		}

		public static void SetVisitedCollections(string value)
		{
		}

		public static int GetForcedHomeFeatures(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetForcedHomeFeatures(int value)
		{
		}

		public static int IncrementAndSetForcedHomeFeatures(int increment = 1)
		{
			return 0;
		}

		public static bool GetAccesibilityOn(bool defaultValue = false)
		{
			return false;
		}

		public static void SetAccesibilityOn(bool value)
		{
		}

		public static bool GetGrandPrizeMigrationDone(bool defaultValue = false)
		{
			return false;
		}

		public static void SetGrandPrizeMigrationDone(bool value)
		{
		}

		public static bool GetNakamaSynced(bool defaultValue = false)
		{
			return false;
		}

		public static void SetNakamaSynced(bool value)
		{
		}

		public static bool GetSwipeTutorialDisplayed(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSwipeTutorialDisplayed(bool value)
		{
		}

		public static int GetLastLevelPlayerSwiped(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastLevelPlayerSwiped(int value)
		{
		}

		public static int IncrementAndSetLastLevelPlayerSwiped(int increment = 1)
		{
			return 0;
		}

		public static bool GetSwipeEventSentOtherLevels(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSwipeEventSentOtherLevels(bool value)
		{
		}

		public static string GetAvatarsUsed(string defaultValue = null)
		{
			return null;
		}

		public static void SetAvatarsUsed(string value)
		{
		}

		public static bool GetRvDcCompleted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetRvDcCompleted(bool value)
		{
		}

		public static int GetRvIapSuggestDay(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetRvIapSuggestDay(int value)
		{
		}

		public static int IncrementAndSetRvIapSuggestDay(int increment = 1)
		{
			return 0;
		}

		public static List<string> GetProfileBgAnalyticsSentFor()
		{
			return null;
		}

		public static void SetProfileBgAnalyticsSentFor(List<string> value)
		{
		}

		public static bool GetShowControlSchemeDebug(bool defaultValue = false)
		{
			return false;
		}

		public static void SetShowControlSchemeDebug(bool value)
		{
		}

		public static string GetDcFreeLevel(string defaultValue = null)
		{
			return null;
		}

		public static void SetDcFreeLevel(string value)
		{
		}

		public static int GetGameplayFreeLevel(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetGameplayFreeLevel(int value)
		{
		}

		public static int IncrementAndSetGameplayFreeLevel(int increment = 1)
		{
			return 0;
		}

		public static bool GetFeatureUpdateShown(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetFeatureUpdateShown(string subkey, bool value)
		{
		}

		public static bool GetSeenSkinUnlock(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSeenSkinUnlock(bool value)
		{
		}

		public static bool GetFreeAutoXUsed(bool defaultValue = false)
		{
			return false;
		}

		public static void SetFreeAutoXUsed(bool value)
		{
		}

		public static bool GetFreeAutoXMigrated(bool defaultValue = false)
		{
			return false;
		}

		public static void SetFreeAutoXMigrated(bool value)
		{
		}

		public static bool GetBalancyCarnivalMigrated(bool defaultValue = false)
		{
			return false;
		}

		public static void SetBalancyCarnivalMigrated(bool value)
		{
		}

		public static int GetExpertModeCurrentLevel(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetExpertModeCurrentLevel(int value)
		{
		}

		public static int IncrementAndSetExpertModeCurrentLevel(int increment = 1)
		{
			return 0;
		}
	}
}
